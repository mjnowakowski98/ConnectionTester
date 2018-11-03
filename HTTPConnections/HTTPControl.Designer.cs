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
            this.btnHeaders = new System.Windows.Forms.Button();
            this.tbRequestData = new System.Windows.Forms.RichTextBox();
            this.lblData = new System.Windows.Forms.Label();
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
            this.cbConnectionMethod.Size = new System.Drawing.Size(113, 21);
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
            // btnHeaders
            // 
            this.btnHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaders.Location = new System.Drawing.Point(171, 3);
            this.btnHeaders.Name = "btnHeaders";
            this.btnHeaders.Size = new System.Drawing.Size(75, 23);
            this.btnHeaders.TabIndex = 2;
            this.btnHeaders.Text = "Headers...";
            this.btnHeaders.UseVisualStyleBackColor = true;
            // 
            // tbRequestData
            // 
            this.tbRequestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequestData.Location = new System.Drawing.Point(6, 56);
            this.tbRequestData.Name = "tbRequestData";
            this.tbRequestData.Size = new System.Drawing.Size(240, 90);
            this.tbRequestData.TabIndex = 3;
            this.tbRequestData.Text = "";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 40);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Request Data";
            // 
            // HTTPControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbRequestData);
            this.Controls.Add(this.btnHeaders);
            this.Controls.Add(this.LblConnectionMethod);
            this.Controls.Add(this.cbConnectionMethod);
            this.Name = "HTTPControl";
            this.Size = new System.Drawing.Size(250, 154);
            this.Load += new System.EventHandler(this.HTTPControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblConnectionMethod;
        private System.Windows.Forms.Button btnHeaders;
        private System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.ComboBox cbConnectionMethod;
        internal System.Windows.Forms.RichTextBox tbRequestData;
    }
}
