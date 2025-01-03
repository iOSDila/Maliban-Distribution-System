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
    public partial class Orderviwe : Form
    {
        public Orderviwe()
        {
            InitializeComponent();
        }

        private void Orderviwe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maliban_Distribution_project_3DataSet.ODR' table. You can move, or remove it, as needed.
            this.oDRTableAdapter.Fill(this.maliban_Distribution_project_3DataSet.ODR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orderpre frm = new Orderpre();
            frm.Show();
            this.Hide();
        }
    }
}
