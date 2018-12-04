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

        public override void SetConnectedUI(bool connected) {
            btnClientHeaders.Enabled = !connected;
            tbRequestData.Enabled = connected;
        }

        private HTTPControl() {
            InitializeComponent();
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
            HTTPConnection tmp = (HTTPConnection)CurrentConnection;
            ClientHeaders dialog = new ClientHeaders(tmp.ClientHeaders);
            dialog.ShowDialog();
        }
        #endregion

        private void btnRequestHeaders_Click(object sender, EventArgs e) {
            RequestHeaders dialog = new RequestHeaders(this);
            dialog.ShowDialog();
        }
    }
}
