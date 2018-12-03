namespace HTTPConnections {
	partial class ClientHeaders {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.lblAcceptLanguage = new System.Windows.Forms.Label();
            this.tbAcceptLanguage = new System.Windows.Forms.TextBox();
            this.tbAccept = new System.Windows.Forms.TextBox();
            this.lblAuthType = new System.Windows.Forms.Label();
            this.cbAuthType = new System.Windows.Forms.ComboBox();
            this.lblAuthCredentials = new System.Windows.Forms.Label();
            this.tbAuthCredentials = new System.Windows.Forms.TextBox();
            this.lblProxyAuthType = new System.Windows.Forms.Label();
            this.cbProxyAuthType = new System.Windows.Forms.ComboBox();
            this.lblProxyAuthCredentials = new System.Windows.Forms.Label();
            this.tbProxyAuthCredentials = new System.Windows.Forms.TextBox();
            this.gbAccept = new System.Windows.Forms.GroupBox();
            this.gbAuthorization = new System.Windows.Forms.GroupBox();
            this.gbCacheControl = new System.Windows.Forms.GroupBox();
            this.cbOnlyIfCached = new System.Windows.Forms.CheckBox();
            this.cbNoTransform = new System.Windows.Forms.CheckBox();
            this.cbNoStore = new System.Windows.Forms.CheckBox();
            this.cbNoCache = new System.Windows.Forms.CheckBox();
            this.nudMinFresh = new System.Windows.Forms.NumericUpDown();
            this.lblMinFresh = new System.Windows.Forms.Label();
            this.nudMaxStale = new System.Windows.Forms.NumericUpDown();
            this.lblMaxStale = new System.Windows.Forms.Label();
            this.nudMaxAge = new System.Windows.Forms.NumericUpDown();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.gbExpect = new System.Windows.Forms.GroupBox();
            this.cbExpectContinue = new System.Windows.Forms.CheckBox();
            this.gbConditional = new System.Windows.Forms.GroupBox();
            this.tbIfUnmodifiedSince = new System.Windows.Forms.TextBox();
            this.lblIfUnmodifiedSince = new System.Windows.Forms.Label();
            this.tbIfRange = new System.Windows.Forms.TextBox();
            this.lblIfRange = new System.Windows.Forms.Label();
            this.tbIfNonMatch = new System.Windows.Forms.TextBox();
            this.lblIfNoneMatch = new System.Windows.Forms.Label();
            this.tbIfModifiedSince = new System.Windows.Forms.TextBox();
            this.lblIfModifiedSince = new System.Windows.Forms.Label();
            this.tbIfMatch = new System.Windows.Forms.TextBox();
            this.lblIfMatch = new System.Windows.Forms.Label();
            this.gbRange = new System.Windows.Forms.GroupBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.gbUserAgent = new System.Windows.Forms.GroupBox();
            this.tbUserAgent = new System.Windows.Forms.TextBox();
            this.gbWarning = new System.Windows.Forms.GroupBox();
            this.tbWarning = new System.Windows.Forms.TextBox();
            this.gbAccept.SuspendLayout();
            this.gbAuthorization.SuspendLayout();
            this.gbCacheControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).BeginInit();
            this.gbFrom.SuspendLayout();
            this.gbExpect.SuspendLayout();
            this.gbConditional.SuspendLayout();
            this.gbRange.SuspendLayout();
            this.gbUserAgent.SuspendLayout();
            this.gbWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAcceptLanguage
            // 
            this.lblAcceptLanguage.AutoSize = true;
            this.lblAcceptLanguage.Location = new System.Drawing.Point(6, 42);
            this.lblAcceptLanguage.Name = "lblAcceptLanguage";
            this.lblAcceptLanguage.Size = new System.Drawing.Size(92, 13);
            this.lblAcceptLanguage.TabIndex = 2;
            this.lblAcceptLanguage.Text = "Accept-Language";
            // 
            // tbAcceptLanguage
            // 
            this.tbAcceptLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAcceptLanguage.Location = new System.Drawing.Point(6, 58);
            this.tbAcceptLanguage.Name = "tbAcceptLanguage";
            this.tbAcceptLanguage.Size = new System.Drawing.Size(188, 20);
            this.tbAcceptLanguage.TabIndex = 3;
            // 
            // tbAccept
            // 
            this.tbAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccept.Location = new System.Drawing.Point(6, 19);
            this.tbAccept.Name = "tbAccept";
            this.tbAccept.Size = new System.Drawing.Size(188, 20);
            this.tbAccept.TabIndex = 4;
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(6, 16);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(95, 13);
            this.lblAuthType.TabIndex = 5;
            this.lblAuthType.Text = "Authorization Type";
            // 
            // cbAuthType
            // 
            this.cbAuthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthType.FormattingEnabled = true;
            this.cbAuthType.Items.AddRange(new object[] {
            "Basic",
            "Bearer",
            "Digest",
            "HOBA",
            "Mutual",
            "Negotiate",
            "OAuth",
            "SCRAM-SHA-1",
            "SCRAM-SHA-256",
            "vapid"});
            this.cbAuthType.Location = new System.Drawing.Point(6, 32);
            this.cbAuthType.Name = "cbAuthType";
            this.cbAuthType.Size = new System.Drawing.Size(188, 21);
            this.cbAuthType.TabIndex = 6;
            // 
            // lblAuthCredentials
            // 
            this.lblAuthCredentials.AutoSize = true;
            this.lblAuthCredentials.Location = new System.Drawing.Point(6, 56);
            this.lblAuthCredentials.Name = "lblAuthCredentials";
            this.lblAuthCredentials.Size = new System.Drawing.Size(123, 13);
            this.lblAuthCredentials.TabIndex = 7;
            this.lblAuthCredentials.Text = "Authorization Credentials";
            // 
            // tbAuthCredentials
            // 
            this.tbAuthCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthCredentials.Location = new System.Drawing.Point(6, 72);
            this.tbAuthCredentials.Name = "tbAuthCredentials";
            this.tbAuthCredentials.Size = new System.Drawing.Size(188, 20);
            this.tbAuthCredentials.TabIndex = 8;
            // 
            // lblProxyAuthType
            // 
            this.lblProxyAuthType.AutoSize = true;
            this.lblProxyAuthType.Location = new System.Drawing.Point(6, 95);
            this.lblProxyAuthType.Name = "lblProxyAuthType";
            this.lblProxyAuthType.Size = new System.Drawing.Size(124, 13);
            this.lblProxyAuthType.TabIndex = 9;
            this.lblProxyAuthType.Text = "Proxy Authorization Type";
            // 
            // cbProxyAuthType
            // 
            this.cbProxyAuthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProxyAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProxyAuthType.FormattingEnabled = true;
            this.cbProxyAuthType.Items.AddRange(new object[] {
            "Basic",
            "Bearer",
            "Digest",
            "HOBA",
            "Mutual",
            "Negotiate",
            "OAuth",
            "SCRAM-SHA-1",
            "SCRAM-SHA-256",
            "vapid"});
            this.cbProxyAuthType.Location = new System.Drawing.Point(6, 111);
            this.cbProxyAuthType.Name = "cbProxyAuthType";
            this.cbProxyAuthType.Size = new System.Drawing.Size(188, 21);
            this.cbProxyAuthType.TabIndex = 10;
            // 
            // lblProxyAuthCredentials
            // 
            this.lblProxyAuthCredentials.AutoSize = true;
            this.lblProxyAuthCredentials.Location = new System.Drawing.Point(6, 135);
            this.lblProxyAuthCredentials.Name = "lblProxyAuthCredentials";
            this.lblProxyAuthCredentials.Size = new System.Drawing.Size(152, 13);
            this.lblProxyAuthCredentials.TabIndex = 11;
            this.lblProxyAuthCredentials.Text = "Proxy Authorization Credentials";
            // 
            // tbProxyAuthCredentials
            // 
            this.tbProxyAuthCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProxyAuthCredentials.Location = new System.Drawing.Point(6, 151);
            this.tbProxyAuthCredentials.Name = "tbProxyAuthCredentials";
            this.tbProxyAuthCredentials.Size = new System.Drawing.Size(188, 20);
            this.tbProxyAuthCredentials.TabIndex = 12;
            // 
            // gbAccept
            // 
            this.gbAccept.Controls.Add(this.tbAccept);
            this.gbAccept.Controls.Add(this.lblAcceptLanguage);
            this.gbAccept.Controls.Add(this.tbAcceptLanguage);
            this.gbAccept.Location = new System.Drawing.Point(12, 12);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.Size = new System.Drawing.Size(200, 86);
            this.gbAccept.TabIndex = 13;
            this.gbAccept.TabStop = false;
            this.gbAccept.Text = "Accept";
            // 
            // gbAuthorization
            // 
            this.gbAuthorization.Controls.Add(this.lblAuthType);
            this.gbAuthorization.Controls.Add(this.cbAuthType);
            this.gbAuthorization.Controls.Add(this.tbProxyAuthCredentials);
            this.gbAuthorization.Controls.Add(this.lblAuthCredentials);
            this.gbAuthorization.Controls.Add(this.lblProxyAuthCredentials);
            this.gbAuthorization.Controls.Add(this.tbAuthCredentials);
            this.gbAuthorization.Controls.Add(this.cbProxyAuthType);
            this.gbAuthorization.Controls.Add(this.lblProxyAuthType);
            this.gbAuthorization.Location = new System.Drawing.Point(12, 104);
            this.gbAuthorization.Name = "gbAuthorization";
            this.gbAuthorization.Size = new System.Drawing.Size(200, 181);
            this.gbAuthorization.TabIndex = 14;
            this.gbAuthorization.TabStop = false;
            this.gbAuthorization.Text = "Authorization";
            // 
            // gbCacheControl
            // 
            this.gbCacheControl.Controls.Add(this.cbOnlyIfCached);
            this.gbCacheControl.Controls.Add(this.cbNoTransform);
            this.gbCacheControl.Controls.Add(this.cbNoStore);
            this.gbCacheControl.Controls.Add(this.cbNoCache);
            this.gbCacheControl.Controls.Add(this.nudMinFresh);
            this.gbCacheControl.Controls.Add(this.lblMinFresh);
            this.gbCacheControl.Controls.Add(this.nudMaxStale);
            this.gbCacheControl.Controls.Add(this.lblMaxStale);
            this.gbCacheControl.Controls.Add(this.nudMaxAge);
            this.gbCacheControl.Controls.Add(this.lblMaxAge);
            this.gbCacheControl.Location = new System.Drawing.Point(12, 291);
            this.gbCacheControl.Name = "gbCacheControl";
            this.gbCacheControl.Size = new System.Drawing.Size(200, 235);
            this.gbCacheControl.TabIndex = 15;
            this.gbCacheControl.TabStop = false;
            this.gbCacheControl.Text = "Cache Control";
            // 
            // cbOnlyIfCached
            // 
            this.cbOnlyIfCached.AutoSize = true;
            this.cbOnlyIfCached.Location = new System.Drawing.Point(6, 205);
            this.cbOnlyIfCached.Name = "cbOnlyIfCached";
            this.cbOnlyIfCached.Size = new System.Drawing.Size(96, 17);
            this.cbOnlyIfCached.TabIndex = 9;
            this.cbOnlyIfCached.Text = "Only-If-Cached";
            this.cbOnlyIfCached.UseVisualStyleBackColor = true;
            // 
            // cbNoTransform
            // 
            this.cbNoTransform.AutoSize = true;
            this.cbNoTransform.Location = new System.Drawing.Point(6, 182);
            this.cbNoTransform.Name = "cbNoTransform";
            this.cbNoTransform.Size = new System.Drawing.Size(90, 17);
            this.cbNoTransform.TabIndex = 8;
            this.cbNoTransform.Text = "No-Transform";
            this.cbNoTransform.UseVisualStyleBackColor = true;
            // 
            // cbNoStore
            // 
            this.cbNoStore.AutoSize = true;
            this.cbNoStore.Location = new System.Drawing.Point(6, 159);
            this.cbNoStore.Name = "cbNoStore";
            this.cbNoStore.Size = new System.Drawing.Size(68, 17);
            this.cbNoStore.TabIndex = 7;
            this.cbNoStore.Text = "No-Store";
            this.cbNoStore.UseVisualStyleBackColor = true;
            // 
            // cbNoCache
            // 
            this.cbNoCache.AutoSize = true;
            this.cbNoCache.Location = new System.Drawing.Point(6, 136);
            this.cbNoCache.Name = "cbNoCache";
            this.cbNoCache.Size = new System.Drawing.Size(74, 17);
            this.cbNoCache.TabIndex = 6;
            this.cbNoCache.Text = "No-Cache";
            this.cbNoCache.UseVisualStyleBackColor = true;
            // 
            // nudMinFresh
            // 
            this.nudMinFresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinFresh.Location = new System.Drawing.Point(6, 110);
            this.nudMinFresh.Name = "nudMinFresh";
            this.nudMinFresh.Size = new System.Drawing.Size(188, 20);
            this.nudMinFresh.TabIndex = 5;
            // 
            // lblMinFresh
            // 
            this.lblMinFresh.AutoSize = true;
            this.lblMinFresh.Location = new System.Drawing.Point(6, 94);
            this.lblMinFresh.Name = "lblMinFresh";
            this.lblMinFresh.Size = new System.Drawing.Size(53, 13);
            this.lblMinFresh.TabIndex = 4;
            this.lblMinFresh.Text = "Min-Fresh";
            // 
            // nudMaxStale
            // 
            this.nudMaxStale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxStale.Location = new System.Drawing.Point(6, 71);
            this.nudMaxStale.Name = "nudMaxStale";
            this.nudMaxStale.Size = new System.Drawing.Size(188, 20);
            this.nudMaxStale.TabIndex = 3;
            // 
            // lblMaxStale
            // 
            this.lblMaxStale.AutoSize = true;
            this.lblMaxStale.Location = new System.Drawing.Point(6, 55);
            this.lblMaxStale.Name = "lblMaxStale";
            this.lblMaxStale.Size = new System.Drawing.Size(54, 13);
            this.lblMaxStale.TabIndex = 2;
            this.lblMaxStale.Text = "Max-Stale";
            // 
            // nudMaxAge
            // 
            this.nudMaxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxAge.Location = new System.Drawing.Point(6, 32);
            this.nudMaxAge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxAge.Name = "nudMaxAge";
            this.nudMaxAge.Size = new System.Drawing.Size(188, 20);
            this.nudMaxAge.TabIndex = 1;
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.Location = new System.Drawing.Point(6, 16);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(49, 13);
            this.lblMaxAge.TabIndex = 0;
            this.lblMaxAge.Text = "Max-Age";
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.tbFrom);
            this.gbFrom.Location = new System.Drawing.Point(218, 232);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(200, 53);
            this.gbFrom.TabIndex = 16;
            this.gbFrom.TabStop = false;
            this.gbFrom.Text = "From";
            // 
            // tbFrom
            // 
            this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrom.Location = new System.Drawing.Point(6, 19);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(188, 20);
            this.tbFrom.TabIndex = 0;
            // 
            // gbExpect
            // 
            this.gbExpect.Controls.Add(this.cbExpectContinue);
            this.gbExpect.Location = new System.Drawing.Point(218, 291);
            this.gbExpect.Name = "gbExpect";
            this.gbExpect.Size = new System.Drawing.Size(200, 48);
            this.gbExpect.TabIndex = 17;
            this.gbExpect.TabStop = false;
            this.gbExpect.Text = "Expect";
            // 
            // cbExpectContinue
            // 
            this.cbExpectContinue.AutoSize = true;
            this.cbExpectContinue.Location = new System.Drawing.Point(6, 19);
            this.cbExpectContinue.Name = "cbExpectContinue";
            this.cbExpectContinue.Size = new System.Drawing.Size(89, 17);
            this.cbExpectContinue.TabIndex = 0;
            this.cbExpectContinue.Text = "100-Continue";
            this.cbExpectContinue.UseVisualStyleBackColor = true;
            // 
            // gbConditional
            // 
            this.gbConditional.Controls.Add(this.tbIfUnmodifiedSince);
            this.gbConditional.Controls.Add(this.lblIfUnmodifiedSince);
            this.gbConditional.Controls.Add(this.tbIfRange);
            this.gbConditional.Controls.Add(this.lblIfRange);
            this.gbConditional.Controls.Add(this.tbIfNonMatch);
            this.gbConditional.Controls.Add(this.lblIfNoneMatch);
            this.gbConditional.Controls.Add(this.tbIfModifiedSince);
            this.gbConditional.Controls.Add(this.lblIfModifiedSince);
            this.gbConditional.Controls.Add(this.tbIfMatch);
            this.gbConditional.Controls.Add(this.lblIfMatch);
            this.gbConditional.Location = new System.Drawing.Point(218, 12);
            this.gbConditional.Name = "gbConditional";
            this.gbConditional.Size = new System.Drawing.Size(200, 216);
            this.gbConditional.TabIndex = 18;
            this.gbConditional.TabStop = false;
            this.gbConditional.Text = "Conditionals";
            // 
            // tbIfUnmodifiedSince
            // 
            this.tbIfUnmodifiedSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIfUnmodifiedSince.Location = new System.Drawing.Point(6, 188);
            this.tbIfUnmodifiedSince.Name = "tbIfUnmodifiedSince";
            this.tbIfUnmodifiedSince.Size = new System.Drawing.Size(188, 20);
            this.tbIfUnmodifiedSince.TabIndex = 9;
            // 
            // lblIfUnmodifiedSince
            // 
            this.lblIfUnmodifiedSince.AutoSize = true;
            this.lblIfUnmodifiedSince.Location = new System.Drawing.Point(6, 172);
            this.lblIfUnmodifiedSince.Name = "lblIfUnmodifiedSince";
            this.lblIfUnmodifiedSince.Size = new System.Drawing.Size(99, 13);
            this.lblIfUnmodifiedSince.TabIndex = 8;
            this.lblIfUnmodifiedSince.Text = "If-Unmodified-Since";
            // 
            // tbIfRange
            // 
            this.tbIfRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIfRange.Location = new System.Drawing.Point(6, 149);
            this.tbIfRange.Name = "tbIfRange";
            this.tbIfRange.Size = new System.Drawing.Size(188, 20);
            this.tbIfRange.TabIndex = 7;
            // 
            // lblIfRange
            // 
            this.lblIfRange.AutoSize = true;
            this.lblIfRange.Location = new System.Drawing.Point(6, 133);
            this.lblIfRange.Name = "lblIfRange";
            this.lblIfRange.Size = new System.Drawing.Size(48, 13);
            this.lblIfRange.TabIndex = 6;
            this.lblIfRange.Text = "If-Range";
            // 
            // tbIfNonMatch
            // 
            this.tbIfNonMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIfNonMatch.Location = new System.Drawing.Point(6, 110);
            this.tbIfNonMatch.Name = "tbIfNonMatch";
            this.tbIfNonMatch.Size = new System.Drawing.Size(188, 20);
            this.tbIfNonMatch.TabIndex = 5;
            // 
            // lblIfNoneMatch
            // 
            this.lblIfNoneMatch.AutoSize = true;
            this.lblIfNoneMatch.Location = new System.Drawing.Point(6, 94);
            this.lblIfNoneMatch.Name = "lblIfNoneMatch";
            this.lblIfNoneMatch.Size = new System.Drawing.Size(75, 13);
            this.lblIfNoneMatch.TabIndex = 4;
            this.lblIfNoneMatch.Text = "If-None-Match";
            // 
            // tbIfModifiedSince
            // 
            this.tbIfModifiedSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIfModifiedSince.Location = new System.Drawing.Point(6, 71);
            this.tbIfModifiedSince.Name = "tbIfModifiedSince";
            this.tbIfModifiedSince.Size = new System.Drawing.Size(188, 20);
            this.tbIfModifiedSince.TabIndex = 3;
            // 
            // lblIfModifiedSince
            // 
            this.lblIfModifiedSince.AutoSize = true;
            this.lblIfModifiedSince.Location = new System.Drawing.Point(6, 55);
            this.lblIfModifiedSince.Name = "lblIfModifiedSince";
            this.lblIfModifiedSince.Size = new System.Drawing.Size(86, 13);
            this.lblIfModifiedSince.TabIndex = 2;
            this.lblIfModifiedSince.Text = "If-Modified-Since";
            // 
            // tbIfMatch
            // 
            this.tbIfMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIfMatch.Location = new System.Drawing.Point(6, 32);
            this.tbIfMatch.Name = "tbIfMatch";
            this.tbIfMatch.Size = new System.Drawing.Size(188, 20);
            this.tbIfMatch.TabIndex = 1;
            // 
            // lblIfMatch
            // 
            this.lblIfMatch.AutoSize = true;
            this.lblIfMatch.Location = new System.Drawing.Point(6, 16);
            this.lblIfMatch.Name = "lblIfMatch";
            this.lblIfMatch.Size = new System.Drawing.Size(46, 13);
            this.lblIfMatch.TabIndex = 0;
            this.lblIfMatch.Text = "If-Match";
            // 
            // gbRange
            // 
            this.gbRange.Controls.Add(this.tbRange);
            this.gbRange.Location = new System.Drawing.Point(218, 345);
            this.gbRange.Name = "gbRange";
            this.gbRange.Size = new System.Drawing.Size(200, 51);
            this.gbRange.TabIndex = 19;
            this.gbRange.TabStop = false;
            this.gbRange.Text = "Range";
            // 
            // tbRange
            // 
            this.tbRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRange.Location = new System.Drawing.Point(6, 19);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(188, 20);
            this.tbRange.TabIndex = 0;
            // 
            // gbUserAgent
            // 
            this.gbUserAgent.Controls.Add(this.tbUserAgent);
            this.gbUserAgent.Location = new System.Drawing.Point(218, 402);
            this.gbUserAgent.Name = "gbUserAgent";
            this.gbUserAgent.Size = new System.Drawing.Size(200, 50);
            this.gbUserAgent.TabIndex = 20;
            this.gbUserAgent.TabStop = false;
            this.gbUserAgent.Text = "User-Agent";
            // 
            // tbUserAgent
            // 
            this.tbUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserAgent.Location = new System.Drawing.Point(6, 19);
            this.tbUserAgent.Name = "tbUserAgent";
            this.tbUserAgent.Size = new System.Drawing.Size(188, 20);
            this.tbUserAgent.TabIndex = 0;
            // 
            // gbWarning
            // 
            this.gbWarning.Controls.Add(this.tbWarning);
            this.gbWarning.Location = new System.Drawing.Point(218, 458);
            this.gbWarning.Name = "gbWarning";
            this.gbWarning.Size = new System.Drawing.Size(200, 49);
            this.gbWarning.TabIndex = 21;
            this.gbWarning.TabStop = false;
            this.gbWarning.Text = "Warning";
            // 
            // tbWarning
            // 
            this.tbWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWarning.Location = new System.Drawing.Point(6, 19);
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.Size = new System.Drawing.Size(188, 20);
            this.tbWarning.TabIndex = 0;
            // 
            // ClientHeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(429, 540);
            this.Controls.Add(this.gbWarning);
            this.Controls.Add(this.gbUserAgent);
            this.Controls.Add(this.gbRange);
            this.Controls.Add(this.gbConditional);
            this.Controls.Add(this.gbExpect);
            this.Controls.Add(this.gbFrom);
            this.Controls.Add(this.gbCacheControl);
            this.Controls.Add(this.gbAuthorization);
            this.Controls.Add(this.gbAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientHeaders";
            this.Text = "Client Headers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientHeaders_FormClosing);
            this.Load += new System.EventHandler(this.ClientHeaders_Load);
            this.gbAccept.ResumeLayout(false);
            this.gbAccept.PerformLayout();
            this.gbAuthorization.ResumeLayout(false);
            this.gbAuthorization.PerformLayout();
            this.gbCacheControl.ResumeLayout(false);
            this.gbCacheControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).EndInit();
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbExpect.ResumeLayout(false);
            this.gbExpect.PerformLayout();
            this.gbConditional.ResumeLayout(false);
            this.gbConditional.PerformLayout();
            this.gbRange.ResumeLayout(false);
            this.gbRange.PerformLayout();
            this.gbUserAgent.ResumeLayout(false);
            this.gbUserAgent.PerformLayout();
            this.gbWarning.ResumeLayout(false);
            this.gbWarning.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Label lblAcceptLanguage;
        private System.Windows.Forms.TextBox tbAcceptLanguage;
        private System.Windows.Forms.TextBox tbAccept;
        private System.Windows.Forms.Label lblAuthType;
        private System.Windows.Forms.ComboBox cbAuthType;
        private System.Windows.Forms.Label lblAuthCredentials;
        private System.Windows.Forms.TextBox tbAuthCredentials;
        private System.Windows.Forms.Label lblProxyAuthType;
        private System.Windows.Forms.ComboBox cbProxyAuthType;
        private System.Windows.Forms.Label lblProxyAuthCredentials;
        private System.Windows.Forms.TextBox tbProxyAuthCredentials;
        private System.Windows.Forms.GroupBox gbAccept;
        private System.Windows.Forms.GroupBox gbAuthorization;
        private System.Windows.Forms.GroupBox gbCacheControl;
        private System.Windows.Forms.Label lblMaxStale;
        private System.Windows.Forms.NumericUpDown nudMaxAge;
        private System.Windows.Forms.Label lblMaxAge;
        private System.Windows.Forms.NumericUpDown nudMaxStale;
        private System.Windows.Forms.NumericUpDown nudMinFresh;
        private System.Windows.Forms.Label lblMinFresh;
        private System.Windows.Forms.CheckBox cbNoTransform;
        private System.Windows.Forms.CheckBox cbNoStore;
        private System.Windows.Forms.CheckBox cbNoCache;
        private System.Windows.Forms.CheckBox cbOnlyIfCached;
        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.GroupBox gbExpect;
        private System.Windows.Forms.CheckBox cbExpectContinue;
        private System.Windows.Forms.GroupBox gbConditional;
        private System.Windows.Forms.TextBox tbIfUnmodifiedSince;
        private System.Windows.Forms.Label lblIfUnmodifiedSince;
        private System.Windows.Forms.TextBox tbIfRange;
        private System.Windows.Forms.Label lblIfRange;
        private System.Windows.Forms.TextBox tbIfNonMatch;
        private System.Windows.Forms.Label lblIfNoneMatch;
        private System.Windows.Forms.TextBox tbIfModifiedSince;
        private System.Windows.Forms.Label lblIfModifiedSince;
        private System.Windows.Forms.TextBox tbIfMatch;
        private System.Windows.Forms.Label lblIfMatch;
        private System.Windows.Forms.GroupBox gbRange;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.GroupBox gbUserAgent;
        private System.Windows.Forms.TextBox tbUserAgent;
        private System.Windows.Forms.GroupBox gbWarning;
        private System.Windows.Forms.TextBox tbWarning;
    }
}