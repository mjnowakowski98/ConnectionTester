using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface {
	public abstract class Connection {
		protected String connectionName;

		protected String hostName;
		protected int port;

		protected String log;

		#region constructors
		public Connection(String name) {
			connectionName = name;
			hostName = "";
			port = 0;
			log = "";
		}

		public Connection(String name, String hostName, int port) {
			connectionName = name;
			this.hostName = hostName;
			this.port = port;
			log = "";
		}
		#endregion

		#region properties
		public String ConnectionName {
			get { return connectionName; }
		}

		public String HostName {
			get { return hostName; }
			set { hostName = value; }
		}

		public int Port {
			get { return port; }
			set { port = value; }
		}
		#endregion

		#region connectionmethods
		public abstract void Connect();
		public abstract void Disconnect();
		public abstract void Send();
		#endregion
	}
}
