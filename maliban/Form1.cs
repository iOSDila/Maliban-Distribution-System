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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "Maliban@G") && (txtPass.Text == "123Maliban")) {
                mainpage frm = new mainpage();
                frm.Show();
                this.Hide();

                MessageBox.Show("Welcome to K.M.K. Distribution", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Incorrect Username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to quit?", "message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

    }
}
