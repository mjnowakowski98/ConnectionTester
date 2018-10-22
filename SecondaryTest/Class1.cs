using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionInterface;

namespace SecondaryTest {
	public class TestConnection : Connection {
		private TestControl testControl;
		public TestConnection(String name, String hostName, int port) : base(name, hostName, port) {
			testControl = new TestControl();
			SetUIControl(testControl);
		}

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
