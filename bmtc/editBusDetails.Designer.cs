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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_busNo = new System.Windows.Forms.TextBox();
            this.txt_regNo = new System.Windows.Forms.TextBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Bus by:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BUS No.",
            "Reg. No."});
            this.comboBox1.Location = new System.Drawing.Point(164, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bus No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reg. No. :";
            // 
            // txt_busNo
            // 
            this.txt_busNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busNo.Location = new System.Drawing.Point(374, 74);
            this.txt_busNo.Name = "txt_busNo";
            this.txt_busNo.Size = new System.Drawing.Size(121, 20);
            this.txt_busNo.TabIndex = 9;
            // 
            // txt_regNo
            // 
            this.txt_regNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regNo.Location = new System.Drawing.Point(374, 74);
            this.txt_regNo.Name = "txt_regNo";
            this.txt_regNo.Size = new System.Drawing.Size(121, 20);
            this.txt_regNo.TabIndex = 10;
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(225, 420);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 294);
            this.dataGridView1.TabIndex = 18;
            // 
            // editBusDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.txt_regNo);
            this.Controls.Add(this.txt_busNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "editBusDetails";
            this.Size = new System.Drawing.Size(574, 501);
            this.Load += new System.EventHandler(this.editBusDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_busNo;
        private System.Windows.Forms.TextBox txt_regNo;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
