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
    public partial class Icomeview : Form
    {
        public Icomeview()
        {
            InitializeComponent();
        }

        private void Icomeview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bill_MoneyDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.bill_MoneyDataSet.Table1);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Income frm = new Income();
            frm.Show();
            this.Hide();
        }
    }
}
