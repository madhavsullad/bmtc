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
    public partial class editBusDetails : UserControl
    {
        public editBusDetails()
        {
            InitializeComponent();
        }
        private void btn_fetch_Click(object sender, EventArgs e)
        {
            btn_fetch.Text = "Update";
            if (comboBox1.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from bus where busNo = '" + txt_busNo.Text.ToUpper() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from bus where regNo = '" + txt_regNo.Text.ToUpper() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Show();
                txt_busNo.Show();
                label3.Hide();
                txt_regNo.Hide();
            }
            else
            {
                label3.Show();
                txt_regNo.Show();
                label2.Hide();
                txt_busNo.Hide();
            }
        }

        private void editBusDetails_Load(object sender, EventArgs e)
        {
            label3.Hide();
            txt_regNo.Hide();
            label2.Hide();
            txt_busNo.Hide();

        }
    }
}
