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
        string reg;
        public editBusDetails()
        {
            InitializeComponent();
        }

        private void btn_FetchUpdate_Click(object sender, EventArgs e)
        {
            //btn_FetchU.Hide();
            btn_update.Show();
            btn_update.BringToFront();
        

            try
            {
                reg = txt_reg.Text;
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from bus where regNo = '" + txt_reg.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txt_bus.Text = dt.Rows[0]["busNo"].ToString();
                txt_type.Text = dt.Rows[0]["type"].ToString();
                txt_origin.Text = dt.Rows[0]["origin"].ToString();
                txt_dest.Text = dt.Rows[0]["destination"].ToString();
                txt_depot.Text = dt.Rows[0]["depot"].ToString();
                txt_stat.Text = dt.Rows[0]["status"].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter da;
                SqlCommandBuilder cmdBuilder;

                cn.ConnectionString = "Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True";

                cn.Open();
                da = new SqlDataAdapter("select * from bus where regNo='"+reg+"'", cn);
                cmdBuilder = new SqlCommandBuilder(da);
                da.Fill(ds,"bus");

                ds.Tables["bus"].Rows[0]["busNo"] = txt_bus.Text;
                ds.Tables["bus"].Rows[0]["regNo"] = txt_reg.Text;
                ds.Tables["bus"].Rows[0]["type"] = txt_type.Text;
                ds.Tables["bus"].Rows[0]["origin"] = txt_origin.Text;
                ds.Tables["bus"].Rows[0]["destination"] = txt_dest.Text;
                ds.Tables["bus"].Rows[0]["depot"] = txt_depot.Text;
                ds.Tables["bus"].Rows[0]["status"] = txt_stat.Text;

                da.Update(ds, "bus");

                MessageBox.Show("Updated!");
                /*
                SqlConnection con = new SqlConnection("Data Source=madhav-laptop\\madhavserver;Initial Catalog=bmtc;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE bus SET busNo='" + txt_bus.Text + "',type='"+txt_type.Text+"',origin='"+txt_origin.Text+"',destination='"+txt_dest.Text+"',depot='"+txt_depot.Text+"',status='"+txt_stat.Text+"' where regNo='"+txt_reg.Text+"'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                MessageBox.Show("Updated!");*/

                /*
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Rows[0]["regNo"] = txt_reg.Text;
                dt.Rows[0]["busNo"] = txt_bus.Text;
                dt.Rows[0]["type"] = txt_type.Text;
                dt.Rows[0]["origin"] = txt_origin.Text;
                dt.Rows[0]["destination"] = txt_dest.Text;
                dt.Rows[0]["depot"] = txt_depot.Text;
                dt.Rows[0]["status"] = txt_stat.Text;*/
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
