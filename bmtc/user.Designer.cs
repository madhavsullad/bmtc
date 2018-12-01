namespace bmtc
{
    partial class user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_busNo = new System.Windows.Forms.Button();
            this.btn_routeNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_busNo
            // 
            this.btn_busNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_busNo.Location = new System.Drawing.Point(223, 180);
            this.btn_busNo.Name = "btn_busNo";
            this.btn_busNo.Size = new System.Drawing.Size(130, 50);
            this.btn_busNo.TabIndex = 0;
            this.btn_busNo.Text = "Search by Bus No";
            this.btn_busNo.UseVisualStyleBackColor = true;
            this.btn_busNo.Click += new System.EventHandler(this.btn_busNo_Click);
            // 
            // btn_routeNo
            // 
            this.btn_routeNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_routeNo.Location = new System.Drawing.Point(223, 274);
            this.btn_routeNo.Name = "btn_routeNo";
            this.btn_routeNo.Size = new System.Drawing.Size(130, 50);
            this.btn_routeNo.TabIndex = 1;
            this.btn_routeNo.Text = "Search by Route No";
            this.btn_routeNo.UseVisualStyleBackColor = true;
            this.btn_routeNo.Click += new System.EventHandler(this.btn_routeNo_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 505);
            this.Controls.Add(this.btn_routeNo);
            this.Controls.Add(this.btn_busNo);
            this.Name = "user";
            this.Text = "user";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_busNo;
        private System.Windows.Forms.Button btn_routeNo;
    }
}