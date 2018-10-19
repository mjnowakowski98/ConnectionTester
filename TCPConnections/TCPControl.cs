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
	internal partial class TCPControl : UserControl {
		private static TCPControl uniqueInstance = null;

		private TCPControl() {
			InitializeComponent();
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
