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

namespace ConnectionTester {
	public partial class MainForm : Form {
		private List<ConnectionType> connectionTypes;

		public MainForm() {
			InitializeComponent();
			connectionTypes = new List<ConnectionType>();
		}

		private void LoadConnectionLibs(String path) {
			foreach (SettingsProperty connection in Properties.ConnectionLibs.Default.Properties) {
				tsConnectionType.TabPages.Add(connection.Name, connection.Name);
				TabPage connectionTab = tsConnectionType.TabPages[connection.Name];
				connectionTab.AutoScroll = true;

				Assembly connectionDLL = Assembly.LoadFrom(path + connection.DefaultValue);
				foreach (Type type in connectionDLL.GetExportedTypes()) {
					if (typeof(Connection).IsAssignableFrom(type)) connectionTypes.Add(new ConnectionType(type));
					else if (typeof(UserControl).IsAssignableFrom(type)) {
						UserControl control = (UserControl)Activator.CreateInstance(type);
						control.Width = connectionTab.Width;
						control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
						connectionTab.Controls.Add(control);
					}
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs(".\\connectionlibs\\");
		}
	}
}
