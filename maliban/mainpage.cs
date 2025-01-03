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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to continue  to login page?", "message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            stock frm = new stock();
            frm.Show();
            this.Hide();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bill frm = new bill();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          /*  quicksearch frm = new quicksearch();
            frm.Show();
            this.Hide();*/
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Income frm = new Income();
            frm.Show();
            this.Hide();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orderpre frm = new Orderpre ();
            frm.Show();
            this.Hide();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about frm = new about();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to continue  to login page?", "message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

            
        }

        private void mainStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock frm = new stock();
            frm.Show();
            this.Hide();
        }

        private void billEnteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill frm = new bill();
            frm.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           quicksearch frm = new quicksearch();
            frm.Show();
            this.Hide();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderpre frm = new Orderpre();
            frm.Show();
            this.Hide();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dailyIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Income frm = new Income();
            frm.Show();
            this.Hide();
        }

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Maliban Distribution System User guide.docx");
        }

        private void toDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Maliban Distribution project_5.accdb");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
