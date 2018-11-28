using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPConnections {
    internal class HttpClientHeaders {
        #region internalvars
        private List<String> accept;
        private List<String> acceptCharset;
        private List<String> acceptEncoding;
        private List<String> acceptLanguage;
        private String authorization;
        private String cacheControl;
        private List<String> connection;
        private String date;
        private String expect;
        private String from;
        private String host;
        private List<String> ifMatch;
        private List<String> ifModifiedSince;
        private List<String> ifNoneMatch;
        private List<String> ifRange;
        private List<String> ifUnmodifiedSince;
        private String proxyAuthorization;
        private List<String> range;
        private String referrer;
        private List<String> te;
        private List<String> trailer;
        private String transferEncoding;
        private String userAgent;
        private List<String> via;
        private String warning;
        #endregion

        #region properties
        public List<string> Accept {
            get { return accept; }
            set { accept = value; }
        }

        public List<string> AcceptCharset {
            get { return acceptCharset; }
            set { acceptCharset = value; }
        }

        public List<string> AcceptEncoding {
            get { return acceptEncoding; }
            set { acceptEncoding = value; }
        }

        public List<string> AcceptLanguage {
            get { return acceptLanguage; }
            set { acceptLanguage = value; }
        }

        public string Authorization {
            get { return authorization; }
            set { authorization = value; }
        }

        public string CacheControl {
            get { return cacheControl; }
            set { cacheControl = value; }
        }

        public List<string> Connection {
            get { return connection; }
            set { connection = value; }
        }

        public string Date {
            get { return date; }
            set { date = value; }
        }

        public string Expect {
            get { return expect; }
            set { expect = value; }
        }

        public string From {
            get { return from; }
            set { from = value; }
        }

        public string Host {
            get { return host; }
            set { host = value; }
        }

        public List<string> IfMatch {
            get { return ifMatch; }
            set { ifMatch = value; }
        }

        public List<string> IfModifiedSince {
            get { return ifModifiedSince; }
            set { ifModifiedSince = value; }
        }

        public List<string> IfNoneMatch {
            get { return ifNoneMatch; }
            set { ifNoneMatch = value; }
        }

        public List<string> IfRange {
            get { return ifRange; }
            set { ifRange = value; }
        }

        public List<string> IfUnmodifiedSince {
            get { return ifUnmodifiedSince; }
            set { ifUnmodifiedSince = value; }
        }

        public string ProxyAuthorization {
            get { return proxyAuthorization; }
            set { proxyAuthorization = value; }
        }

        public List<string> Range {
            get { return range; }
            set { range = value; }
        }

        public string Referrer {
            get { return referrer; }
            set { referrer = value; }
        }

        public List<string> Te {
            get { return te; }
            set { te = value; }
        }

        public List<String> Trailer {
            get { return trailer; }
            set { trailer = value; }
        }

        public string TransferEncoding {
            get { return transferEncoding; }
            set { transferEncoding = value; }
        }

        public string UserAgent {
            get { return userAgent; }
            set { userAgent = value; }
        }

        public List<string> Via {
            get { return via; }
            set { via = value; }
        }

        public string Warning {
            get { return warning; }
            set { warning = value; }
        }
        #endregion
    }
}
