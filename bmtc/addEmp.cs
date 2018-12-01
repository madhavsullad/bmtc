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
    public partial class addEmp : UserControl
    {
        public addEmp()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into employee values('" + txt_empid.Text + "','" + txt_name.Text + "','" + txt_qual.Text + "','" + txt_desi.Text + "','" + txt_sal.Text + "','" + txt_ph.Text + "','" + txt_add.Text + "','" + txt_age.Text + "','" + dateTimePicker1.Text + "','" + txt_depot.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee details added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
