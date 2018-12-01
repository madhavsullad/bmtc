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
    public partial class addBus : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");

        public addBus()
        {
            InitializeComponent();
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into bus values('" + txt_reg1.Text + "','" + txt_bus1.Text + "','" + txt_type1.Text + "','" + txt_origin1.Text + "','" + txt_dest1.Text + "','" + txt_depot1.Text + "','" + txt_stat1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
