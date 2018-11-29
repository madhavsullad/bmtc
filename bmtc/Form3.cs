using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bmtc
{
    public partial class Form3 : Form
    {
        public int selected;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchBus1.Show();
            searchBus1.BringToFront();
            selected = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            searchBus1.Hide();
            button3.Hide();
            button4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchBus1.Show();
            searchBus1.BringToFront();
            selected = 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchBus1.Show();
            searchBus1.BringToFront();
            selected = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchBus1.Show();
            searchBus1.BringToFront();
            selected = 3;

        }
    }
}
