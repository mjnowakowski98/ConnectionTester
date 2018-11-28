using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using ConnectionInterface;

namespace HTTPConnections {
    internal partial class HTTPControl : UIControl {
        private static HTTPControl uniqueInstance = null;

        private HttpClientHeaders clientHeaders = new HttpClientHeaders();

        public override bool CurrentConnectionIsConnected {
            get { return base.CurrentConnectionIsConnected; }
            set {
                base.CurrentConnectionIsConnected = value;
                btnClientHeaders.Enabled = !value;
                tbRequestData.Enabled = value;
            }
        }

        private HTTPControl() {
            InitializeComponent();
        }

        public HttpClientHeaders ClientHeaders {
            get { return clientHeaders; }
        }

        #region formevents
        private void HTTPControl_Load(object sender, EventArgs e) {
            cbConnectionMethod.SelectedIndex = 0;
        }

        public static HTTPControl GetInstance() {
            if (uniqueInstance == null) uniqueInstance = new HTTPControl();
            return uniqueInstance;
        }

        private void btnClientHeaders_Click(object sender, EventArgs e) {
            ClientHeaders dialog = new ClientHeaders(clientHeaders);
            dialog.ShowDialog();
        }
        #endregion

        private void btnRequestHeaders_Click(object sender, EventArgs e) {
            RequestHeaders dialog = new RequestHeaders(this);
        }
    }
}
