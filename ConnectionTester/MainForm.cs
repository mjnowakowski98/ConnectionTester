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

		// Load configured libraries
		private void LoadConnectionLibs() {
			connectionTypes.Clear(); // Clear loaded ConnectionTypes
			tsConnectionType.TabPages.Clear(); // Clear loaded UI

			// Iterate through each line in ConnectionLibs.settings
			foreach (SettingsProperty connection in Properties.ConnectionLibs.Default.Properties) {
				// Load the setting specified dll
				Assembly connectionDLL = null;
				try { connectionDLL = Assembly.LoadFrom(@Properties.Settings.Default.ConnectionLibrariesDir + connection.DefaultValue); }
				catch (FileNotFoundException err) { // Tell user the library is invalid
					MessageBox.Show(err.Message, "Error: " + connection.DefaultValue + " not found");
					continue; // Skip this setting
				}

				tsConnectionType.TabPages.Add(connection.Name, connection.Name); // Add new tab using setting name as key/title
				TabPage connectionTab = tsConnectionType.TabPages[connection.Name]; // Get reference to the new page
				connectionTab.AutoScroll = true; // Allow page to scroll

				foreach (Type type in connectionDLL.GetExportedTypes()) { // Iterate through public types in dll (should have UserControl and Connection)
					if (typeof(Connection).IsAssignableFrom(type)) connectionTypes.Add(new ConnectionType(type, connection.Name)); // Register Connection derived class
					else if (typeof(UserControl).IsAssignableFrom(type)) { // Fill tabpage with UserControl
						UserControl control = (UserControl)Activator.CreateInstance(type); // Make new instance
						control.Dock = DockStyle.Fill; // Fill page with control (up to control to implement proper scaling)
						connectionTab.Controls.Add(control); // Add control to page
					}
				}
			}
		}

		private void FillConnectionsList() {
			cbConnections.Items.Clear();
			cbConnections.Items.AddRange(currentConnectionType.ConnectionNames.ToArray());
		}

		// Set active connection type
		private void SetCurrentConnectionType() {
			int ndx = connectionTypes.Count;
			while (--ndx >= 0) { // Find associated ConnectionType
				if (connectionTypes[ndx].TypeKey == tsConnectionType.SelectedTab.Text) {
					currentConnectionType = connectionTypes[ndx]; // Set active
					FillConnectionsList();
					return;
				}
			}
		}

		#region formevents
		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs(); // Load configured libraries
			SetCurrentConnectionType(); // Read the method name 8)
		}

		// Send to server using ConnectionType implementation
		private void btnSendMessage_Click(object sender, EventArgs e) {
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

		private void btnAddConnection_Click(object sender, EventArgs e) {
			NewConnection dialog = new NewConnection(currentConnectionType);
			dialog.ShowDialog();
			FillConnectionsList();
			cbConnections.SelectedIndex = cbConnections.Items.IndexOf(currentConnectionType.CurrentConnection.ConnectionName);
		}

		private void btnDeleteConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			FillConnectionsList();
			if (cbConnections.Items.Count > 0) cbConnections.SelectedIndex = 0;
		}

		// Set active connection type
		private void tsConnectionType_SelectedIndexChanged(object sender, EventArgs e) { SetCurrentConnectionType(); }
		#endregion

		private void cbConnections_SelectedIndexChanged(object sender, EventArgs e) {
			currentConnectionType.SetCurrentConnection(cbConnections.Text);
			tbConnectTo.Text = currentConnectionType.CurrentConnection.HostName;
			tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
		}
	}
}
