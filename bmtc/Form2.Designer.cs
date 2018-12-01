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
            this.addUser = new System.Windows.Forms.Button();
            this.addBus = new System.Windows.Forms.Button();
            this.addEmp = new System.Windows.Forms.Button();
            this.addUser1 = new bmtc.addUser();
            this.addBus1 = new bmtc.addBus();
            this.editBusDetails1 = new bmtc.editBusDetails();
            this.editEmployeeDetails1 = new bmtc.editEmployeeDetails();
            this.editUsers1 = new bmtc.editUsers();
            this.addEmp1 = new bmtc.addEmp();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editUsers
            // 
            this.editUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editUsers.Location = new System.Drawing.Point(0, 286);
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
            this.editEmp.Location = new System.Drawing.Point(0, 349);
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
            this.editBus.Location = new System.Drawing.Point(0, 412);
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
            this.panel1.Controls.Add(this.addUser);
            this.panel1.Controls.Add(this.addBus);
            this.panel1.Controls.Add(this.addEmp);
            this.panel1.Controls.Add(this.editUsers);
            this.panel1.Controls.Add(this.editBus);
            this.panel1.Controls.Add(this.editEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 501);
            this.panel1.TabIndex = 3;
            // 
            // addUser
            // 
            this.addUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUser.Location = new System.Drawing.Point(0, 41);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(192, 42);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Add Users";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // addBus
            // 
            this.addBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBus.Location = new System.Drawing.Point(0, 167);
            this.addBus.Name = "addBus";
            this.addBus.Size = new System.Drawing.Size(192, 42);
            this.addBus.TabIndex = 5;
            this.addBus.Text = "Add Bus Details";
            this.addBus.UseVisualStyleBackColor = true;
            this.addBus.Click += new System.EventHandler(this.addBus_Click);
            // 
            // addEmp
            // 
            this.addEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmp.Location = new System.Drawing.Point(0, 104);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(192, 42);
            this.addEmp.TabIndex = 4;
            this.addEmp.Text = "Add Employee Details";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // addUser1
            // 
            this.addUser1.Location = new System.Drawing.Point(194, 0);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(574, 501);
            this.addUser1.TabIndex = 7;
            // 
            // addBus1
            // 
            this.addBus1.Location = new System.Drawing.Point(194, 0);
            this.addBus1.Name = "addBus1";
            this.addBus1.Size = new System.Drawing.Size(574, 501);
            this.addBus1.TabIndex = 6;
            // 
            // editBusDetails1
            // 
            this.editBusDetails1.Location = new System.Drawing.Point(195, 0);
            this.editBusDetails1.Name = "editBusDetails1";
            this.editBusDetails1.Size = new System.Drawing.Size(574, 501);
            this.editBusDetails1.TabIndex = 5;
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
            // addEmp1
            // 
            this.addEmp1.Location = new System.Drawing.Point(194, 0);
            this.addEmp1.Name = "addEmp1";
            this.addEmp1.Size = new System.Drawing.Size(574, 501);
            this.addEmp1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 501);
            this.Controls.Add(this.addEmp1);
            this.Controls.Add(this.addUser1);
            this.Controls.Add(this.addBus1);
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
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addBus;
        private System.Windows.Forms.Button addEmp;
        private addBus addBus1;
        private addUser addUser1;
        private addEmp addEmp1;
    }
}