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
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			foreach(SettingsProperty connection in Properties.ConnectionLibs.Default.Properties) {
				tsConnectionType.TabPages.Add(connection.Name, connection.Name);
				TabPage connectionTab = tsConnectionType.TabPages[connection.Name];
				connectionTab.AutoScroll = true;


				Assembly connectionDLL = Assembly.LoadFrom(".\\connectionlibs\\" + connection.DefaultValue);
				foreach(Type type in connectionDLL.GetExportedTypes()) {
					if (typeof(Connection).IsAssignableFrom(type)) continue;
					else if (typeof(UserControl).IsAssignableFrom(type)) {
						UserControl control = (UserControl)Activator.CreateInstance(type);
						control.Width = connectionTab.Width;
						control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
						connectionTab.Controls.Add(control);
					}
				}
			}
		}
	}
}
