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
			this.connectionHostContainer = new System.Windows.Forms.Panel();
			this.tbPortNum = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.tbHostName = new System.Windows.Forms.TextBox();
			this.lblHostName = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.connectionsListContainer = new System.Windows.Forms.Panel();
			this.lblConnectionsList = new System.Windows.Forms.Label();
			this.cbConnections = new System.Windows.Forms.ComboBox();
			this.btnNewConnection = new System.Windows.Forms.Button();
			this.btnRemoveConnection = new System.Windows.Forms.Button();
			this.tsConnectionLibs = new System.Windows.Forms.TabControl();
			this.outputContainer = new System.Windows.Forms.Panel();
			this.lblLog = new System.Windows.Forms.Label();
			this.tbLog = new System.Windows.Forms.RichTextBox();
			this.connectionHostContainer.SuspendLayout();
			this.connectionsListContainer.SuspendLayout();
			this.outputContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// connectionHostContainer
			// 
			this.connectionHostContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connectionHostContainer.Controls.Add(this.btnUpdate);
			this.connectionHostContainer.Controls.Add(this.btnDisconnect);
			this.connectionHostContainer.Controls.Add(this.btnConnect);
			this.connectionHostContainer.Controls.Add(this.tbPortNum);
			this.connectionHostContainer.Controls.Add(this.lblPort);
			this.connectionHostContainer.Controls.Add(this.tbHostName);
			this.connectionHostContainer.Controls.Add(this.lblHostName);
			this.connectionHostContainer.Location = new System.Drawing.Point(0, 0);
			this.connectionHostContainer.Name = "connectionHostContainer";
			this.connectionHostContainer.Size = new System.Drawing.Size(375, 71);
			this.connectionHostContainer.TabIndex = 0;
			// 
			// tbPortNum
			// 
			this.tbPortNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPortNum.Location = new System.Drawing.Point(47, 38);
			this.tbPortNum.Name = "tbPortNum";
			this.tbPortNum.Size = new System.Drawing.Size(73, 20);
			this.tbPortNum.TabIndex = 3;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(12, 41);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(26, 13);
			this.lblPort.TabIndex = 2;
			this.lblPort.Text = "Port";
			// 
			// tbHostName
			// 
			this.tbHostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbHostName.Location = new System.Drawing.Point(47, 12);
			this.tbHostName.Name = "tbHostName";
			this.tbHostName.Size = new System.Drawing.Size(316, 20);
			this.tbHostName.TabIndex = 1;
			// 
			// lblHostName
			// 
			this.lblHostName.AutoSize = true;
			this.lblHostName.Location = new System.Drawing.Point(12, 15);
			this.lblHostName.Name = "lblHostName";
			this.lblHostName.Size = new System.Drawing.Size(29, 13);
			this.lblHostName.TabIndex = 0;
			this.lblHostName.Text = "Host";
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnect.Location = new System.Drawing.Point(126, 36);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisconnect.Location = new System.Drawing.Point(207, 36);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(288, 36);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// connectionsListContainer
			// 
			this.connectionsListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.connectionsListContainer.Controls.Add(this.btnRemoveConnection);
			this.connectionsListContainer.Controls.Add(this.btnNewConnection);
			this.connectionsListContainer.Controls.Add(this.cbConnections);
			this.connectionsListContainer.Controls.Add(this.lblConnectionsList);
			this.connectionsListContainer.Location = new System.Drawing.Point(0, 77);
			this.connectionsListContainer.Name = "connectionsListContainer";
			this.connectionsListContainer.Size = new System.Drawing.Size(375, 37);
			this.connectionsListContainer.TabIndex = 1;
			// 
			// lblConnectionsList
			// 
			this.lblConnectionsList.AutoSize = true;
			this.lblConnectionsList.Location = new System.Drawing.Point(12, 6);
			this.lblConnectionsList.Name = "lblConnectionsList";
			this.lblConnectionsList.Size = new System.Drawing.Size(66, 13);
			this.lblConnectionsList.TabIndex = 0;
			this.lblConnectionsList.Text = "Connections";
			// 
			// cbConnections
			// 
			this.cbConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConnections.FormattingEnabled = true;
			this.cbConnections.Location = new System.Drawing.Point(84, 3);
			this.cbConnections.MaxDropDownItems = 50;
			this.cbConnections.Name = "cbConnections";
			this.cbConnections.Size = new System.Drawing.Size(117, 21);
			this.cbConnections.TabIndex = 1;
			// 
			// btnNewConnection
			// 
			this.btnNewConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewConnection.Location = new System.Drawing.Point(207, 3);
			this.btnNewConnection.Name = "btnNewConnection";
			this.btnNewConnection.Size = new System.Drawing.Size(75, 23);
			this.btnNewConnection.TabIndex = 2;
			this.btnNewConnection.Text = "New";
			this.btnNewConnection.UseVisualStyleBackColor = true;
			// 
			// btnRemoveConnection
			// 
			this.btnRemoveConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveConnection.Location = new System.Drawing.Point(288, 3);
			this.btnRemoveConnection.Name = "btnRemoveConnection";
			this.btnRemoveConnection.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveConnection.TabIndex = 3;
			this.btnRemoveConnection.Text = "Remove";
			this.btnRemoveConnection.UseVisualStyleBackColor = true;
			// 
			// tsConnectionLibs
			// 
			this.tsConnectionLibs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsConnectionLibs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tsConnectionLibs.Location = new System.Drawing.Point(0, 120);
			this.tsConnectionLibs.Name = "tsConnectionLibs";
			this.tsConnectionLibs.SelectedIndex = 0;
			this.tsConnectionLibs.Size = new System.Drawing.Size(375, 178);
			this.tsConnectionLibs.TabIndex = 2;
			// 
			// outputContainer
			// 
			this.outputContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputContainer.Controls.Add(this.tbLog);
			this.outputContainer.Controls.Add(this.lblLog);
			this.outputContainer.Location = new System.Drawing.Point(0, 304);
			this.outputContainer.Name = "outputContainer";
			this.outputContainer.Size = new System.Drawing.Size(375, 138);
			this.outputContainer.TabIndex = 3;
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Location = new System.Drawing.Point(6, 0);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(25, 13);
			this.lblLog.TabIndex = 0;
			this.lblLog.Text = "Log";
			// 
			// tbLog
			// 
			this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLog.Location = new System.Drawing.Point(0, 16);
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.Size = new System.Drawing.Size(375, 122);
			this.tbLog.TabIndex = 1;
			this.tbLog.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 440);
			this.Controls.Add(this.outputContainer);
			this.Controls.Add(this.tsConnectionLibs);
			this.Controls.Add(this.connectionsListContainer);
			this.Controls.Add(this.connectionHostContainer);
			this.MinimumSize = new System.Drawing.Size(391, 479);
			this.Name = "MainForm";
			this.Text = "Network Thing";
			this.connectionHostContainer.ResumeLayout(false);
			this.connectionHostContainer.PerformLayout();
			this.connectionsListContainer.ResumeLayout(false);
			this.connectionsListContainer.PerformLayout();
			this.outputContainer.ResumeLayout(false);
			this.outputContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel connectionHostContainer;
		private System.Windows.Forms.TextBox tbPortNum;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox tbHostName;
		private System.Windows.Forms.Label lblHostName;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Panel connectionsListContainer;
		private System.Windows.Forms.ComboBox cbConnections;
		private System.Windows.Forms.Label lblConnectionsList;
		private System.Windows.Forms.Button btnRemoveConnection;
		private System.Windows.Forms.Button btnNewConnection;
		private System.Windows.Forms.TabControl tsConnectionLibs;
		private System.Windows.Forms.Panel outputContainer;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.RichTextBox tbLog;
	}
}

