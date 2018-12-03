using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPConnections {
    internal class HttpClientHeaders {
        #region internalvars
        private List<String> accept;
        private List<String> acceptLanguage;

        private String authType;
        private String authorization;
        private String proxyAuthType;
        private String proxyAuth;

        private TimeSpan maxAge;
        private TimeSpan maxStaleLimit;
        private TimeSpan minfresh;

        private bool noCache;
        private bool noStore;
        private bool noTransform;
        private bool onlyIfCached;

        private bool expectContinue;

        private String from;

        private List<String> ifMatch;
        private List<String> ifModifiedSince;
        private List<String> ifNoneMatch;
        private String ifRange;
        private List<String> ifUnmodifiedSince;

        private String range;

        private String userAgent;
        private String warning;
        #endregion

        public HttpClientHeaders() {
            accept = new List<string>();
            acceptLanguage = new List<String>();
            authType = "";
            authorization = "";
            proxyAuthType = "";
            proxyAuth = "";
            maxAge = TimeSpan.Zero;
            maxStaleLimit = TimeSpan.Zero;
            minfresh = TimeSpan.Zero;
            noCache = false;
            noStore = false;
            noTransform = false;
            onlyIfCached = false;
            expectContinue = false;
            from = "";
            ifMatch = new List<string>();
            ifModifiedSince = new List<string>();
            ifNoneMatch = new List<string>();
            ifRange = "";
            ifUnmodifiedSince = new List<string>();
            range = "";
            userAgent = "";
            warning = "";
        }

        #region properties
        public List<String> Accept {
            get { return accept; }
            set { accept = value; }
        }

        public List<String> AcceptLanguage {
            get { return acceptLanguage; }
            set { acceptLanguage = value; }
        }

        public String AuthorizationType {
            get { return authType; }
            set { authType = value; }
        }

        public String Authorization {
            get { return authorization; }
            set { authorization = value; }
        }

        public String ProxyAuthorizationType {
            get { return proxyAuthType; }
            set { proxyAuthType = value; }
        }

        public String ProxyAuthorization {
            get { return proxyAuth; }
            set { proxyAuth = value; }
        }

        public TimeSpan MaxAge {
            get { return maxAge; }
            set { maxAge = value; }
        }

        public TimeSpan MaxStaleLimit {
            get { return maxStaleLimit; }
            set { maxStaleLimit = value; }
        }

        public TimeSpan MinFresh {
            get { return minfresh; }
            set { minfresh = value; }
        }

        public bool NoCache {
            get { return noCache; }
            set { noCache = value; }
        }

        public bool NoStore {
            get { return noStore; }
            set { noStore = value; }
        }

        public bool NoTransform {
            get { return noTransform; }
            set { noTransform = value; }
        }

        public bool OnlyIfCached {
            get { return onlyIfCached; }
            set { onlyIfCached = value; }
        }

        public bool ExpectContinue {
            get { return expectContinue; }
            set { expectContinue = value; }
        }

        public string From {
            get { return from; }
            set { from = value; }
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

        public String IfRange {
            get { return ifRange; }
            set { ifRange = value; }
        }

        public List<string> IfUnmodifiedSince {
            get { return ifUnmodifiedSince; }
            set { ifUnmodifiedSince = value;}
        }

        public string Range {
            get { return range; }
            set { range = value; }
        }

        public string UserAgent {
            get { return userAgent; }
            set { userAgent = value; }
        }

        public string Warning {
            get { return warning; }
            set { warning = value; }
        }
        #endregion
    }
}
