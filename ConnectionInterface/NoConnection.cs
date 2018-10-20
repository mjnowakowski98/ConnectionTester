using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface {
	public class NoConnection : Connection {
		public NoConnection() : base("No Connection", "No host", 0) {}
		public NoConnection(String name, String hostName, int port) : base(name, hostName, port) {}

		public override void Connect() {
			log += "Connected to nothing o_o\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Connected));
		}

		public override void Disconnect() {
			log += "Back from the void\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Disconnected));
		}

		public override void Send() {
			log += "Ghost packets 8)\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataSent));
		}
		public override void GetResponses() {
			log += "Alert from nowhere!\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataRecieved));
		}
	}
}
