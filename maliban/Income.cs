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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        private void btnStockedit_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btnStockview_Click(object sender, EventArgs e)
        {
            Icomeview frm = new Icomeview();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpage frm = new mainpage();
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
