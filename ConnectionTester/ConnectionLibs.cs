using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionTester {
	public partial class ConnectionLibs : Form {
		private struct Library {
			public String libName;
			public String libAssembly;

			public Library(String name, String assembly) {
				libName = name;
				libAssembly = assembly;
			}
		}

		private List<Library> libraries;

		public ConnectionLibs() {
			InitializeComponent();
			libraries = new List<Library>();
		}

		#region librarymodifiers
		// Add library to collection
		private void AddLibrary(String libName, String libAssembly) {
			bool exists = false;
			int ndx = lbLibNames.Items.Count;
			while (--ndx >= 0) { // Check if library name/assembly exists
				if (libraries[ndx].libName == libName || libraries[ndx].libAssembly == libAssembly)
					exists = true;
			}

			// Add library name if unique
			if (!exists) {
				libraries.Add(new Library(libName, libAssembly));
				lbLibNames.Items.Add(libName + ":" + libAssembly);
			}
		}

		// Remove library from collection
		private void RemoveLibrary(int libNdx) {
			if (libNdx < 0 || libNdx >= libraries.Count) return;
			libraries.RemoveAt(libNdx);
			lbLibNames.Items.RemoveAt(libNdx);
		}
		#endregion

		#region formevents
		// Initialize UI
		private void ConnectionLibs_Load(object sender, EventArgs e) {
			fbdLibPath.SelectedPath = Properties.Settings.Default.ConnectionLibrariesDir;
			tbLibDir.Text = Properties.Settings.Default.ConnectionLibrariesDir;
			foreach (SettingsProperty connection in Properties.ConnectionLibs.Default.Properties) {
				lbLibNames.Items.Add(connection.Name + ":" + connection.DefaultValue.ToString());
				libraries.Add(new Library(connection.Name, connection.DefaultValue.ToString()));
			}
		}

		// Show directory selection dialog
		private void btnBrowse_Click(object sender, EventArgs e) {
			fbdLibPath.ShowDialog();
			tbLibDir.Text = fbdLibPath.SelectedPath;
		}

		// Form closing
		private void ConnectionLibs_FormClosing(object sender, FormClosingEventArgs e) {
			// Append trainling '\' if missing
			String dirString = Properties.Settings.Default.ConnectionLibrariesDir;
			if (dirString.LastIndexOf('\\') != dirString.Length - 1)
				Properties.Settings.Default.ConnectionLibrariesDir = dirString + "\\";

			// Set reload flag through DialogResult
			if (cbReload.Checked) DialogResult = DialogResult.Yes;
			else DialogResult = DialogResult.No;
			Properties.Settings.Default.Save(); // Save library directory file

			// Save library settings
			Properties.ConnectionLibs.Default.Properties.Clear(); // Clear existing settings
			foreach(Library lib in libraries) { // Iterate through libraries
				// Create SettingsProperty instance
				SettingsProperty tmp = new SettingsProperty(lib.libName); // Setting name
				tmp.PropertyType = typeof(String); // Setting type
				tmp.Provider = Properties.ConnectionLibs.Default.Providers["LocalFileSettingsProvider"];
				tmp.IsReadOnly = false; // Read/Write
				tmp.DefaultValue = lib.libAssembly; // Setting value
				tmp.SerializeAs = SettingsSerializeAs.String;
				tmp.Attributes.Add(typeof(System.Configuration.UserScopedSettingAttribute), new System.Configuration.UserScopedSettingAttribute());
				tmp.ThrowOnErrorDeserializing = true;
				tmp.ThrowOnErrorSerializing = true;
				Properties.ConnectionLibs.Default.Properties.Add(tmp); // Add to Properties collection
				Properties.ConnectionLibs.Default.Save(); // Save settings file
			}
		}

		// Set library directory property on textbox change
		private void tbLibDir_TextChanged(object sender, EventArgs e) { Properties.Settings.Default.ConnectionLibrariesDir = tbLibDir.Text; }

		// Add library to collection
		private void btnAddLib_Click(object sender, EventArgs e) {
			if (tbAddLibName.Text.Length > 0 && tbAddLibAssembly.Text.Length > 0)
				AddLibrary(tbAddLibName.Text, tbAddLibAssembly.Text);
			else MessageBox.Show("Library must have both a name and assembly", "Error");
		}
		private void btnRemoveLib_Click(object sender, EventArgs e) { RemoveLibrary(lbLibNames.SelectedIndex); }
		#endregion
	}
}
