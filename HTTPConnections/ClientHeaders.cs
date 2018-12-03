using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace HTTPConnections {
	internal partial class ClientHeaders : Form {
        private HttpClientHeaders clientHeaders;

		public ClientHeaders(HttpClientHeaders _clientHeaders) {
			InitializeComponent();
            clientHeaders = _clientHeaders;
		}

        // Set client headers to UI control
        private void ClientHeaders_FormClosing(object sender, FormClosingEventArgs e) {
            char delim = ',';
            clientHeaders.Accept.AddRange(tbAccept.Text.Split(delim));
            clientHeaders.AcceptLanguage.AddRange(tbAcceptLanguage.Text.Split(delim));
            clientHeaders.AuthorizationType = cbAuthType.Text;
            clientHeaders.Authorization = tbAuthCredentials.Text;
            clientHeaders.ProxyAuthorizationType = cbProxyAuthType.Text;
            clientHeaders.ProxyAuthorization = tbProxyAuthCredentials.Text;
            clientHeaders.MaxAge = new TimeSpan(long.Parse(nudMaxAge.Value.ToString()));
            clientHeaders.MaxStaleLimit = new TimeSpan(long.Parse(nudMaxStale.Value.ToString()));
            clientHeaders.MinFresh = new TimeSpan(long.Parse(nudMinFresh.Value.ToString()));
            clientHeaders.NoCache = cbNoCache.Checked;
            clientHeaders.NoStore = cbNoStore.Checked;
            clientHeaders.NoTransform = cbNoTransform.Checked;
            clientHeaders.OnlyIfCached = cbOnlyIfCached.Checked;
            clientHeaders.IfMatch.AddRange(tbIfMatch.Text.Split(delim));
            clientHeaders.IfModifiedSince.AddRange(tbIfModifiedSince.Text.Split(delim));
            clientHeaders.IfNoneMatch.AddRange(tbIfNonMatch.Text.Split(delim));
            clientHeaders.IfRange = tbIfRange.Text;
            clientHeaders.IfUnmodifiedSince.AddRange(tbIfUnmodifiedSince.Text.Split(delim));
            clientHeaders.From = tbFrom.Text;
            clientHeaders.ExpectContinue = cbExpectContinue.Checked;
            clientHeaders.Range = tbRange.Text;
            clientHeaders.UserAgent = tbUserAgent.Text;
            clientHeaders.Warning = tbWarning.Text;

        }

		private void ClientHeaders_Load(object sender, EventArgs e) {

		}
	}
}
