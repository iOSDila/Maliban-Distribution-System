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
    public partial class billviwe : Form
    {
        public billviwe()
        {
            InitializeComponent();
        }

        private void billviwe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maliban_Distribution_project_5DataSet.Bill_Data' table. You can move, or remove it, as needed.
            this.bill_DataTableAdapter1.Fill(this.maliban_Distribution_project_5DataSet.Bill_Data);
            // TODO: This line of code loads data into the 'maliban_Distribution_project_4DataSet.Bill_Data' table. You can move, or remove it, as needed.
            //this.bill_DataTableAdapter.Fill(this.maliban_Distribution_project_4DataSet.Bill_Data);
            // TODO: This line of code loads data into the 'maliban_Distribution_project_3DataSet.Bill_Data' table. You can move, or remove it, as needed.
            //this.bill_DataTableAdapter1.Fill(this.maliban_Distribution_project_3DataSet.Bill_Data);
            // TODO: This line of code loads data into the 'maliban_Distribution_projectDataSet.Bill_Data' table. You can move, or remove it, as needed.
            //this.bill_DataTableAdapter.Fill(this.maliban_Distribution_projectDataSet.Bill_Data);
            // TODO: This line of code loads data into the 'maliban_Distribution_projectDataSet1.Bill_Data' table. You can move, or remove it, as needed.
            //this.bill_DataTableAdapter1.Fill(this.maliban_Distribution_projectDataSet1.Bill_Data);
            // TODO: This line of code loads data into the 'maliban_Distribution_projectDataSet.Bill_Data' table. You can move, or remove it, as needed.
            //is.bill_DataTableAdapter.Fill(this.maliban_Distribution_projectDataSet.Bill_Data);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bill frm = new bill();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
