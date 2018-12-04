using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionInterface {
    public class UIControl : UserControl {
        private Connection currentConnection;

        public Connection CurrentConnection {
            get { return currentConnection; }
            set { currentConnection = value; }
        }

        public virtual void SetConnectedUI(bool connected) {

        }
    }
}
