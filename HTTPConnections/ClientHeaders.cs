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

        private String RemoveWhiteSpace(String input) {
            return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        // Set client headers to UI control
        private void ClientHeaders_FormClosing(object sender, FormClosingEventArgs e) {
            clientHeaders.Accept = RemoveWhiteSpace(tbAccept.Text);
            clientHeaders.AcceptLanguage = RemoveWhiteSpace(tbAcceptLanguage.Text);
            clientHeaders.AuthorizationType = cbAuthType.Text;
            clientHeaders.Authorization = RemoveWhiteSpace(tbAuthCredentials.Text);
            clientHeaders.ProxyAuthorizationType = cbProxyAuthType.Text;
            clientHeaders.ProxyAuthorization = RemoveWhiteSpace(tbProxyAuthCredentials.Text);
            clientHeaders.MaxAge = new TimeSpan(Convert.ToInt64(nudMaxAge.Value));
            clientHeaders.MaxStaleLimit = new TimeSpan(Convert.ToInt64(nudMaxStale.Value));
            clientHeaders.MinFresh = new TimeSpan(Convert.ToInt64(nudMinFresh.Value));
            clientHeaders.NoCache = cbNoCache.Checked;
            clientHeaders.NoStore = cbNoStore.Checked;
            clientHeaders.NoTransform = cbNoTransform.Checked;
            clientHeaders.OnlyIfCached = cbOnlyIfCached.Checked;
            /*clientHeaders.IfMatch.AddRange(tbIfMatch.Text.Split(delim));
            clientHeaders.IfModifiedSince.AddRange(tbIfModifiedSince.Text.Split(delim));
            clientHeaders.IfNoneMatch.AddRange(tbIfNonMatch.Text.Split(delim));
            clientHeaders.IfRange = tbIfRange.Text;
            clientHeaders.IfUnmodifiedSince.AddRange(tbIfUnmodifiedSince.Text.Split(delim));*/
            clientHeaders.From = RemoveWhiteSpace(tbFrom.Text);
            clientHeaders.ExpectContinue = cbExpectContinue.Checked;
            clientHeaders.Range = RemoveWhiteSpace(tbRange.Text);
            clientHeaders.UserAgent = RemoveWhiteSpace(tbUserAgent.Text);
            clientHeaders.Warning = RemoveWhiteSpace(tbWarning.Text);

        }

        private void ClientHeaders_Load(object sender, EventArgs e) {
            tbAccept.Text = clientHeaders.Accept;
            tbAcceptLanguage.Text = clientHeaders.AcceptLanguage;
            cbAuthType.Text = clientHeaders.AuthorizationType;
            tbAuthCredentials.Text = clientHeaders.Authorization;
            cbProxyAuthType.Text = clientHeaders.ProxyAuthorizationType;
            tbProxyAuthCredentials.Text = clientHeaders.ProxyAuthorization;
            nudMaxAge.Value = clientHeaders.MaxAge.Ticks;
            nudMaxStale.Value = clientHeaders.MaxStaleLimit.Ticks;
            nudMinFresh.Value = clientHeaders.MinFresh.Ticks;
            cbNoCache.Checked = clientHeaders.NoCache;
            cbNoStore.Checked = clientHeaders.NoStore;
            cbNoTransform.Checked = clientHeaders.NoTransform;
            cbOnlyIfCached.Checked = clientHeaders.OnlyIfCached;

            // Conditionals go here

            tbFrom.Text = clientHeaders.From;
            cbExpectContinue.Checked = clientHeaders.ExpectContinue;
            tbRange.Text = clientHeaders.Range;
            tbUserAgent.Text = clientHeaders.UserAgent;
            tbWarning.Text = clientHeaders.UserAgent;
        }
	}
}
