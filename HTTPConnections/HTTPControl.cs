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

        private void HTTPControl_Load(object sender, EventArgs e) {
            cbConnectionMethod.SelectedIndex = 0;
        }

        public static HTTPControl GetInstance() {
            if (uniqueInstance == null) uniqueInstance = new HTTPControl();
            return uniqueInstance;
        }
    }
}
