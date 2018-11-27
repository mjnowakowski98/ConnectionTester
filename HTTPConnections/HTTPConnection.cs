﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ConnectionInterface;

namespace HTTPConnections {
    public class HTTPConnection : Connection {
        private HttpClient client;
        private HttpResponseMessage response;

        private HTTPControl httpControl;

        public HTTPConnection(String name, String hostName, int port) : base (name, hostName, port) {
            response = null;

            httpControl = HTTPControl.GetInstance();
            SetUIControl(httpControl);
        }

        public override void Connect() {
			client = new HttpClient();
			log += "Connected\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Connected));
        }

        public override async void Send() {
            String connectionMethod = httpControl.cbConnectionMethod.Text;
			try {
				switch (connectionMethod) {
					case "GET":
						response = await client.GetAsync(hostName + ':' + port + '?' + httpControl.tbRequestData.Text);
						break;
					case "POST":
						Dictionary<String, String> values = new Dictionary<String, String>();
						String dataString = httpControl.tbRequestData.Text;

						int pairNdx = 0;
						while (pairNdx != -1) {
							int keyNdx = dataString.IndexOf('=');

						}


						//FormUrlEncodedContent content = new FormUrlEncodedContent(values);
						//response = await client.PostAsync(hostName, content);
						break;
					default:
						return;
				}
			} catch (Exception err) {
				log += err.Message + "\n";
				OnConnectionEvent(this, new ConnectionEventArgs(EventType.Error));
				return;
			}
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataSent));
            GetResponses();
        }

        public override async void GetResponses() {
            String responseString = await response.Content.ReadAsStringAsync();
			log += responseString + "\n";
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.DataRecieved));
        }

        public override void Disconnect() {
			client = null;
			log += "Disconnected";
            OnConnectionEvent(this, new ConnectionEventArgs(EventType.Disconnected));
        }
    }
}