namespace ConnectionTester {
	partial class MainForm {
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
			this.tsConnectionType = new System.Windows.Forms.TabControl();
			this.tabConnectionTypeTcp = new System.Windows.Forms.TabPage();
			this.tbTCPSendString = new System.Windows.Forms.TextBox();
			this.lblSendString = new System.Windows.Forms.Label();
			this.tabConnectionTypeHTTP = new System.Windows.Forms.TabPage();
			this.pnlConnections = new System.Windows.Forms.Panel();
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbPortNum = new System.Windows.Forms.TextBox();
			this.lblPortNum = new System.Windows.Forms.Label();
			this.lblConnectTo = new System.Windows.Forms.Label();
			this.tbConnectTo = new System.Windows.Forms.TextBox();
			this.tbResponses = new System.Windows.Forms.RichTextBox();
			this.lblResponse = new System.Windows.Forms.Label();
			this.cbConnections = new System.Windows.Forms.ComboBox();
			this.lblConnections = new System.Windows.Forms.Label();
			this.btnAddConnection = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDeleteConnection = new System.Windows.Forms.Button();
			this.tsConnectionType.SuspendLayout();
			this.tabConnectionTypeTcp.SuspendLayout();
			this.tabConnectionTypeHTTP.SuspendLayout();
			this.pnlConnections.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsConnectionType
			// 
			this.tsConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsConnectionType.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tsConnectionType.Controls.Add(this.tabConnectionTypeTcp);
			this.tsConnectionType.Controls.Add(this.tabConnectionTypeHTTP);
			this.tsConnectionType.Location = new System.Drawing.Point(0, 102);
			this.tsConnectionType.Name = "tsConnectionType";
			this.tsConnectionType.SelectedIndex = 0;
			this.tsConnectionType.Size = new System.Drawing.Size(375, 182);
			this.tsConnectionType.TabIndex = 0;
			// 
			// tabConnectionTypeTcp
			// 
			this.tabConnectionTypeTcp.AutoScroll = true;
			this.tabConnectionTypeTcp.Controls.Add(this.tbTCPSendString);
			this.tabConnectionTypeTcp.Controls.Add(this.lblSendString);
			this.tabConnectionTypeTcp.Location = new System.Drawing.Point(4, 25);
			this.tabConnectionTypeTcp.Name = "tabConnectionTypeTcp";
			this.tabConnectionTypeTcp.Padding = new System.Windows.Forms.Padding(3);
			this.tabConnectionTypeTcp.Size = new System.Drawing.Size(367, 153);
			this.tabConnectionTypeTcp.TabIndex = 0;
			this.tabConnectionTypeTcp.Text = "TCP";
			this.tabConnectionTypeTcp.UseVisualStyleBackColor = true;
			// 
			// tbTCPSendString
			// 
			this.tbTCPSendString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTCPSendString.Location = new System.Drawing.Point(8, 25);
			this.tbTCPSendString.Name = "tbTCPSendString";
			this.tbTCPSendString.Size = new System.Drawing.Size(351, 20);
			this.tbTCPSendString.TabIndex = 1;
			// 
			// lblSendString
			// 
			this.lblSendString.AutoSize = true;
			this.lblSendString.Location = new System.Drawing.Point(8, 9);
			this.lblSendString.Name = "lblSendString";
			this.lblSendString.Size = new System.Drawing.Size(65, 13);
			this.lblSendString.TabIndex = 0;
			this.lblSendString.Text = "Send String:";
			// 
			// tabConnectionTypeHTTP
			// 
			this.tabConnectionTypeHTTP.Controls.Add(this.label1);
			this.tabConnectionTypeHTTP.Location = new System.Drawing.Point(4, 25);
			this.tabConnectionTypeHTTP.Name = "tabConnectionTypeHTTP";
			this.tabConnectionTypeHTTP.Padding = new System.Windows.Forms.Padding(3);
			this.tabConnectionTypeHTTP.Size = new System.Drawing.Size(367, 153);
			this.tabConnectionTypeHTTP.TabIndex = 1;
			this.tabConnectionTypeHTTP.Text = "HTTP";
			this.tabConnectionTypeHTTP.UseVisualStyleBackColor = true;
			// 
			// pnlConnections
			// 
			this.pnlConnections.Controls.Add(this.btnDisconnect);
			this.pnlConnections.Controls.Add(this.btnConnect);
			this.pnlConnections.Controls.Add(this.tbPortNum);
			this.pnlConnections.Controls.Add(this.lblPortNum);
			this.pnlConnections.Controls.Add(this.lblConnectTo);
			this.pnlConnections.Controls.Add(this.tbConnectTo);
			this.pnlConnections.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlConnections.Location = new System.Drawing.Point(0, 0);
			this.pnlConnections.Name = "pnlConnections";
			this.pnlConnections.Size = new System.Drawing.Size(375, 69);
			this.pnlConnections.TabIndex = 1;
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSendMessage.Location = new System.Drawing.Point(12, 286);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(89, 23);
			this.btnSendMessage.TabIndex = 6;
			this.btnSendMessage.Text = "Send";
			this.btnSendMessage.UseVisualStyleBackColor = true;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisconnect.Enabled = false;
			this.btnDisconnect.Location = new System.Drawing.Point(288, 36);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnect.Location = new System.Drawing.Point(207, 36);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// tbPortNum
			// 
			this.tbPortNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPortNum.Location = new System.Drawing.Point(47, 38);
			this.tbPortNum.Name = "tbPortNum";
			this.tbPortNum.Size = new System.Drawing.Size(154, 20);
			this.tbPortNum.TabIndex = 3;
			// 
			// lblPortNum
			// 
			this.lblPortNum.AutoSize = true;
			this.lblPortNum.Location = new System.Drawing.Point(12, 41);
			this.lblPortNum.Name = "lblPortNum";
			this.lblPortNum.Size = new System.Drawing.Size(26, 13);
			this.lblPortNum.TabIndex = 2;
			this.lblPortNum.Text = "Port";
			// 
			// lblConnectTo
			// 
			this.lblConnectTo.AutoSize = true;
			this.lblConnectTo.Location = new System.Drawing.Point(12, 15);
			this.lblConnectTo.Name = "lblConnectTo";
			this.lblConnectTo.Size = new System.Drawing.Size(29, 13);
			this.lblConnectTo.TabIndex = 1;
			this.lblConnectTo.Text = "Host";
			// 
			// tbConnectTo
			// 
			this.tbConnectTo.Location = new System.Drawing.Point(47, 12);
			this.tbConnectTo.Name = "tbConnectTo";
			this.tbConnectTo.Size = new System.Drawing.Size(316, 20);
			this.tbConnectTo.TabIndex = 0;
			// 
			// tbResponses
			// 
			this.tbResponses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResponses.Location = new System.Drawing.Point(4, 332);
			this.tbResponses.Name = "tbResponses";
			this.tbResponses.ReadOnly = true;
			this.tbResponses.Size = new System.Drawing.Size(367, 162);
			this.tbResponses.TabIndex = 2;
			this.tbResponses.Text = "";
			// 
			// lblResponse
			// 
			this.lblResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblResponse.AutoSize = true;
			this.lblResponse.Location = new System.Drawing.Point(3, 316);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(60, 13);
			this.lblResponse.TabIndex = 3;
			this.lblResponse.Text = "Responses";
			// 
			// cbConnections
			// 
			this.cbConnections.FormattingEnabled = true;
			this.cbConnections.Location = new System.Drawing.Point(84, 75);
			this.cbConnections.Name = "cbConnections";
			this.cbConnections.Size = new System.Drawing.Size(117, 21);
			this.cbConnections.TabIndex = 4;
			// 
			// lblConnections
			// 
			this.lblConnections.AutoSize = true;
			this.lblConnections.Location = new System.Drawing.Point(12, 78);
			this.lblConnections.Name = "lblConnections";
			this.lblConnections.Size = new System.Drawing.Size(66, 13);
			this.lblConnections.TabIndex = 5;
			this.lblConnections.Text = "Connections";
			// 
			// btnAddConnection
			// 
			this.btnAddConnection.Location = new System.Drawing.Point(207, 73);
			this.btnAddConnection.Name = "btnAddConnection";
			this.btnAddConnection.Size = new System.Drawing.Size(75, 23);
			this.btnAddConnection.TabIndex = 6;
			this.btnAddConnection.Text = "New";
			this.btnAddConnection.UseVisualStyleBackColor = true;
			this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(135, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Not Implemented";
			// 
			// btnDeleteConnection
			// 
			this.btnDeleteConnection.Location = new System.Drawing.Point(288, 73);
			this.btnDeleteConnection.Name = "btnDeleteConnection";
			this.btnDeleteConnection.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteConnection.TabIndex = 7;
			this.btnDeleteConnection.Text = "Remove";
			this.btnDeleteConnection.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 506);
			this.Controls.Add(this.btnDeleteConnection);
			this.Controls.Add(this.btnAddConnection);
			this.Controls.Add(this.btnSendMessage);
			this.Controls.Add(this.lblConnections);
			this.Controls.Add(this.cbConnections);
			this.Controls.Add(this.lblResponse);
			this.Controls.Add(this.tbResponses);
			this.Controls.Add(this.pnlConnections);
			this.Controls.Add(this.tsConnectionType);
			this.MinimumSize = new System.Drawing.Size(391, 0);
			this.Name = "MainForm";
			this.Text = "Network Thing";
			this.tsConnectionType.ResumeLayout(false);
			this.tabConnectionTypeTcp.ResumeLayout(false);
			this.tabConnectionTypeTcp.PerformLayout();
			this.tabConnectionTypeHTTP.ResumeLayout(false);
			this.tabConnectionTypeHTTP.PerformLayout();
			this.pnlConnections.ResumeLayout(false);
			this.pnlConnections.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tsConnectionType;
		private System.Windows.Forms.TabPage tabConnectionTypeTcp;
		private System.Windows.Forms.TabPage tabConnectionTypeHTTP;
		private System.Windows.Forms.Panel pnlConnections;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tbPortNum;
		private System.Windows.Forms.Label lblPortNum;
		private System.Windows.Forms.Label lblConnectTo;
		private System.Windows.Forms.TextBox tbConnectTo;
		private System.Windows.Forms.TextBox tbTCPSendString;
		private System.Windows.Forms.Label lblSendString;
		private System.Windows.Forms.Button btnSendMessage;
		private System.Windows.Forms.RichTextBox tbResponses;
		private System.Windows.Forms.Label lblResponse;
		private System.Windows.Forms.ComboBox cbConnections;
		private System.Windows.Forms.Label lblConnections;
		private System.Windows.Forms.Button btnAddConnection;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDeleteConnection;
	}
}

