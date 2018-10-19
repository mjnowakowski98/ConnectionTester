using System;
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

			handler(this, e);
		}
		#endregion

		#region internalvars
		private bool isConnected;

		protected String connectionName; // User name of connection

		// What is being connected to
		protected String hostName;
		protected int port;

		protected String log; // Output
		#endregion

		public Connection(String name, String hostName, int port) {
			isConnected = false;
			connectionName = name;
			this.hostName = hostName;
			this.port = port;
			log = "";
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

		// Port number of connectee service
		public int Port {
			get { return port; }
			set { port = value; }
		}

		public String Log {
			get { return log; }
		}
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
