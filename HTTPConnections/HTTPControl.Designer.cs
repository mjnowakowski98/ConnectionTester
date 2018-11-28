namespace HTTPConnections {
    partial class HTTPControl {
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
            this.cbConnectionMethod = new System.Windows.Forms.ComboBox();
            this.LblConnectionMethod = new System.Windows.Forms.Label();
            this.btnRequestHeaders = new System.Windows.Forms.Button();
            this.tbRequestData = new System.Windows.Forms.RichTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnClientHeaders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbConnectionMethod
            // 
            this.cbConnectionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConnectionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnectionMethod.FormattingEnabled = true;
            this.cbConnectionMethod.Items.AddRange(new object[] {
            "GET",
            "HEAD",
            "POST",
            "PUT",
            "DELETE",
            "CONNECT",
            "OPTIONS",
            "TRACE"});
            this.cbConnectionMethod.Location = new System.Drawing.Point(52, 5);
            this.cbConnectionMethod.Name = "cbConnectionMethod";
            this.cbConnectionMethod.Size = new System.Drawing.Size(124, 21);
            this.cbConnectionMethod.TabIndex = 0;
            // 
            // LblConnectionMethod
            // 
            this.LblConnectionMethod.AutoSize = true;
            this.LblConnectionMethod.Location = new System.Drawing.Point(3, 8);
            this.LblConnectionMethod.Name = "LblConnectionMethod";
            this.LblConnectionMethod.Size = new System.Drawing.Size(43, 13);
            this.LblConnectionMethod.TabIndex = 1;
            this.LblConnectionMethod.Text = "Method";
            // 
            // btnRequestHeaders
            // 
            this.btnRequestHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestHeaders.Location = new System.Drawing.Point(294, 3);
            this.btnRequestHeaders.Name = "btnRequestHeaders";
            this.btnRequestHeaders.Size = new System.Drawing.Size(106, 23);
            this.btnRequestHeaders.TabIndex = 2;
            this.btnRequestHeaders.Text = "Request Headers";
            this.btnRequestHeaders.UseVisualStyleBackColor = true;
            this.btnRequestHeaders.Click += new System.EventHandler(this.btnRequestHeaders_Click);
            // 
            // tbRequestData
            // 
            this.tbRequestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequestData.Location = new System.Drawing.Point(6, 56);
            this.tbRequestData.Name = "tbRequestData";
            this.tbRequestData.Size = new System.Drawing.Size(394, 151);
            this.tbRequestData.TabIndex = 3;
            this.tbRequestData.Text = "";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 40);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Request Payload";
            // 
            // btnClientHeaders
            // 
            this.btnClientHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientHeaders.Location = new System.Drawing.Point(182, 3);
            this.btnClientHeaders.Name = "btnClientHeaders";
            this.btnClientHeaders.Size = new System.Drawing.Size(106, 23);
            this.btnClientHeaders.TabIndex = 5;
            this.btnClientHeaders.Text = "Client Headers";
            this.btnClientHeaders.UseVisualStyleBackColor = true;
            this.btnClientHeaders.Click += new System.EventHandler(this.btnClientHeaders_Click);
            // 
            // HTTPControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClientHeaders);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbRequestData);
            this.Controls.Add(this.btnRequestHeaders);
            this.Controls.Add(this.LblConnectionMethod);
            this.Controls.Add(this.cbConnectionMethod);
            this.Name = "HTTPControl";
            this.Size = new System.Drawing.Size(404, 215);
            this.Load += new System.EventHandler(this.HTTPControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblConnectionMethod;
        private System.Windows.Forms.Button btnRequestHeaders;
        private System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.ComboBox cbConnectionMethod;
        internal System.Windows.Forms.RichTextBox tbRequestData;
		private System.Windows.Forms.Button btnClientHeaders;
	}
}
