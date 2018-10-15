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
			this.pnlConnections = new System.Windows.Forms.Panel();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbPortNum = new System.Windows.Forms.TextBox();
			this.lblPortNum = new System.Windows.Forms.Label();
			this.lblConnectTo = new System.Windows.Forms.Label();
			this.tbConnectTo = new System.Windows.Forms.TextBox();
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.tbResponses = new System.Windows.Forms.RichTextBox();
			this.lblResponse = new System.Windows.Forms.Label();
			this.cbConnections = new System.Windows.Forms.ComboBox();
			this.lblConnections = new System.Windows.Forms.Label();
			this.btnAddConnection = new System.Windows.Forms.Button();
			this.btnDeleteConnection = new System.Windows.Forms.Button();
			this.btnConnectionLibs = new System.Windows.Forms.Button();
			this.pnlConnections.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsConnectionType
			// 
			this.tsConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsConnectionType.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tsConnectionType.Location = new System.Drawing.Point(0, 102);
			this.tsConnectionType.Name = "tsConnectionType";
			this.tsConnectionType.SelectedIndex = 0;
			this.tsConnectionType.Size = new System.Drawing.Size(375, 116);
			this.tsConnectionType.TabIndex = 0;
			this.tsConnectionType.SelectedIndexChanged += new System.EventHandler(this.tsConnectionType_SelectedIndexChanged);
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
			this.tbConnectTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbConnectTo.Location = new System.Drawing.Point(47, 12);
			this.tbConnectTo.Name = "tbConnectTo";
			this.tbConnectTo.Size = new System.Drawing.Size(316, 20);
			this.tbConnectTo.TabIndex = 0;
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSendMessage.Location = new System.Drawing.Point(12, 220);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(89, 23);
			this.btnSendMessage.TabIndex = 6;
			this.btnSendMessage.Text = "Send";
			this.btnSendMessage.UseVisualStyleBackColor = true;
			this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
			// 
			// tbResponses
			// 
			this.tbResponses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResponses.Location = new System.Drawing.Point(4, 266);
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
			this.lblResponse.Location = new System.Drawing.Point(3, 250);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(60, 13);
			this.lblResponse.TabIndex = 3;
			this.lblResponse.Text = "Responses";
			// 
			// cbConnections
			// 
			this.cbConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbConnections.FormattingEnabled = true;
			this.cbConnections.Location = new System.Drawing.Point(84, 75);
			this.cbConnections.Name = "cbConnections";
			this.cbConnections.Size = new System.Drawing.Size(117, 21);
			this.cbConnections.TabIndex = 4;
			this.cbConnections.SelectedIndexChanged += new System.EventHandler(this.cbConnections_SelectedIndexChanged);
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
			this.btnAddConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddConnection.Location = new System.Drawing.Point(207, 73);
			this.btnAddConnection.Name = "btnAddConnection";
			this.btnAddConnection.Size = new System.Drawing.Size(75, 23);
			this.btnAddConnection.TabIndex = 6;
			this.btnAddConnection.Text = "New";
			this.btnAddConnection.UseVisualStyleBackColor = true;
			this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
			// 
			// btnDeleteConnection
			// 
			this.btnDeleteConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteConnection.Location = new System.Drawing.Point(288, 73);
			this.btnDeleteConnection.Name = "btnDeleteConnection";
			this.btnDeleteConnection.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteConnection.TabIndex = 7;
			this.btnDeleteConnection.Text = "Remove";
			this.btnDeleteConnection.UseVisualStyleBackColor = true;
			// 
			// btnConnectionLibs
			// 
			this.btnConnectionLibs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnectionLibs.Location = new System.Drawing.Point(233, 220);
			this.btnConnectionLibs.Name = "btnConnectionLibs";
			this.btnConnectionLibs.Size = new System.Drawing.Size(130, 23);
			this.btnConnectionLibs.TabIndex = 8;
			this.btnConnectionLibs.Text = "Connection Libraries";
			this.btnConnectionLibs.UseVisualStyleBackColor = true;
			this.btnConnectionLibs.Click += new System.EventHandler(this.btnConnectionLibs_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 440);
			this.Controls.Add(this.btnConnectionLibs);
			this.Controls.Add(this.btnDeleteConnection);
			this.Controls.Add(this.btnAddConnection);
			this.Controls.Add(this.btnSendMessage);
			this.Controls.Add(this.lblConnections);
			this.Controls.Add(this.cbConnections);
			this.Controls.Add(this.lblResponse);
			this.Controls.Add(this.tbResponses);
			this.Controls.Add(this.pnlConnections);
			this.Controls.Add(this.tsConnectionType);
			this.MinimumSize = new System.Drawing.Size(391, 479);
			this.Name = "MainForm";
			this.Text = "Network Thing";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.pnlConnections.ResumeLayout(false);
			this.pnlConnections.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tsConnectionType;
		private System.Windows.Forms.Panel pnlConnections;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tbPortNum;
		private System.Windows.Forms.Label lblPortNum;
		private System.Windows.Forms.Label lblConnectTo;
		private System.Windows.Forms.TextBox tbConnectTo;
		private System.Windows.Forms.Button btnSendMessage;
		private System.Windows.Forms.RichTextBox tbResponses;
		private System.Windows.Forms.Label lblResponse;
		private System.Windows.Forms.ComboBox cbConnections;
		private System.Windows.Forms.Label lblConnections;
		private System.Windows.Forms.Button btnAddConnection;
		private System.Windows.Forms.Button btnDeleteConnection;
		private System.Windows.Forms.Button btnConnectionLibs;
	}
}

