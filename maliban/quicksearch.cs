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
    public partial class quicksearch : Form
    {
        public quicksearch()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDate.Text = "";
            txtTotal.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainpage frm = new mainpage();
            frm.Show();
            this.Hide();
        }
    }
}
