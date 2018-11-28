using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ConnectionInterface;

namespace HTTPConnections {
    public class HTTPConnection : Connection {
        private HttpClient client; // HttpClient used for requests/responses
        private HttpResponseMessage response; // Last response from server

        private HTTPControl httpControl; // UI control for ConnectionType

        public HTTPConnection(String name, String hostName, int port) : base (name, hostName, port) {
            response = null;

            httpControl = HTTPControl.GetInstance();
            SetUIControl(httpControl);
        }

        public override void Connect() {
            // No persistant connections, connecting creates a new client
            // Allows updating DefaultRequestHeaders without a race condition
			client = new HttpClient();
			log += "Connected\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Connected));
        }

        public override async void Send() {
            String connectionMethod = httpControl.cbConnectionMethod.Text; // Get HTTP request method
			try {
				switch (connectionMethod) {
					case "GET": // ---Needs overhaul---
                        //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, hostName + ':' + port);
						response = await client.GetAsync(hostName + ':' + port + '?' + httpControl.tbRequestData.Text); // Send with quesrystring
                        log += "Request sent\n";
						break;
					default: // Do nothing if someone managed to add an invalid method
						return;
				}
			} catch (Exception err) { // Generally HttprequestException (network error) or UriFormatException (user entered malformed host)
				log += err.Message + "\n";
				OnConnectionEvent(this, new ConnectionEventArgs(EventType.Error));
				return;
			}
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataSent));
            GetResponses();
        }

        public override async void GetResponses() {
            String responseString = await response.Content.ReadAsStringAsync(); // Read response from server
			log += responseString + "\n";
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataRecieved));
        }

        public override void Disconnect() {
			client = null; // Allow client to be garbage collected
			log += "Disconnected\n";
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.Disconnected));
        }
    }
}
