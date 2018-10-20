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

        public MainForm() {
            InitializeComponent();
			loadedTypes = new List<ConnectionType>();
			loadedTypes.Add(new ConnectionType(typeof(NoConnection), "No Type", new UserControl()));
			currentConnectionType = loadedTypes[0];
        }

		private void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			tbLog.Text = currentConnectionType.CurrentConnection.Log;
		}

		private void SetConnectedUI(bool connected) {
			btnConnect.Enabled = !connected;
			btnDisconnect.Enabled = connected;
			btnUpdate.Enabled = !connected;
			btnSend.Enabled = connected;
			tbHostName.Enabled = !connected;
			tbPortNum.Enabled = !connected;
		}

		private void SetTabPageControl(TabPage page, ConnectionType connectionType) {
			UserControl tmp = connectionType.UIControl;
			tmp.Dock = DockStyle.Fill;
			page.Controls.Add(tmp);
		}

		private void SetupConnectionSwitcher() {
			tsConnectionLibs.SelectedIndex = -1;
			tsConnectionLibs.TabPages.Clear();
			foreach (ConnectionType connectionType in loadedTypes) {
				TabPage page = new TabPage(connectionType.TypeKey);
				SetTabPageControl(page, connectionType);
				tsConnectionLibs.TabPages.Add(page);
			}
		}

		private void FillConnectionsList() {
			cbConnections.Items.Clear();
			cbConnections.Items.AddRange(currentConnectionType.ConnectionNames.ToArray());
			cbConnections.SelectedIndex = currentConnectionType.CurrentConnectionNdx;
		}

        private void LoadConnectionLibs() {
			loadedTypes.Clear();
            foreach (SettingsProperty libSetting in Properties.ConnectionLibs.Default.Properties) {
                Assembly connectionDLL = null;
                try { connectionDLL = Assembly.LoadFrom(Properties.Settings.Default.ConnectionLibrariesDir + libSetting.DefaultValue); }
                catch (FileNotFoundException err) {
					MessageBox.Show(err.Message, libSetting.DefaultValue + " not found");
					continue;
                }

				foreach (Type type in connectionDLL.GetExportedTypes()) {
					if (!typeof(Connection).IsAssignableFrom(type)) continue;
					Connection tmp = (Connection)Activator.CreateInstance(type, new object[] { null, null, 0 });
					ConnectionType tmpType = new ConnectionType(type, libSetting.Name, tmp.GetUIControl());
					loadedTypes.Add(tmpType);
				}

			}

			if (loadedTypes.Count <= 0) loadedTypes.Add(new ConnectionType(typeof(NoConnection), "NoType", new UserControl()));
			tsConnectionLibs.SelectedIndex = 0;
			SetupConnectionSwitcher();
        }

		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs();
			FillConnectionsList();
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		private void btnConnectionLibs_Click(object sender, EventArgs e) {
			DialogResult dr = DialogResult.Cancel;
			ConnectionLibs dialog = new ConnectionLibs();
			dr = dialog.ShowDialog();
			if (dr != DialogResult.Yes) return;

			LoadConnectionLibs();
			FillConnectionsList();
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		private void btnRemoveConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			FillConnectionsList();
			cbConnections.SelectedIndex = 0;
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);
		}

		private void btnNewConnection_Click(object sender, EventArgs e) {
			DialogResult dr = DialogResult.Cancel;
			NewConnection dialog = new NewConnection(currentConnectionType);
			dr = dialog.ShowDialog();
			if (dr != DialogResult.OK) return;

			FillConnectionsList();
			cbConnections.SelectedIndex = currentConnectionType.CurrentConnectionNdx;
			currentConnectionType.CurrentConnection.ConnectionEvent += OnConnectionEvent;
		}

		private void tsConnectionLibs_SelectedIndexChanged(object sender, EventArgs e) {
			if (tsConnectionLibs.SelectedIndex >= 0) currentConnectionType = loadedTypes[tsConnectionLibs.SelectedIndex];
			else currentConnectionType = loadedTypes[0];
		}

		private void cbConnections_SelectedIndexChanged(object sender, EventArgs e) {
			if (cbConnections.SelectedIndex < 0 || currentConnectionType.NumConnections <= 0)
				currentConnectionType.SetNoConnection();
			else currentConnectionType.SetCurrentConnectionByName(cbConnections.Text);
			SetConnectedUI(currentConnectionType.CurrentConnection.IsConnected);

			tbHostName.Text = currentConnectionType.CurrentConnection.HostName;
			tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
			tbLog.Text = currentConnectionType.CurrentConnection.Log;
		}

		private void btnSend_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Send(); }

		private void btnConnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Connect(); }

		private void btnDisconnect_Click(object sender, EventArgs e) { currentConnectionType.CurrentConnection.Disconnect(); }
	}
}
