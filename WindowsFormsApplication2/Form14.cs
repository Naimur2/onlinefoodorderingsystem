using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form14 : Form
    {
        public Form14(string ms)
        {
            InitializeComponent();
            label1.Text = ms;
     
        }



        MySqlConnection con = new MySqlConnection(Cryptography.con());

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        public void update()
        {
            String query = label1.Text;
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);


            DataTable cc = new DataTable();

            int i = dt.Rows.Count;

            cc.Columns.Add("Si", typeof(string));
            cc.Columns.Add("Food Name", typeof(string));
            for (int j = 0; j < i; j++)
            {


                cc.Rows.Add(dt.Rows[j][0].ToString(), dt.Rows[j][1].ToString());

            }
            DataGridView1.RowTemplate.Height = 70;
            DataGridView1.DataSource = cc;



            DataGridView1.DataSource = cc;


        }

        private void Form14_Load(object sender, EventArgs e)
        {

            String query = label1.Text;
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);

           
            DataTable cc = new DataTable();

            int i = dt.Rows.Count;

            cc.Columns.Add("Si", typeof(string));
            cc.Columns.Add("Food Name", typeof(string));
            for (int j = 0; j < i; j++)
            {
                
               
                cc.Rows.Add(dt.Rows[j][0].ToString(), dt.Rows[j][1].ToString());

            }
            DataGridView1.RowTemplate.Height = 70;
            DataGridView1.DataSource = cc;



            DataGridView1.DataSource = cc;
           

            int k = DataGridView1.Rows.Count;
            if (k != 0)
            {
                DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(0, 0));
            }



        }
        private void food(int fno)
        {
         

            String query = "SELECT * FROM food where foodno='" + fno + "' ";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();

            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString() + "\r\n" + dt.Rows[0][5].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);


            log.like(fno, label4, label3, "ratings");
        }


        public void bb(int i)
        {
           
                string query = ("select COUNT(ord_no) FROM orders WHERE foodno ='" + i + "'");
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                data.Fill(dt);
                bunifuLabel5.Text = "Total Delivery :" + dt.Rows[0][0].ToString();
           
                string query1 = ("select COUNT(ord_no) FROM orders WHERE foodno ='" +i + "' and status='delivered'");
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                bunifuLabel7.Text = "Succseefull Delivery :" +  dt1.Rows[0][0].ToString();
           
                string query2 = ("select COUNT(ord_no) FROM orders WHERE foodno ='" +i + "' and status='Pending'");
                MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                data2.Fill(dt2);
                bunifuLabel8.Text = "Pending Delivery :" + dt2.Rows[0][0].ToString();
          
                string query3 = ("select COUNT(ord_no) FROM orders WHERE foodno ='" + i + "' and status='Invalid address'");
                MySqlDataAdapter data3 = new MySqlDataAdapter(query3, con);
                DataTable dt3 = new DataTable();
                data3.Fill(dt3);
                bunifuLabel6.Text = "Failed Delivery :" + dt3.Rows[0][0].ToString();
            
        }









       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

       
        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(opf.FileName);
                con.Close();
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            label22.Text = textBox1.Text;
            label62.Text = textBox2.Text;
            label32.Text = textBox3.Text + "\r\n" + textBox4.Text;
            pictureBox23.Image = pictureBox6.Image;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Exit?";
            string title = "Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                Form2 gg = new Form2();
                gg.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Regex m = new Regex("$(0-9){2,8}^");
            string message = "Do you want to update information?";
            string title = "Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (textBox1.Text == "")

                {
                    MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")

                {
                    MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
               
               else if (textBox3.Text == "")

                {
                    MessageBox.Show("Invalid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                }
               else if (textBox3.Text.Length < 45)

                {
                    MessageBox.Show("Detais should have minimum 45 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                }
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox6.Image.Save(ms, pictureBox6.Image.RawFormat);
                        byte[] img = ms.ToArray();



                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = "update food set foodname=@foodname,tk=@price,detais=@details1,details2=@details2 ,image=@img where foodno=@foodno";

                        cm.Parameters.AddWithValue("@foodname", textBox1.Text);
                        cm.Parameters.AddWithValue("@price", textBox2.Text);
                        cm.Parameters.AddWithValue("@details1", textBox3.Text);

                        cm.Parameters.AddWithValue("@details2", textBox4.Text);
                        cm.Parameters.AddWithValue("@foodno", label5.Text);
                        cm.Parameters.AddWithValue("@img", img);
                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();
                        food(Int32.Parse(label5.Text));
                        bb(Int32.Parse(label5.Text));
                        MessageBox.Show("Data updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        update();
                    }
                    catch (Exception c)

                    {
                        MessageBox.Show("Image should Be under 40 MIB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {


            }


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                label5.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                food(Int32.Parse(label5.Text));
                bb(Int32.Parse(label5.Text));
            }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
