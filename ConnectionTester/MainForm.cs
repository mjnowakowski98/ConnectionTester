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
			loadedTypes.Add(new ConnectionType(typeof(NoConnection), "No Type", new UserControl()));
			currentConnectionType = loadedTypes[0];
        }

		// Update UI for current connection on event from any connection
		// (connection information is stored in the connection class)
		private void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
			tbLog.Text = currentConnectionType.CurrentConnection.Log;
		}

		// Set connection button states
		private void SetConnectedUI(bool connected) {
			btnConnect.Enabled = !connected;
			btnDisconnect.Enabled = connected;
			btnUpdate.Enabled = !connected;
			btnSend.Enabled = connected;
			tbHostName.Enabled = !connected;
			tbPortNum.Enabled = !connected;
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

		// Load ConnectionType libraries based on application settings
        private void LoadConnectionLibs() {
			loadedTypes.Clear(); // Clear loaded ConnectionTypes
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
			if (loadedTypes.Count <= 0) loadedTypes.Add(new ConnectionType(typeof(NoConnection), "NoType", new UserControl()));

			SetupConnectionSwitcher(); // Setup tab switcher with loaded types
			tsConnectionLibs.SelectedIndex = 0; // Select first tab page
		}

		// Initial loading
		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs();
			FillConnectionsList();
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

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

		// Remove selected connection for ConnectionType
		private void btnRemoveConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			FillConnectionsList();
			cbConnections.SelectedIndex = 0;
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
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

		// Setup UI for newly selected ConnectionType
		private void tsConnectionLibs_SelectedIndexChanged(object sender, EventArgs e) {
			if (tsConnectionLibs.SelectedIndex >= 0) {
				currentConnectionType = loadedTypes[tsConnectionLibs.SelectedIndex];
				FillConnectionsList();
				SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
			} else currentConnectionType = loadedTypes[0];
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

		// Send message to server using ConnectionType implementation
		private void btnSend_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Send(); }

		// Connect to server using ConnectionType inplementation
		private void btnConnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Connect(); }

		// Disconnect from server using ConnectionType implementation
		private void btnDisconnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Disconnect(); }

		// Update hostname/port for current Connection
		private void btnUpdate_Click(object sender, EventArgs e) {
			int tmp = 0;
			if(!int.TryParse(tbPortNum.Text, out tmp)) {
				MessageBox.Show("Port number is invalid");
				tbHostName.Text = currentConnectionType.CurrentConnection.HostName;
				tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
				return;
			}

			currentConnectionType.CurrentConnection.HostName = tbHostName.Text;
			currentConnectionType.CurrentConnection.Port = tmp;
		}
	}
}
