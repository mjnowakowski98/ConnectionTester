using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace HTTPConnections {
	internal partial class ClientHeaders : Form {
        private HttpClientHeaders clientHeaders;

		public ClientHeaders(HttpClientHeaders _clientHeaders) {
			InitializeComponent();
            clientHeaders = _clientHeaders;
		}

        // Set client headers to UI control
        private void ClientHeaders_FormClosing(object sender, FormClosingEventArgs e) {
			
        }

		private void ClientHeaders_Load(object sender, EventArgs e) {

		}
	}
}
