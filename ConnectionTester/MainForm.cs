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

		public MainForm() {
			InitializeComponent();
			connectionTypes = new List<ConnectionType>();
		}

		private void LoadConnectionLibs() {
			tsConnectionType.TabPages.Clear(); // Clear loaded UI

			// Iterate through each line in ConnectionLibs.settings
			foreach (SettingsProperty connection in Properties.ConnectionLibs.Default.Properties) {
				// Load the setting specified dll
				Assembly connectionDLL = null;
				try { connectionDLL = Assembly.LoadFrom(Properties.Settings.Default.ConnectionLibrariesDir + connection.DefaultValue); }
				catch (FileNotFoundException err) { // Tell user the library is invalid
					MessageBox.Show(err.Message, "Error: " + connection.DefaultValue + " not found");
					continue; // Skip this setting
				}

				tsConnectionType.TabPages.Add(connection.Name, connection.Name); // Add new tab using setting name as key/title
				TabPage connectionTab = tsConnectionType.TabPages[connection.Name]; // Get reference to the new page
				connectionTab.AutoScroll = true; // Allow page to scroll

				foreach (Type type in connectionDLL.GetExportedTypes()) { // Iterate through public types in dll (should have UserControl and Connection)
					if (typeof(Connection).IsAssignableFrom(type)) connectionTypes.Add(new ConnectionType(type)); // Register Connection derived class
					else if (typeof(UserControl).IsAssignableFrom(type)) { // Fill tabpage with UserControl
						UserControl control = (UserControl)Activator.CreateInstance(type); // Make new instance
						control.Dock = DockStyle.Fill; // Fill page with control (up to control to implement proper scaling)
						connectionTab.Controls.Add(control); // Add control to page
					}
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs();
		}

		private void btnSendMessage_Click(object sender, EventArgs e) {
			
		}

		private void btnConnectionLibs_Click(object sender, EventArgs e) {
			DialogResult dr = new DialogResult();
			ConnectionLibs dialog = new ConnectionLibs();
			dr = dialog.ShowDialog();
			if (dr == DialogResult.Yes) LoadConnectionLibs();
		}
	}
}
