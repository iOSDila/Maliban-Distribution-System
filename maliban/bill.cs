﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esoftmaliban
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainpage frm = new mainpage();
            frm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            billedit frm = new billedit();
            frm.Show();
            this.Hide();
        }

        private void btnViwe_Click(object sender, EventArgs e)
        {
            billviwe frm = new billviwe();
            frm.Show();
            this.Hide();
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
