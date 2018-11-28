using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface {
	// Base class for all connection types
	public abstract class Connection {
		#region eventdeclarations
		public delegate void ConnectionEventHandler(object sender, ConnectionEventArgs e);
		public event ConnectionEventHandler ConnectionEvent;
		#endregion

		#region eventmethods
		protected virtual void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			ConnectionEventHandler handler = ConnectionEvent;
			if (e.EventEnum == EventType.Connected) isConnected = true;
			else if (e.EventEnum == EventType.Disconnected) isConnected = false;

			handler?.Invoke(this, e);
		}
		#endregion

		#region internalvars
		private bool isConnected;

		protected String connectionName; // User set name of connection

		// What is being connected to
		protected String hostName;
		protected int port;

		protected String log; // Output
		private UIControl uiControl;
		#endregion

		public Connection(String name, String hostName, int port) {
			isConnected = false;
			connectionName = name;
			this.hostName = hostName;
			this.port = port;
			log = "";
			uiControl = null;
		}

		#region properties
		// Readonly
		// User name of connection
		public String ConnectionName {
			get { return connectionName; }
		}

		public bool IsConnected {
			get { return isConnected; }
		}

		// Read/write
		// URI of host
		public String HostName {
			get { return hostName; }
			set { hostName = value; }
		}

		// Port number of sever service
		public int Port {
			get { return port; }
			set { port = value; }
		}

		// Connection log
		public String Log {
			get { return log; }
		}

		// Clear connection log
		public void ClearLog() {
			log = "";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Internal));
		}

		public UIControl GetUIControl() { return uiControl; }
		protected void SetUIControl(UIControl control) { uiControl = control; }
		#endregion

		// Type specific implementations
		#region connectionmethods
		public abstract void Connect();
		public abstract void Disconnect();
		public abstract void Send();
		public abstract void GetResponses();
		#endregion
	}
}
