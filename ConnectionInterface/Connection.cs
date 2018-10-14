using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface {
	// Base class for all connection types
	public abstract class Connection {
		#region internalvars
		protected String connectionName; // User name of connection

		// What is being connected to
		protected String hostName;
		protected int port;

		protected String log; // Output
		#endregion

		#region constructors
		// Name only, hostname/port specified later
		public Connection(String name) {
			connectionName = name;
			hostName = "";
			port = 0;
			log = "";
		}

		// One-shot name, hostname and port
		public Connection(String name, String hostName, int port) {
			connectionName = name;
			this.hostName = hostName;
			this.port = port;
			log = "";
		}
		#endregion

		#region properties
		// Readonly
		// User name of connection
		public String ConnectionName {
			get { return connectionName; }
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
