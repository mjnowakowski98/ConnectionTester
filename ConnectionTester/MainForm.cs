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
	public partial class MainForm : Form {
		List<TCPConnection> tcpConnections;

		public MainForm() {
			InitializeComponent();
			tcpConnections = new List<TCPConnection>();
		}

		private void btnAddConnection_Click(object sender, EventArgs e) {
			TCPConnection tmp = new TCPConnection(cbConnections.Text);
			cbConnections.Items.Add(tmp.ConnectionName);
		}
	}
}
