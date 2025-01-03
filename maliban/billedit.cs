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
    public partial class billedit : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Maliban Distribution project_5.accdb");
        public billedit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill frm = new bill();
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM Bill_Data WHERE Bill_no='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlDelete, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA HAS BEEN DELETED COMPLETELY", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM Bill_DATA WHERE Bill_no='" + textBox1.Text + "'";
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
                MessageBox.Show("DATA FOUND","Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("NO RECORED HAS BEEN FOUND", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
           
            
            


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            MessageBox.Show("Cleared", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void insert_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO Bill_Data VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sqlInsert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted","Successesfull",MessageBoxButtons.OK,MessageBoxIcon.Information);


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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtNf25_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMcb25_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP75_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP180_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP350_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHc400_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNf400_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHc200_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP400_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt60_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtF1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtF900_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt400_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt75_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt250_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtF400_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt150_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNf25_Click(object sender, EventArgs e)
        {

        }

        private void lblP350_Click(object sender, EventArgs e)
        {

        }

        private void lblP400_Click(object sender, EventArgs e)
        {

        }

        private void lblHc200_Click(object sender, EventArgs e)
        {

        }

        private void lblHc400_Click(object sender, EventArgs e)
        {

        }

        private void lblT1_Click(object sender, EventArgs e)
        {

        }

        private void lblF1_Click(object sender, EventArgs e)
        {

        }

        private void lbl250_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblP180_Click(object sender, EventArgs e)
        {

        }

        private void lblP20_Click(object sender, EventArgs e)
        {

        }

        private void lbl75_Click(object sender, EventArgs e)
        {

        }

        private void lblNf400_Click(object sender, EventArgs e)
        {

        }

        private void lblF900_Click(object sender, EventArgs e)
        {

        }

        private void lblF400_Click(object sender, EventArgs e)
        {

        }

        private void lbl400_Click(object sender, EventArgs e)
        {

        }

        private void lbl20_Click(object sender, EventArgs e)
        {

        }

        private void lblP75_Click(object sender, EventArgs e)
        {

        }

        private void lblMcb25_Click(object sender, EventArgs e)
        {

        }

        private void lbl150_Click(object sender, EventArgs e)
        {

        }

        private void lbl60_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE Bill_Data SET MalibanKiri150gFoilPack='" + textBox2.Text + "', MalibanKiri75gsachet='" + textBox3.Text + "', MalibanKiri60gsachet='" + textBox4.Text + "', MalibanKiri20gsachet='" + textBox5.Text + "', MalibanKiri400gshelf='" + textBox6.Text + "', MalibanKiri1kgshelf='" + textBox7.Text + "', MalibanKiri250gshelf='" + textBox8.Text + "', Malibankiri400gshelfpacks='" + textBox9.Text + "', MalibanKiri1kgfoilpacks='" + textBox10.Text + "', MalibanKiri900foilpacks='" + textBox11.Text + "', MalibanKiri1kgteashopacks='" + textBox12.Text + "', Malibannonfat400gshelf='" + textBox13.Text + "', MalibanHicalnonfatgold400g='" + textBox14.Text + "', MalibanHicalnonfatgold200g='" + textBox15.Text + "', Puredale400gshelf='" + textBox16.Text + "', Puredale350gfoilpacks='" + textBox17.Text + "', Puredale180gfoilpacks='" + textBox18.Text + "', Puredale75gsachet='" + textBox19.Text + "', Puredale20gsachet='" + textBox20.Text + "', Malibanmilkcream25kgbulk='" + textBox21.Text + "', Malibannonfat25kgbulk='" + textBox22.Text + "' WHERE Bill_no='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlUpdate, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA UPDATED", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void billedit_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            // Show PrintPreview Dialog

            printPreviewDialog1.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();
            }
            MessageBox.Show("Bill is Printing", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font fnt2 = new Font("Arial", 15);
            Font fnt1=new Font("Arial",20);
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            e.Graphics.DrawImage(myBitmap1, 10, 10);

            myBitmap1.Dispose();

           
            e.Graphics.DrawString(lblId.Text+":", fnt1, Brushes.Black, 550, 50);
            e.Graphics.DrawString(textBox1.Text, fnt1, Brushes.Black, 650, 50);

            e.Graphics.DrawString(lbl150.Text + ":", fnt2, Brushes.Black, 20, 130);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 130);
            e.Graphics.DrawString(textBox2.Text, fnt2, Brushes.Black, 600, 130);

            e.Graphics.DrawString(lbl75.Text + ":", fnt2, Brushes.Black, 20, 170);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 170);
            e.Graphics.DrawString(textBox3.Text, fnt2, Brushes.Black, 600, 170);

            e.Graphics.DrawString(lbl60.Text + ":", fnt2, Brushes.Black, 20, 210);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 210);
            e.Graphics.DrawString(textBox4.Text, fnt2, Brushes.Black, 600, 210);

            e.Graphics.DrawString(lbl20.Text + ":", fnt2, Brushes.Black, 20, 250);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 250);
            e.Graphics.DrawString(textBox5.Text, fnt2, Brushes.Black, 600, 250);

            e.Graphics.DrawString(lbl400.Text + ":", fnt2, Brushes.Black, 20, 290);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 290);
            e.Graphics.DrawString(textBox6.Text, fnt2, Brushes.Black, 600, 290);

            e.Graphics.DrawString(lbl1.Text + ":", fnt2, Brushes.Black, 20, 330);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 330);
            e.Graphics.DrawString(textBox7.Text, fnt2, Brushes.Black, 600, 330);

            e.Graphics.DrawString(lbl250.Text + ":", fnt2, Brushes.Black, 20, 370);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 370);
            e.Graphics.DrawString(textBox8.Text, fnt2, Brushes.Black, 600, 370);

            e.Graphics.DrawString(lblF400.Text + ":", fnt2, Brushes.Black, 20, 410);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 410);
            e.Graphics.DrawString(textBox9.Text, fnt2, Brushes.Black, 600, 410);

            e.Graphics.DrawString(lblF1.Text + ":", fnt2, Brushes.Black, 20, 450);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 450);
            e.Graphics.DrawString(textBox10.Text, fnt2, Brushes.Black, 600, 450);

            e.Graphics.DrawString(lblF900.Text + ":", fnt2, Brushes.Black, 20, 490);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 490);
            e.Graphics.DrawString(textBox11.Text, fnt2, Brushes.Black, 600, 490);

            e.Graphics.DrawString(lblT1.Text + ":", fnt2, Brushes.Black, 20, 530);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 530);
            e.Graphics.DrawString(textBox12.Text, fnt2, Brushes.Black, 600, 530);

            e.Graphics.DrawString(lblNf400.Text + ":", fnt2, Brushes.Black, 20, 570);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 570);
            e.Graphics.DrawString(textBox13.Text, fnt2, Brushes.Black, 600, 570);

            e.Graphics.DrawString(lblHc400.Text + ":", fnt2, Brushes.Black, 20, 610);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 610);
            e.Graphics.DrawString(textBox14.Text, fnt2, Brushes.Black, 600, 610);

            e.Graphics.DrawString(lblHc200.Text + ":", fnt2, Brushes.Black, 20, 650);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 650);
            e.Graphics.DrawString(textBox15.Text, fnt2, Brushes.Black, 600, 650);

            e.Graphics.DrawString(lblP400.Text + ":", fnt2, Brushes.Black, 20, 690);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 690);
            e.Graphics.DrawString(textBox16.Text, fnt2, Brushes.Black, 600, 690);

            e.Graphics.DrawString(lblP350.Text + ":", fnt2, Brushes.Black, 20, 730);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 730);
            e.Graphics.DrawString(textBox17.Text, fnt2, Brushes.Black, 600, 730);

            e.Graphics.DrawString(lblP180.Text + ":", fnt2, Brushes.Black, 20, 770);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 770);
            e.Graphics.DrawString(textBox18.Text, fnt2, Brushes.Black, 600, 770);

            e.Graphics.DrawString(lblP75.Text + ":", fnt2, Brushes.Black, 20, 810);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 810);
            e.Graphics.DrawString(textBox19.Text, fnt2, Brushes.Black, 600, 810);

            e.Graphics.DrawString(lblP20.Text + ":", fnt2, Brushes.Black, 20, 850);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 850);
            e.Graphics.DrawString(textBox20.Text, fnt2, Brushes.Black, 600, 850);

            e.Graphics.DrawString(lblMcb25.Text + ":", fnt2, Brushes.Black, 20, 890);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 890);
            e.Graphics.DrawString(textBox21.Text, fnt2, Brushes.Black, 600, 890);

            e.Graphics.DrawString(lblNf400.Text + ":", fnt2, Brushes.Black, 20, 930);
            e.Graphics.DrawString(":", fnt2, Brushes.Black, 580, 930);
            e.Graphics.DrawString(textBox22.Text, fnt2, Brushes.Black, 600, 930);

          



           

            


        }
    }
}
