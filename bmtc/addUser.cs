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
    public partial class addUser : UserControl
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into login values('"+txt_username.Text+"','"+txt_pass.Text+"','"+comboBox1.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New user added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
