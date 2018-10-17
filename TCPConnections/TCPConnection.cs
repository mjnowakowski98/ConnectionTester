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
		private TcpClient client; // Client/socket wrapper
		private NetworkStream stream; // Message stream

		private String toSend; // Message to send
		#endregion

		public TCPConnection(String name, String hostName, int port) : base(name, hostName, port) {
			client = null;
			stream = null;
			toSend = "";
		}

		// On SocketException
		private void SocketPanic(SocketException err) {
			log += "Socket Error: " + err.SocketErrorCode + "\n";
			log += err.Message + "\n";
			Disconnect();
		}

		#region properties
		// Message to send
		public String ToSend {
			set { toSend = value; }
		}
		#endregion

		#region connectionmethods
		// Connect to the server
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
				OnConnectionEvent(this, new ConnectionEventArgs(EventType.Connected));
			} catch (SocketException err) { SocketPanic(err); }
		}

		// Disconnect from server
		public override void Disconnect() {
			if (client != null) client.Close();
			client = null;
			log += "Disconnected\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Disconnected));
		}

		// Send message to server
		public override async void Send() {
			try {
				Byte[] data = Encoding.ASCII.GetBytes(toSend);
				await stream.WriteAsync(data, 0, data.Length);
				log += "Data sent: " + toSend + "\n";
				OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataSent));
				GetResponses();
			} catch (SocketException err) { SocketPanic(err); } catch (System.IO.IOException) { Disconnect(); }
		}

		// Get server responses
		public override async void GetResponses() {
			if (stream.CanRead) {
				try {
					Byte[] data = new byte[256];
					int numBytes = await stream.ReadAsync(data, 0, data.Length);
					log += Encoding.ASCII.GetString(data, 0, numBytes) + "\n";

				} catch (SocketException err) { SocketPanic(err); }
			}
		}
		#endregion
	}
}
