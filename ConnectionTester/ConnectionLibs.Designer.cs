namespace ConnectionTester {
	partial class ConnectionLibs {
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
			this.lbLibNames = new System.Windows.Forms.ListBox();
			this.btnAddLib = new System.Windows.Forms.Button();
			this.tbAddLibName = new System.Windows.Forms.TextBox();
			this.btnRemoveLib = new System.Windows.Forms.Button();
			this.lblLibName = new System.Windows.Forms.Label();
			this.fbdLibPath = new System.Windows.Forms.FolderBrowserDialog();
			this.lblLibDir = new System.Windows.Forms.Label();
			this.tbLibDir = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.cbReload = new System.Windows.Forms.CheckBox();
			this.tbAddLibAssembly = new System.Windows.Forms.TextBox();
			this.lblLibAssembly = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbLibNames
			// 
			this.lbLibNames.FormattingEnabled = true;
			this.lbLibNames.Location = new System.Drawing.Point(12, 12);
			this.lbLibNames.Name = "lbLibNames";
			this.lbLibNames.Size = new System.Drawing.Size(260, 108);
			this.lbLibNames.TabIndex = 0;
			// 
			// btnAddLib
			// 
			this.btnAddLib.Location = new System.Drawing.Point(12, 204);
			this.btnAddLib.Name = "btnAddLib";
			this.btnAddLib.Size = new System.Drawing.Size(75, 23);
			this.btnAddLib.TabIndex = 1;
			this.btnAddLib.Text = "Add";
			this.btnAddLib.UseVisualStyleBackColor = true;
			this.btnAddLib.Click += new System.EventHandler(this.btnAddLib_Click);
			// 
			// tbAddLibName
			// 
			this.tbAddLibName.Location = new System.Drawing.Point(12, 178);
			this.tbAddLibName.Name = "tbAddLibName";
			this.tbAddLibName.Size = new System.Drawing.Size(75, 20);
			this.tbAddLibName.TabIndex = 2;
			// 
			// btnRemoveLib
			// 
			this.btnRemoveLib.Location = new System.Drawing.Point(93, 204);
			this.btnRemoveLib.Name = "btnRemoveLib";
			this.btnRemoveLib.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveLib.TabIndex = 3;
			this.btnRemoveLib.Text = "Remove";
			this.btnRemoveLib.UseVisualStyleBackColor = true;
			this.btnRemoveLib.Click += new System.EventHandler(this.btnRemoveLib_Click);
			// 
			// lblLibName
			// 
			this.lblLibName.AutoSize = true;
			this.lblLibName.Location = new System.Drawing.Point(12, 162);
			this.lblLibName.Name = "lblLibName";
			this.lblLibName.Size = new System.Drawing.Size(35, 13);
			this.lblLibName.TabIndex = 5;
			this.lblLibName.Text = "Name";
			// 
			// lblLibDir
			// 
			this.lblLibDir.AutoSize = true;
			this.lblLibDir.Location = new System.Drawing.Point(12, 123);
			this.lblLibDir.Name = "lblLibDir";
			this.lblLibDir.Size = new System.Drawing.Size(84, 13);
			this.lblLibDir.TabIndex = 6;
			this.lblLibDir.Text = "Search directory";
			// 
			// tbLibDir
			// 
			this.tbLibDir.Location = new System.Drawing.Point(12, 139);
			this.tbLibDir.Name = "tbLibDir";
			this.tbLibDir.Size = new System.Drawing.Size(179, 20);
			this.tbLibDir.TabIndex = 7;
			this.tbLibDir.TextChanged += new System.EventHandler(this.tbLibDir_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(197, 137);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 8;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// cbReload
			// 
			this.cbReload.AutoSize = true;
			this.cbReload.Checked = true;
			this.cbReload.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbReload.Location = new System.Drawing.Point(212, 208);
			this.cbReload.Name = "cbReload";
			this.cbReload.Size = new System.Drawing.Size(60, 17);
			this.cbReload.TabIndex = 9;
			this.cbReload.Text = "Reload";
			this.cbReload.UseVisualStyleBackColor = true;
			// 
			// tbAddLibAssembly
			// 
			this.tbAddLibAssembly.Location = new System.Drawing.Point(93, 178);
			this.tbAddLibAssembly.Name = "tbAddLibAssembly";
			this.tbAddLibAssembly.Size = new System.Drawing.Size(179, 20);
			this.tbAddLibAssembly.TabIndex = 10;
			// 
			// lblLibAssembly
			// 
			this.lblLibAssembly.AutoSize = true;
			this.lblLibAssembly.Location = new System.Drawing.Point(90, 162);
			this.lblLibAssembly.Name = "lblLibAssembly";
			this.lblLibAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblLibAssembly.TabIndex = 11;
			this.lblLibAssembly.Text = "Assembly";
			// 
			// ConnectionLibs
			// 
			this.AcceptButton = this.btnAddLib;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 236);
			this.Controls.Add(this.lblLibAssembly);
			this.Controls.Add(this.tbAddLibAssembly);
			this.Controls.Add(this.cbReload);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.tbLibDir);
			this.Controls.Add(this.lblLibDir);
			this.Controls.Add(this.lblLibName);
			this.Controls.Add(this.btnRemoveLib);
			this.Controls.Add(this.tbAddLibName);
			this.Controls.Add(this.btnAddLib);
			this.Controls.Add(this.lbLibNames);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 275);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 275);
			this.Name = "ConnectionLibs";
			this.Text = "Connection Libraries";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionLibs_FormClosing);
			this.Load += new System.EventHandler(this.ConnectionLibs_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbLibNames;
		private System.Windows.Forms.Button btnAddLib;
		private System.Windows.Forms.TextBox tbAddLibName;
		private System.Windows.Forms.Button btnRemoveLib;
		private System.Windows.Forms.Label lblLibName;
		private System.Windows.Forms.FolderBrowserDialog fbdLibPath;
		private System.Windows.Forms.Label lblLibDir;
		private System.Windows.Forms.TextBox tbLibDir;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.CheckBox cbReload;
		private System.Windows.Forms.TextBox tbAddLibAssembly;
		private System.Windows.Forms.Label lblLibAssembly;
	}
}