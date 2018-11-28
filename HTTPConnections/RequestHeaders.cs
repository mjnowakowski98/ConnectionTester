using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPConnections {
    internal partial class RequestHeaders : Form {
        private HTTPControl parentControl;

        public RequestHeaders(HTTPControl _parentControl) {
            InitializeComponent();
            parentControl = _parentControl;
        }
    }
}
