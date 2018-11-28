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
            if (comboBox1.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from bus where busNo = '" + txt_busNo.Text.ToUpper() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txt_regNo.Text = dt.Rows[0]["regNo"].ToString();
                txt_type.Text = dt.Rows[0]["type"].ToString();
                txt_stat.Text = dt.Rows[0]["status"].ToString();
                txt_origin.Text = dt.Rows[0]["origin"].ToString();
                txt_destn.Text = dt.Rows[0]["destination"].ToString();
                txt_depot.Text = dt.Rows[0]["depot"].ToString();
            }
        }
    }
}
