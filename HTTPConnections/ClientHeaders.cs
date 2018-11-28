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
        private HTTPControl parentControl;

		public ClientHeaders(HTTPControl _parentControl) {
			InitializeComponent();
            parentControl = _parentControl;
		}

        // Set client headers to UI control
        private void ClientHeaders_FormClosing(object sender, FormClosingEventArgs e) {
            parentControl.Accept.AddRange(tbAccept.Text.Split('\n'));
            parentControl.AcceptCharset.AddRange(tbAcceptCharset.Text.Split('\n'));
            parentControl.AcceptEncoding.AddRange(tbAcceptEncoding.Text.Split('\n'));
            parentControl.AcceptLanguage.AddRange(tbAcceptLanguage.Text.Split('\n'));
            parentControl.Authorization = tbAuthorization.Text;
            parentControl.CacheControl.AddRange(tbCacheControl.Text.Split('\n'));
            parentControl.Connection.AddRange(tbConnection.Text.Split('\n'));
            parentControl.Date = tbDate.Text;
            parentControl.Expect = tbExpect.Text;
            parentControl.From = tbFrom.Text;
            parentControl.Host = tbHost.Text;
            parentControl.IfMatch.AddRange(tbIfMatch.Text.Split('\n'));
            parentControl.IfModifiedSince.AddRange(tbIfModifiedSince.Text.Split('\n'));
            parentControl.IfNoneMatch.AddRange(tbIfNoneMatch.Text.Split('\n'));
            parentControl.IfRange.AddRange(tbRange.Text.Split('\n'));
            parentControl.IfUnmodifiedSince.AddRange(tbIfUnmodifiedSince.Text.Split('\n'));
            parentControl.Range.AddRange(tbRange.Text.Split('\n'));
            parentControl.Referrer = tbReferrer.Text;
            parentControl.Te.AddRange(tbTE.Text.Split('\n'));
            parentControl.Trailer.AddRange(tbTrailer.Text.Split('\n'));
            parentControl.TransferEncoding = tbTransferEncoding.Text;
            parentControl.UserAgent = tbUserAgent.Text;
            parentControl.Via.AddRange(tbVia.Text.Split('\n'));
            parentControl.Warning = tbWarning.Text;
        }
    }
}
