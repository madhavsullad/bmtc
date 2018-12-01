using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmtc
{
    public partial class user : Form
    {
        public int s;
        public user()
        {
            InitializeComponent();
        }

        private void btn_busNo_Click(object sender, EventArgs e)
        {
            s = 0;
            MessageBox.Show(" btn_busNo");
            this.Hide();
            search search = new search();
            search.ShowDialog();
            this.Close();
        }

        private void btn_routeNo_Click(object sender, EventArgs e)
        {
            s = 1;
            MessageBox.Show("btn_routeNo");
            this.Hide();
            search search = new search();
            search.ShowDialog();
            this.Close();
        }

    }
}
