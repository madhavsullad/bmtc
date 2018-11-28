namespace bmtc
{
    partial class editBusDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_busNo = new System.Windows.Forms.TextBox();
            this.txt_regNo = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_origin = new System.Windows.Forms.TextBox();
            this.txt_destn = new System.Windows.Forms.TextBox();
            this.txt_depot = new System.Windows.Forms.TextBox();
            this.txt_stat = new System.Windows.Forms.TextBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Bus by:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BUS No.",
            "Route No.",
            "Stop Area",
            "Reg. No."});
            this.comboBox1.Location = new System.Drawing.Point(292, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bus No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reg. No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Origin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Destination :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Depot :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Status :";
            // 
            // txt_busNo
            // 
            this.txt_busNo.Location = new System.Drawing.Point(292, 122);
            this.txt_busNo.Name = "txt_busNo";
            this.txt_busNo.Size = new System.Drawing.Size(121, 20);
            this.txt_busNo.TabIndex = 9;
            // 
            // txt_regNo
            // 
            this.txt_regNo.Location = new System.Drawing.Point(292, 163);
            this.txt_regNo.Name = "txt_regNo";
            this.txt_regNo.Size = new System.Drawing.Size(121, 20);
            this.txt_regNo.TabIndex = 10;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(292, 199);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(121, 20);
            this.txt_type.TabIndex = 11;
            // 
            // txt_origin
            // 
            this.txt_origin.Location = new System.Drawing.Point(292, 234);
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.Size = new System.Drawing.Size(121, 20);
            this.txt_origin.TabIndex = 12;
            // 
            // txt_destn
            // 
            this.txt_destn.Location = new System.Drawing.Point(292, 271);
            this.txt_destn.Name = "txt_destn";
            this.txt_destn.Size = new System.Drawing.Size(121, 20);
            this.txt_destn.TabIndex = 13;
            // 
            // txt_depot
            // 
            this.txt_depot.Location = new System.Drawing.Point(292, 308);
            this.txt_depot.Name = "txt_depot";
            this.txt_depot.Size = new System.Drawing.Size(121, 20);
            this.txt_depot.TabIndex = 14;
            // 
            // txt_stat
            // 
            this.txt_stat.Location = new System.Drawing.Point(292, 348);
            this.txt_stat.Name = "txt_stat";
            this.txt_stat.Size = new System.Drawing.Size(121, 20);
            this.txt_stat.TabIndex = 15;
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(225, 403);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(124, 51);
            this.btn_fetch.TabIndex = 16;
            this.btn_fetch.Text = "Fetch";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "BUS Details";
            // 
            // editBusDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.txt_stat);
            this.Controls.Add(this.txt_depot);
            this.Controls.Add(this.txt_destn);
            this.Controls.Add(this.txt_origin);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_regNo);
            this.Controls.Add(this.txt_busNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "editBusDetails";
            this.Size = new System.Drawing.Size(574, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_busNo;
        private System.Windows.Forms.TextBox txt_regNo;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_origin;
        private System.Windows.Forms.TextBox txt_destn;
        private System.Windows.Forms.TextBox txt_depot;
        private System.Windows.Forms.TextBox txt_stat;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label label9;
    }
}
