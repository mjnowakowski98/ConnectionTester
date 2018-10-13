using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTester {
	class TCPConnection {
		#region internalvars
		private String connectionName;

		private TcpClient client;
		private NetworkStream stream;

		private String hostName;
		private int port;

		private String log;
		#endregion

		#region constructors
		public TCPConnection(String name) {
			connectionName = name;
			client = null;
			stream = null;
			hostName = "";
			port = 0;
			log = "";
		}

		public TCPConnection(String name, String hostName, int port) {
			connectionName = name;
			client = null;
			stream = null;
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

		private void SocketPanic(SocketException err) {
			log += "Socket Error: " + err.SocketErrorCode + "\n";
			log += err.Message + "\n";
			Disconnect();
		}

		#region connectionmethods
		public async void Connect() {
			try {
				if (client == null) client = new TcpClient();
				else {
					log += "Already connected\n";
					return;
				}

				await client.ConnectAsync(hostName, port);
				stream = client.GetStream();
				log += "Connected\n";
			} catch(SocketException err) { SocketPanic(err); }
		}

		public void Disconnect() {
			if (client != null) client.Close();
			client = null;
			log += "Disconnected\n";
		}

		public async void SendString(String toSend) {
			try {
				Byte[] data = Encoding.ASCII.GetBytes(toSend);
				await stream.WriteAsync(data, 0, data.Length);
				//GetResponses();
			} catch(SocketException err) { SocketPanic(err); }
			catch (System.IO.IOException) {
				// Usually thrown on timeout, should find a
				// way to update Connected property
				// without throwing

				Disconnect();
			}
		}

		private async void GetResponses() {
			if(stream.CanRead) {
				try {
					Byte[] data = new byte[256];
					int numBytes = await stream.ReadAsync(data, 0, data.Length);
					log += Encoding.ASCII.GetString(data, 0, numBytes);
				} catch(SocketException err) { SocketPanic(err); }
			}
		}
		#endregion
	}
}
