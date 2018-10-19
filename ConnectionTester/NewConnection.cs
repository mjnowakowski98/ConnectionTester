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
	public partial class NewConnection : Form {
		private ConnectionType currentType;
		public NewConnection(ConnectionType type) {
			InitializeComponent();
			currentType = type;
		}

		private void btnOk_Click(object sender, EventArgs e) {
			bool canAdd = true;
			if (tbConnectionName.Text == "" || tbHostName.Text == "")
				canAdd = false;

			int portNum = 0;
			if (!int.TryParse(tbPort.Text, out portNum)) canAdd = false;

			if (canAdd) {
				if (currentType.AddConnection(tbConnectionName.Text, tbHostName.Text, portNum)) {
					DialogResult = DialogResult.OK;
					Close();
				} else MessageBox.Show("Name must be unique for connection method", "Error");
			} else MessageBox.Show("Some fields are invalid", "Error");
		}
	}
}
