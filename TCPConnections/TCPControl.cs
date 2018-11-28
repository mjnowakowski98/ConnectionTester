using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionInterface;

namespace TCPConnections {
	internal partial class TCPControl : UIControl {
		private static TCPControl uniqueInstance = null;

		private TCPControl() {
			InitializeComponent();
		}

        public override bool CurrentConnectionIsConnected {
            get { return base.CurrentConnectionIsConnected; }
            set {
                base.CurrentConnectionIsConnected = value;
                tbSendString.Enabled = value;
            }
        }

        internal String SendString {
			get { return tbSendString.Text; }
			set { tbSendString.Text = value; }
		}

		public static TCPControl GetInstance() {
			if (uniqueInstance == null) uniqueInstance = new TCPControl();
			return uniqueInstance;
		}
	}
}
