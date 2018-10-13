namespace TCPConnections {
	partial class TCPControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblSendString = new System.Windows.Forms.Label();
			this.tbSendString = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblSendString
			// 
			this.lblSendString.AutoSize = true;
			this.lblSendString.Location = new System.Drawing.Point(0, 7);
			this.lblSendString.Name = "lblSendString";
			this.lblSendString.Size = new System.Drawing.Size(66, 13);
			this.lblSendString.TabIndex = 0;
			this.lblSendString.Text = "Send string: ";
			// 
			// tbSendString
			// 
			this.tbSendString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSendString.Location = new System.Drawing.Point(3, 23);
			this.tbSendString.Name = "tbSendString";
			this.tbSendString.Size = new System.Drawing.Size(288, 20);
			this.tbSendString.TabIndex = 1;
			// 
			// TCPControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbSendString);
			this.Controls.Add(this.lblSendString);
			this.Name = "TCPControl";
			this.Size = new System.Drawing.Size(294, 51);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSendString;
		private System.Windows.Forms.TextBox tbSendString;
	}
}
