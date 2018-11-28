using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            clientHeaders.Accept.AddRange(tbAccept.Text.Split('\n'));
            clientHeaders.AcceptCharset.AddRange(tbAcceptCharset.Text.Split('\n'));
            clientHeaders.AcceptEncoding.AddRange(tbAcceptEncoding.Text.Split('\n'));
            clientHeaders.AcceptLanguage.AddRange(tbAcceptLanguage.Text.Split('\n'));
            clientHeaders.Authorization = tbAuthorization.Text;
            clientHeaders.CacheControl.AddRange(tbCacheControl.Text.Split('\n'));
            clientHeaders.Connection.AddRange(tbConnection.Text.Split('\n'));
            clientHeaders.Date = tbDate.Text;
            clientHeaders.Expect = tbExpect.Text;
            clientHeaders.From = tbFrom.Text;
            clientHeaders.Host = tbHost.Text;
            clientHeaders.IfMatch.AddRange(tbIfMatch.Text.Split('\n'));
            clientHeaders.IfModifiedSince.AddRange(tbIfModifiedSince.Text.Split('\n'));
            clientHeaders.IfNoneMatch.AddRange(tbIfNoneMatch.Text.Split('\n'));
            clientHeaders.IfRange.AddRange(tbRange.Text.Split('\n'));
            clientHeaders.IfUnmodifiedSince.AddRange(tbIfUnmodifiedSince.Text.Split('\n'));
            clientHeaders.Range.AddRange(tbRange.Text.Split('\n'));
            clientHeaders.Referrer = tbReferrer.Text;
            clientHeaders.Te.AddRange(tbTE.Text.Split('\n'));
            clientHeaders.Trailer.AddRange(tbTrailer.Text.Split('\n'));
            clientHeaders.TransferEncoding = tbTransferEncoding.Text;
            clientHeaders.UserAgent = tbUserAgent.Text;
            clientHeaders.Via.AddRange(tbVia.Text.Split('\n'));
            clientHeaders.Warning = tbWarning.Text;
        }
    }
}
