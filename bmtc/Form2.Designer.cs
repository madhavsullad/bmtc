namespace bmtc
{
    partial class Form2
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
            this.editUsers = new System.Windows.Forms.Button();
            this.editEmp = new System.Windows.Forms.Button();
            this.editBus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editEmployeeDetails1 = new bmtc.editEmployeeDetails();
            this.editUsers1 = new bmtc.editUsers();
            this.editBusDetails1 = new bmtc.editBusDetails();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editUsers
            // 
            this.editUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editUsers.Location = new System.Drawing.Point(0, 27);
            this.editUsers.Name = "editUsers";
            this.editUsers.Size = new System.Drawing.Size(192, 42);
            this.editUsers.TabIndex = 0;
            this.editUsers.Text = "Edit Users";
            this.editUsers.UseVisualStyleBackColor = true;
            this.editUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // editEmp
            // 
            this.editEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editEmp.Location = new System.Drawing.Point(0, 90);
            this.editEmp.Name = "editEmp";
            this.editEmp.Size = new System.Drawing.Size(192, 42);
            this.editEmp.TabIndex = 1;
            this.editEmp.Text = "Edit Employee Details";
            this.editEmp.UseVisualStyleBackColor = true;
            this.editEmp.Click += new System.EventHandler(this.button2_Click);
            // 
            // editBus
            // 
            this.editBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBus.Location = new System.Drawing.Point(0, 153);
            this.editBus.Name = "editBus";
            this.editBus.Size = new System.Drawing.Size(192, 42);
            this.editBus.TabIndex = 2;
            this.editBus.Text = "Edit Bus Details";
            this.editBus.UseVisualStyleBackColor = true;
            this.editBus.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.editUsers);
            this.panel1.Controls.Add(this.editBus);
            this.panel1.Controls.Add(this.editEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 501);
            this.panel1.TabIndex = 3;
            // 
            // editEmployeeDetails1
            // 
            this.editEmployeeDetails1.Location = new System.Drawing.Point(198, 0);
            this.editEmployeeDetails1.Name = "editEmployeeDetails1";
            this.editEmployeeDetails1.Size = new System.Drawing.Size(574, 501);
            this.editEmployeeDetails1.TabIndex = 0;
            // 
            // editUsers1
            // 
            this.editUsers1.Location = new System.Drawing.Point(198, 0);
            this.editUsers1.Name = "editUsers1";
            this.editUsers1.Size = new System.Drawing.Size(574, 501);
            this.editUsers1.TabIndex = 4;
            // 
            // editBusDetails1
            // 
            this.editBusDetails1.Location = new System.Drawing.Point(195, 0);
            this.editBusDetails1.Name = "editBusDetails1";
            this.editBusDetails1.Size = new System.Drawing.Size(574, 501);
            this.editBusDetails1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 501);
            this.Controls.Add(this.editBusDetails1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editEmployeeDetails1);
            this.Controls.Add(this.editUsers1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMTC BUS MANAGEMENT SYSTEM (Admin Portal)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editUsers;
        private System.Windows.Forms.Button editEmp;
        private System.Windows.Forms.Button editBus;
        private System.Windows.Forms.Panel panel1;
        private editUsers editUsers1;
        private editEmployeeDetails editEmployeeDetails1;
        private editBusDetails editBusDetails1;
    }
}