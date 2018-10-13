using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionInterface;

namespace TCPConnections {
	public class TCPConnection : Connection {
		#region internalvars
		private TcpClient client;
		private NetworkStream stream;

		private String toSend;
		#endregion

		#region constructors
		public TCPConnection(String name) : base(name) {
			client = null;
			stream = null;
		}

		public TCPConnection(String name, String hostName, int port) : base(name, hostName, port) {
			client = null;
			stream = null;
		}
		#endregion

		private void SocketPanic(SocketException err) {
			log += "Socket Error: " + err.SocketErrorCode + "\n";
			log += err.Message + "\n";
			Disconnect();
		}

		#region properties
		public String ToSend {
			set { toSend = value; }
		}
		#endregion

		#region connectionmethods
		public override async void Connect() {
			try {
				if (client == null) client = new TcpClient();
				else {
					log += "Already connected\n";
					return;
				}

				await client.ConnectAsync(hostName, port);
				stream = client.GetStream();
				log += "Connected\n";
			} catch (SocketException err) { SocketPanic(err); }
		}

		public override void Disconnect() {
			if (client != null) client.Close();
			client = null;
			log += "Disconnected\n";
		}

		public override async void Send() {
			try {
				Byte[] data = Encoding.ASCII.GetBytes(toSend);
				await stream.WriteAsync(data, 0, data.Length);
				//GetResponses();
			} catch (SocketException err) { SocketPanic(err); } catch (System.IO.IOException) {
				// Usually thrown on timeout, should find a
				// way to update Connected property
				// without throwing

				Disconnect();
			}
		}

		private async void GetResponses() {
			if (stream.CanRead) {
				try {
					Byte[] data = new byte[256];
					int numBytes = await stream.ReadAsync(data, 0, data.Length);
					log += Encoding.ASCII.GetString(data, 0, numBytes);
				} catch (SocketException err) { SocketPanic(err); }
			}
		}
		#endregion
	}
}
