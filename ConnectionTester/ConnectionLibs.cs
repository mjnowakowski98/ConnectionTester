using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionTester {
	public partial class ConnectionLibs : Form {
		public ConnectionLibs() {
			InitializeComponent();
		}

		private void AddLibrary(String libName) {
			bool exists = false;
			int ndx = lbLibNames.Items.Count;
			while (--ndx >= 0) // Check if library name exists
				if (lbLibNames.Items[ndx].ToString() == libName) exists = true;

			// Add library name if unique
			if (!exists) lbLibNames.Items.Add(libName);
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			fbdLibPath.ShowDialog();
			tbLibDir.Text = fbdLibPath.SelectedPath;
		}

		private void ConnectionLibs_FormClosing(object sender, FormClosingEventArgs e) {
			if (cbReload.Checked) DialogResult = DialogResult.Yes;
			else DialogResult = DialogResult.No;
			Properties.Settings.Default.Save();
		}

		private void tbLibDir_TextChanged(object sender, EventArgs e) {
			Properties.Settings.Default.ConnectionLibrariesDir = tbLibDir.Text;
		}
	}
}
