using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using ConnectionInterface;


namespace ConnectionTester {
    public partial class MainForm : Form {
		private List<ConnectionType> loadedTypes;
		private ConnectionType currentConnectionType;

		// Setup a default Connectiontype with no Connection
        public MainForm() {
            InitializeComponent();
			loadedTypes = new List<ConnectionType>();
			loadedTypes.Add(new ConnectionType(typeof(NoConnection), "No Type", new UIControl()));
        }

		// Update UI for current connection on event from any connection
		// (connection information is stored in the connection class)
		private void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
			tbLog.Text = currentConnectionType.CurrentConnection.Log;
		}

		#region uifunctions
		// Set connection button states
		private void SetConnectedUI(bool connected) {
			if(currentConnectionType.CurrentConnection is NoConnection) {
                // Disable everything as there is nothing to connect to
				btnConnect.Enabled = false;
				btnDisconnect.Enabled = false;
				btnUpdate.Enabled = false;
				btnSend.Enabled = false;
				tbHostName.Enabled = false;
				tbPortNum.Enabled = false;
                currentConnectionType.UIControl.Enabled = false; // No connection, no UserControl
				return;
			}

            // If connected
			btnConnect.Enabled = !connected; // Can not connect again
			btnDisconnect.Enabled = connected; // Can disconnect
			btnUpdate.Enabled = !connected; // Can not update host/port
			btnSend.Enabled = connected; // can send data
			tbHostName.Enabled = !connected; // Can not update host
			tbPortNum.Enabled = !connected; // Can not update port
            currentConnectionType.UIControl.Enabled = true; // Always able to use ConnectionType's UserControl
            currentConnectionType.UIControl.SetConnectedUI(connected);
		}

		// Add the connection control to the ConnectionType's tab page
		private void SetTabPageControl(TabPage page, ConnectionType connectionType) {
			UserControl tmp = connectionType.UIControl;
			tmp.Dock = DockStyle.Fill;
			page.Controls.Add(tmp);
		}

		// Setup tab pages for loaded ConnectionTypes
		private void SetupConnectionSwitcher() {
			tsConnectionLibs.SelectedIndex = -1; // Reset selected index
			tsConnectionLibs.TabPages.Clear(); // Clear tab pages
			foreach (ConnectionType connectionType in loadedTypes) {
				TabPage page = new TabPage(connectionType.TypeKey);
				SetTabPageControl(page, connectionType);
				tsConnectionLibs.TabPages.Add(page);
			}
		}

		// Fill the list of connections for the current ConnectionType
		private void FillConnectionsList() {
			cbConnections.Items.Clear(); // Clear connections list
			// Add connection names from ConnectionType
			cbConnections.Items.AddRange(currentConnectionType.ConnectionNames.ToArray());
			cbConnections.SelectedIndex = currentConnectionType.CurrentConnectionNdx; // Select list item from current connection
		}
		#endregion

		private void ClearConnectionTypes() {
			foreach (ConnectionType connectionType in loadedTypes)
				connectionType.CloseAllConnections();
			loadedTypes.Clear(); // Clear loaded ConnectionTypes
		}

		// Load ConnectionType libraries based on application settings
		private void LoadConnectionLibs() {
			ClearConnectionTypes();
            foreach (SettingsProperty libSetting in Properties.ConnectionLibs.Default.Properties) {
				// Load connection dll
                Assembly connectionDLL = null;
                try { connectionDLL = Assembly.LoadFrom(Properties.Settings.Default.ConnectionLibrariesDir + libSetting.DefaultValue); }
                catch (FileNotFoundException err) {
					MessageBox.Show(err.Message, libSetting.DefaultValue + " not found");
					continue; // Skip invalid type
                }

				// Find exported Connection derived type
				foreach (Type type in connectionDLL.GetExportedTypes()) {
					if (!typeof(Connection).IsAssignableFrom(type)) continue; // Skip incorrect type
					Connection tmp = (Connection)Activator.CreateInstance(type, new object[] { null, null, 0 });
					ConnectionType tmpType = new ConnectionType(type, libSetting.Name, tmp.GetUIControl());
					loadedTypes.Add(tmpType);
					break; // Only accept first derived type
				}
			}

			// Create a blank ConnectionType with no Connection if nothing is loaded
			if (loadedTypes.Count <= 0) loadedTypes.Add(new ConnectionType(typeof(NoConnection), "NoType", new UIControl()));

			SetupConnectionSwitcher(); // Setup tab switcher with loaded types
			tsConnectionLibs.SelectedIndex = 0; // Select first tab page
            currentConnectionType = loadedTypes[0]; // Set first loaded ConnectionType as current
		}

		#region formevents
		// Initial loading
		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs();
			FillConnectionsList();
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		// Form Closing
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) { ClearConnectionTypes(); }

		// Connect to server using ConnectionType inplementation
		private void btnConnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Connect(); }

		// Disconnect from server using ConnectionType implementation
		private void btnDisconnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Disconnect(); }

		// Update hostname/port for current Connection
		private void btnUpdate_Click(object sender, EventArgs e) {
			int tmp = 0;
			if (!int.TryParse(tbPortNum.Text, out tmp)) {
				MessageBox.Show("Port number is invalid");
				tbHostName.Text = currentConnectionType.CurrentConnection.HostName;
				tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
				return;
			}

			currentConnectionType.CurrentConnection.HostName = tbHostName.Text;
			currentConnectionType.CurrentConnection.Port = tmp;
		}

		// Setup UI for newly selected Connection
		private void cbConnections_SelectedIndexChanged(object sender, EventArgs e) {
			if (cbConnections.SelectedIndex < 0 || currentConnectionType.NumConnections <= 0)
				currentConnectionType.SetNoConnection();
			else currentConnectionType.SetCurrentConnectionByName(cbConnections.Text);
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);

			tbHostName.Text = currentConnectionType.CurrentConnection.HostName;
			tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
			tbLog.Text = currentConnectionType.CurrentConnection.Log;
		}

		// Show NewConnection dialog
		private void btnNewConnection_Click(object sender, EventArgs e) {
			DialogResult dr = DialogResult.Cancel;
			NewConnection dialog = new NewConnection(currentConnectionType);
			dr = dialog.ShowDialog();
			if (dr != DialogResult.OK) return;

			FillConnectionsList();
			cbConnections.SelectedIndex = currentConnectionType.CurrentConnectionNdx;
			currentConnectionType.CurrentConnection.ConnectionEvent += OnConnectionEvent;
		}

		// Remove selected connection for ConnectionType
		private void btnRemoveConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			FillConnectionsList();
			cbConnections.SelectedIndex = 0;
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		// Setup UI for newly selected ConnectionType
		private void tsConnectionLibs_SelectedIndexChanged(object sender, EventArgs e) {
			if (tsConnectionLibs.SelectedIndex >= 0) {
				currentConnectionType = loadedTypes[tsConnectionLibs.SelectedIndex];
				FillConnectionsList();
				SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
			} else currentConnectionType = loadedTypes[0];
		}

		// Send message to server using ConnectionType implementation
		private void btnSend_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Send(); }

		// Show ConnectionLibs dialog
		private void btnConnectionLibs_Click(object sender, EventArgs e) {
			DialogResult dr = DialogResult.Cancel;
			ConnectionLibs dialog = new ConnectionLibs();
			dr = dialog.ShowDialog();
			if (dr != DialogResult.Yes) return;

			// Reload UI
			LoadConnectionLibs();
			FillConnectionsList();
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		private void btnClearLog_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.ClearLog(); }
		#endregion


	}
}
