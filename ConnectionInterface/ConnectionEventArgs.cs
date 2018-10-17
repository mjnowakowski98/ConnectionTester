using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface {
	public enum EventType {
		Connected,
		Disconnected,
		DataSent,
		DataRecieved
	}

	public class ConnectionEventArgs : EventArgs {
		private EventType eventEnum;
		public ConnectionEventArgs(EventType e) { eventEnum = e; }

		public EventType EventEnum {
			get { return eventEnum; }
		}
	}
}
