using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmtc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editBusDetails1.Hide();
            editEmployeeDetails1.Hide();
            editUsers1.Show();
            editUsers1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editBusDetails1.Hide();
            editUsers1.Hide();
            editEmployeeDetails1.Show();
            editEmployeeDetails1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editEmployeeDetails1.Hide();
            editUsers1.Hide();
            editBusDetails1.Show();
            editBusDetails1.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            editEmployeeDetails1.Hide();
            editUsers1.Hide();
            editBusDetails1.Hide();
        }
    }
}
