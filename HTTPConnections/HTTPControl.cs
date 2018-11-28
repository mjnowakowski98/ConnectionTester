using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPConnections {
    internal partial class HTTPControl : UserControl {
        private static HTTPControl uniqueInstance = null;

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
            ClientHeaders dialog = new ClientHeaders();
            dialog.ShowDialog();
        }
        #endregion
    }
}
