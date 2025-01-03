using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esoftmaliban
{
    public partial class Orderpre : Form
    {
        public Orderpre()
        {
            InitializeComponent();
        }

        private void btnStockedit_Click(object sender, EventArgs e)
        {
            orders frm = new orders();
            frm.Show();
            this.Hide();
        }

        private void btnStockview_Click(object sender, EventArgs e)
        {
            Orderviwe frm = new Orderviwe();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpage frm = new mainpage();
            frm.Show();
            this.Hide();
        }
    }
}
