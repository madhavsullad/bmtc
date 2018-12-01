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
    public partial class search : Form
    {
        string sel;
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            user u = new user();
            lbl_bus.Hide();
            lbl_route.Hide();
            if(u.s == 0)
            {
                lbl_bus.Show();
                sel = "busNo";
            }
            else
            {
                lbl_route.Show();
                sel = "routeNo";
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from bus where "+sel+" = '" + txt_id.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
