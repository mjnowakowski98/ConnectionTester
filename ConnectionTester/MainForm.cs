using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using ConnectionInterface;
using System.IO;

namespace ConnectionTester {
	public partial class MainForm : Form {
		private List<ConnectionType> connectionTypes;
		private ConnectionType currentConnectionType;

		public MainForm() {
			InitializeComponent();
			connectionTypes = new List<ConnectionType>();
			currentConnectionType = null;
		}

		protected void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			switch(e.EventEnum) {
				case EventType.Connected:
					SetConnectedUI();
					break;
				case EventType.Disconnected:
					SetDisconnectedUI(true);
					break;
				default:
					break;
			}

			tbResponses.Text = currentConnectionType.CurrentConnection.Log;
		}

		// Load configured libraries
		private void LoadConnectionLibs() {
			connectionTypes.Clear(); // Clear loaded ConnectionTypes
			tsConnectionType.TabPages.Clear(); // Clear loaded UI

			// Iterate through each line in ConnectionLibs.settings
			foreach (SettingsProperty libSetting in Properties.ConnectionLibs.Default.Properties) {
				// Load the setting specified dll
				Assembly connectionDLL = null;
				try { connectionDLL = Assembly.LoadFrom(@Properties.Settings.Default.ConnectionLibrariesDir + libSetting.DefaultValue); }
				catch (FileNotFoundException err) { // Tell user the library is invalid
					MessageBox.Show(err.Message, "Error: " + libSetting.DefaultValue + " not found");
					continue; // Skip this setting
				}

				tsConnectionType.TabPages.Add(libSetting.Name, libSetting.Name); // Add new tab using setting name as key/title
				TabPage connectionTab = tsConnectionType.TabPages[libSetting.Name]; // Get reference to the new page
				connectionTab.AutoScroll = true; // Allow page to scroll

				foreach (Type type in connectionDLL.GetExportedTypes()) { // Iterate through public types in dll (should only have Connection, assume someone made more)
					if (typeof(Connection).IsAssignableFrom(type))
						connectionTypes.Add(new ConnectionType(type, libSetting.Name)); // Register Connection derived class

					else if (typeof(UserControl).IsAssignableFrom(type)) { // Fill tabpage with UserControl
						UserControl control = (UserControl)Activator.CreateInstance(type); // Make new instance
						control.Dock = DockStyle.Fill; // Fill page with control (up to control to implement proper scaling)
						connectionTab.Controls.Add(control); // Add control to page
					}
				}
			}
		}

		private void FillConnectionsList() {
			cbConnections.Items.Clear(); // Clear current list
			// Populate with connection names
			cbConnections.Items.AddRange(currentConnectionType.ConnectionNames.ToArray());
		}

		private void SetConnectedUI() {
			btnConnect.Enabled = false;
			btnDisconnect.Enabled = true;
			btnSendMessage.Enabled = true;
		}

		private void SetDisconnectedUI(bool connectionSelected) {
			if(connectionSelected) {
				btnConnect.Enabled = true;
				btnDisconnect.Enabled = false;
				btnSendMessage.Enabled = false;
			} else {
				btnConnect.Enabled = false;
				btnDisconnect.Enabled = false;
				btnSendMessage.Enabled = false;
			}
		}

		// Set active connection type
		private void SetCurrentConnectionType() {
			int ndx = connectionTypes.Count;
			while (--ndx >= 0) { // Find associated ConnectionType
				if (connectionTypes[ndx].TypeKey == tsConnectionType.SelectedTab.Text) {
					currentConnectionType = connectionTypes[ndx]; // Set active
					FillConnectionsList(); // Fill the connections list
					return;
				}
			}
		}

		#region formevents
		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs(); // Load configured libraries
			SetCurrentConnectionType(); // Read the method name 8)
			btnSendMessage.Enabled = true;
		}

		// Connect to the server using specified settings
		private void btnConnect_Click(object sender, EventArgs e) {
			if (currentConnectionType == null) return; // Note: Maybe change null detection
			if (currentConnectionType.CurrentConnection == null) return;
			currentConnectionType.CurrentConnection.Connect();
		}

		private void btnDisconnect_Click(object sender, EventArgs e) {
			if (currentConnectionType == null) return; // Note: Maybe change null detection
			if (currentConnectionType.CurrentConnection == null) return;
			currentConnectionType.CurrentConnection.Disconnect();
		}

		// Send to server using ConnectionType implementation
		private void btnSendMessage_Click(object sender, EventArgs e) {
			cbConnections.SelectedIndex = -1;
			if(currentConnectionType.CurrentConnection != null)
				currentConnectionType.CurrentConnection.Send();
		}

		// Show connection libraries dialog
		private void btnConnectionLibs_Click(object sender, EventArgs e) {
			DialogResult dr = new DialogResult(); // Instantiate object to get DialogResults
			ConnectionLibs dialog = new ConnectionLibs();
			dr = dialog.ShowDialog(); // Show the dialog
			if (dr == DialogResult.Yes) LoadConnectionLibs(); // Reload libraries
		}

		// Add connection to connection type
		private void btnAddConnection_Click(object sender, EventArgs e) {
			DialogResult dr;
			NewConnection dialog = new NewConnection(currentConnectionType);
			dr = dialog.ShowDialog(); // Show NewConnection dialog
			if (dr != DialogResult.OK) return;

			currentConnectionType.CurrentConnection.ConnectionEvent += OnConnectionEvent; // Register event handler
			FillConnectionsList(); // Does what it says
			// Set current type active connection to new connection
			cbConnections.SelectedIndex = cbConnections.Items.IndexOf(currentConnectionType.CurrentConnection.ConnectionName);
		}

		// Remove selected connection from connection type
		private void btnDeleteConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			cbConnections.SelectedIndex = currentConnectionType.NumConnections - 1;
			FillConnectionsList();
		}

		// Set active connection type
		private void tsConnectionType_SelectedIndexChanged(object sender, EventArgs e) { SetCurrentConnectionType(); }
		#endregion

		// Set active connection
		private void cbConnections_SelectedIndexChanged(object sender, EventArgs e) {
			currentConnectionType.SetCurrentConnectionByName(cbConnections.Text);
			if (currentConnectionType.CurrentConnection != null) {
				tbConnectTo.Text = currentConnectionType.CurrentConnection.HostName;
				tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
				tbResponses.Text = currentConnectionType.CurrentConnection.Log;

				if(currentConnectionType.CurrentConnection.IsConnected) SetConnectedUI();
				else SetDisconnectedUI(true);
			} else {
				tbConnectTo.Text = "";
				tbPortNum.Text = "";
				tbResponses.Text = "";
				SetDisconnectedUI(false);
			}
		}
	}
}
