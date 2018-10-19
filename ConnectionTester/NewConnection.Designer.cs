namespace ConnectionTester {
	partial class NewConnection {
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
			this.lblHostname = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.tbConnectionName = new System.Windows.Forms.TextBox();
			this.tbHostName = new System.Windows.Forms.TextBox();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblHostname
			// 
			this.lblHostname.AutoSize = true;
			this.lblHostname.Location = new System.Drawing.Point(12, 41);
			this.lblHostname.Name = "lblHostname";
			this.lblHostname.Size = new System.Drawing.Size(29, 13);
			this.lblHostname.TabIndex = 0;
			this.lblHostname.Text = "Host";
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(15, 67);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(26, 13);
			this.lblPort.TabIndex = 1;
			this.lblPort.Text = "Port";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 15);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name";
			// 
			// tbConnectionName
			// 
			this.tbConnectionName.Location = new System.Drawing.Point(53, 12);
			this.tbConnectionName.Name = "tbConnectionName";
			this.tbConnectionName.Size = new System.Drawing.Size(172, 20);
			this.tbConnectionName.TabIndex = 3;
			// 
			// tbHostName
			// 
			this.tbHostName.Location = new System.Drawing.Point(53, 38);
			this.tbHostName.Name = "tbHostName";
			this.tbHostName.Size = new System.Drawing.Size(172, 20);
			this.tbHostName.TabIndex = 4;
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(53, 64);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(67, 20);
			this.tbPort.TabIndex = 5;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(47, 102);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(128, 102);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// NewConnection
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(239, 139);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbPort);
			this.Controls.Add(this.tbHostName);
			this.Controls.Add(this.tbConnectionName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblHostname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewConnection";
			this.Text = "New Connection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHostname;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbConnectionName;
		private System.Windows.Forms.TextBox tbHostName;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}