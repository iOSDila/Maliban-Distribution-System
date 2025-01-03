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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Bill_Money.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.testDataSet.Table1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlinsert="INSERT INTO Table1 VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            OleDbCommand cmd = new OleDbCommand(sqlinsert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfuly inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM Table1 WHERE Bill_No='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlsearch, con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
            else
            {
                MessageBox.Show("NO RECORD","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

           
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE Table1 SET age='" + textBox3.Text + "' WHERE ID='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlUpdate, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            Income frm = new Income();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Cleared", "clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4;
            num1 = int.Parse(textBox4.Text);
            num2 = num1 * 5 / 100;
            textBox5.Text = num2.ToString();
            num3 = int.Parse(textBox6.Text);
            num4 = num1 - (num2 + num3);
            textBox3.Text = num4.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
