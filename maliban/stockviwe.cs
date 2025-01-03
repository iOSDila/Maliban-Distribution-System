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
    public partial class stockviwe : Form
    {
        public stockviwe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stockviwe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maliban_Distribution_project_5DataSet.Mainstock' table. You can move, or remove it, as needed.
            this.mainstockTableAdapter.Fill(this.maliban_Distribution_project_5DataSet.Mainstock);
            // TODO: This line of code loads data into the 'maliban_Distribution_project_4DataSet.Mainstock' table. You can move, or remove it, as needed.
            //this.mainstockTableAdapter1.Fill(this.maliban_Distribution_project_4DataSet.Mainstock);
            // TODO: This line of code loads data into the 'maliban_Distribution_project_3DataSet.Mainstock' table. You can move, or remove it, as needed.
            //this.mainstockTableAdapter2.Fill(this.maliban_Distribution_project_3DataSet.Mainstock);
            // TODO: This line of code loads data into the 'maliban_Distribution_projectDataSet.Mainstock' table. You can move, or remove it, as needed.
            //this.mainstockTableAdapter1.Fill(this.maliban_Distribution_projectDataSet.Mainstock);
            // TODO: This line of code loads data into the 'maliban_Distribution_projectDataSet.Mainstock' table. You can move, or remove it, as needed.
            //this.mainstockTableAdapter.Fill(this.maliban_Distribution_projectDataSet.Mainstock);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            stock frm = new stock();
            frm.Show();
            this.Hide();
        }
    }
}
