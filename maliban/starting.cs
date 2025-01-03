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
    public partial class starting : Form
    {
        public starting()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgStart.Value += 5;
            if (pgStart.Value == pgStart.Maximum)
            {
                timer1.Stop();
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void starting_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pgStart_Click(object sender, EventArgs e)
        {

        }
    }
}
