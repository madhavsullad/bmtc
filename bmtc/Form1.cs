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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username='" + tbox_uname.Text + "' and password='" + tbox_pass.Text + "'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (string.Compare(dt.Rows[i]["username"].ToString() , tbox_uname.Text) == 1)
                    {
                        MessageBox.Show("You are logged in as " + tbox_uname.Text + " (" + dt.Rows[i]["usertype"].ToString() + ")");
                        this.Hide();
                        if (String.Compare(dt.Rows[i]["usertype"].ToString(), "user") == 1)
                        {
                            Form3 norm = new Form3();
                            norm.Show();
                        }
                        else if (String.Compare(dt.Rows[i]["usertype"].ToString(), "admin") == 1)
                        {
                            Form2 admin = new Form2();
                            admin.Show();
                        }
                        
                        else
                            MessageBox.Show("Login Error!");
                    }

                }
            }
            else
                MessageBox.Show("Invalid username or password!");
        }
    }
}
