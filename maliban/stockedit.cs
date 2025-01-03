using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esoftmaliban
{
    public partial class stockedit : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Maliban Distribution project_5.accdb");
        public stockedit()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            MessageBox.Show("Cleared", "clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            stock frm = new stock();
            frm.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO Mainstock VALUES('" +textBox1.Text+ "','" +textBox2.Text + "','" +textBox3.Text+ "','" + textBox4.Text + "','" +textBox5.Text+ "','" +textBox6.Text+ "','" +textBox7.Text+ "','" +textBox8.Text+ "','" +textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text+ "','" + textBox12.Text+ "','" +textBox13.Text+ "','" +textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text+ "','" +textBox17.Text+ "','" + textBox18.Text + "','" +textBox19.Text+ "','" +textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sqlInsert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfuly inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           textBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
           textBox4.Text = "";
           textBox5.Text = "";
           textBox6.Text = "";
           textBox7.Text = "";
           textBox8.Text = "";
           textBox9.Text = "";
           textBox10.Text = "";
           textBox11.Text = "";
           textBox12.Text = "";
           textBox13.Text = "";
           textBox14.Text = "";
           textBox15.Text = "";
           textBox16.Text = "";
           textBox17.Text = "";
           textBox18.Text = "";
           textBox19.Text = "";
           textBox20.Text = "";
           textBox21.Text = "";
           textBox22.Text = "";
        }

        private void stockedit_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM Mainstock WHERE Date='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlSearch, con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
                textBox7.Text = dr[6].ToString();
                textBox8.Text = dr[7].ToString();
                textBox9.Text = dr[8].ToString();
                textBox10.Text = dr[9].ToString();
                textBox11.Text = dr[10].ToString();
                textBox12.Text = dr[11].ToString();
                textBox13.Text = dr[12].ToString();
                textBox14.Text = dr[13].ToString();
                textBox15.Text = dr[14].ToString();
                textBox16.Text = dr[15].ToString();
                textBox17.Text = dr[16].ToString();
                textBox18.Text = dr[17].ToString();
                textBox19.Text = dr[18].ToString();
                textBox20.Text = dr[19].ToString();
                textBox21.Text = dr[20].ToString();
                textBox22.Text = dr[21].ToString();
                MessageBox.Show("DATA FOUND", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("NO RECORED HAS BEEN FOUND", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
