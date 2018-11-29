using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bmtc
{
    public partial class searchBus : UserControl
    {
        Form3 form3 = new Form3();
        String sel;
        public searchBus()
        {
            InitializeComponent();
        }

        private void searchBus_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();

            if (form3.selected == 0)
            {
                label2.Show();
                sel = "busNo";
            }
            else if (form3.selected == 1)
            {
                label3.Show();
                sel = "regNo";
            }
            else if (form3.selected == 2)
            {
                label4.Show();
            }
            else if (form3.selected == 3)
            {
                label5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from bus where '"+sel+"' = '" + textBox1.Text.ToString() + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
