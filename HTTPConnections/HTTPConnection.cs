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
        private HttpClientHeaders clientHeaders;
        private HttpResponseMessage response; // Last response from server

        private HTTPControl httpControl; // UI control for ConnectionType

        public HTTPConnection(String name, String hostName, int port) : base (name, hostName, port) {
            clientHeaders = new HttpClientHeaders();
            response = null;

            httpControl = HTTPControl.GetInstance();
            SetUIControl(httpControl);
        }

        internal HttpClientHeaders ClientHeaders {
            get { return clientHeaders; }
        }

        public override void Connect() {
            // No persistant connections, connecting creates a new client
            // Allows updating DefaultRequestHeaders without a race condition
			client = new HttpClient();
            foreach(String header in clientHeaders.Accept.Split(','))
                if (header.Length > 0) client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));

            foreach (String header in clientHeaders.AcceptLanguage.Split(','))
                if(header.Length > 0)client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue(header));

            if(clientHeaders.Authorization.Length > 0)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(clientHeaders.AuthorizationType, clientHeaders.Authorization);
            if(clientHeaders.ProxyAuthorization.Length > 0)
                client.DefaultRequestHeaders.ProxyAuthorization = new AuthenticationHeaderValue(clientHeaders.ProxyAuthorizationType, clientHeaders.ProxyAuthorizationType);

            client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue();
            if (clientHeaders.MaxAge > TimeSpan.Zero)
                client.DefaultRequestHeaders.CacheControl.MaxAge = clientHeaders.MaxAge;
            if(clientHeaders.MaxStaleLimit > TimeSpan.Zero)
                client.DefaultRequestHeaders.CacheControl.MaxStaleLimit = clientHeaders.MaxStaleLimit;
            if(clientHeaders.MinFresh > TimeSpan.Zero)
                client.DefaultRequestHeaders.CacheControl.MinFresh = clientHeaders.MinFresh;

            client.DefaultRequestHeaders.CacheControl.NoCache = clientHeaders.NoCache;
            client.DefaultRequestHeaders.CacheControl.NoStore = clientHeaders.NoStore;
            client.DefaultRequestHeaders.CacheControl.NoTransform = clientHeaders.NoTransform;
            client.DefaultRequestHeaders.CacheControl.OnlyIfCached = clientHeaders.OnlyIfCached;
            client.DefaultRequestHeaders.ExpectContinue = clientHeaders.ExpectContinue;

            if(clientHeaders.From.Length > 0) client.DefaultRequestHeaders.From = clientHeaders.From;
            /*foreach (String header in clientHeaders.IfMatch)
                client.DefaultRequestHeaders.IfMatch.Add(new EntityTagHeaderValue(header));

            // Kill me
            /*foreach(String header in clientHeaders.IfModifiedSince)
                client.DefaultRequestHeaders.IfModifiedSince

            foreach (String header in clientHeaders.IfNoneMatch)
                client.DefaultRequestHeaders.IfNoneMatch.Add(new EntityTagHeaderValue(header));

            client.DefaultRequestHeaders.IfRange = new RangeConditionHeaderValue(new EntityTagHeaderValue(clientHeaders.IfRange));
            // IfUnmodifiedSince goes here

            // Why is this so painful to figure out what the hell these values expect
            //client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue())

            // Warning goes here

            */

			log += "Connected\n";
			OnConnectionEvent(this, new ConnectionEventArgs(EventType.Connected));
        }

        public override async void Send() {
            String connectionMethod = httpControl.cbConnectionMethod.Text; // Get HTTP request method
			try {
				switch (connectionMethod) {
					case "GET": // ---Needs overhaul---
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, hostName + ':' + port);
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
