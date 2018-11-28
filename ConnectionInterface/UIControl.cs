using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionInterface {
    public class UIControl : UserControl {
        protected bool currentConnectionIsConnected;

        public virtual bool CurrentConnectionIsConnected {
            get { return currentConnectionIsConnected; }
            set {
                currentConnectionIsConnected = value;
            }
        }
    }
}
