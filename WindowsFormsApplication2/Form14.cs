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

        private void Form14_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();

            button1_Click((object)sender, (EventArgs)e);
            string user = Cryptography.Encrypt(label1.Text);
            String query = "SELECT foodname FROM food ";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);

            button1.Text = dt.Rows[0][0].ToString();
            button2.Text = dt.Rows[1][0].ToString();
            button3.Text = dt.Rows[2][0].ToString();
            button4.Text = dt.Rows[3][0].ToString();
            button5.Text = dt.Rows[4][0].ToString();
            button6.Text = dt.Rows[5][0].ToString();
            button7.Text = dt.Rows[6][0].ToString();
            button8.Text = dt.Rows[7][0].ToString();
            button9.Text = dt.Rows[8][0].ToString();
            button10.Text = dt.Rows[9][0].ToString();

        }
        private void food(int fno,int i)
        {
            string user = Cryptography.Encrypt(label1.Text);

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

            if (i == 1)
            {
                String query1 = "SELECT sum(like1),sum( unlike1)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 2)
            {
                String query1 = "SELECT sum(like2),sum( unlike2)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 3)
            {
                String query1 = "SELECT sum(like3),sum( unlike3)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 4)
            {
                String query1 = "SELECT sum(like4),sum( unlike4)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 5)
            {
                String query1 = "SELECT sum(like5),sum( unlike5)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 6)
            {
                String query1 = "SELECT sum(like6),sum( unlike6)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 7)
            {
                String query1 = "SELECT sum(like7),sum( unlike7)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 8)
            {
                String query1 = "SELECT sum(like8),sum( unlike8)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 9)
            {
                String query1 = "SELECT sum(like9),sum( unlike9)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
            else if (i == 10)
            {
                String query1 = "SELECT sum(like10),sum( unlike10)  from ratings ";
                MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                data1.Fill(dt1);
                label4.Text = dt1.Rows[0][0].ToString();
                label3.Text = dt1.Rows[0][1].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb(2);
            button2.BackColor = Color.FromArgb(40, 96, 144);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);


            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            label5.Text = "2";
            food(2, 2);
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









        private void button1_Click(object sender, EventArgs e)
        {

            bb(1);

            button1.BackColor = Color.FromArgb(40, 96, 144);
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            label5.Text = "1";
            food(1,1);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bb(3);
            button3.BackColor = Color.FromArgb(40, 96, 144);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);

            label5.Text = "3";
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            food(3, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb(4);
            button4.BackColor = Color.FromArgb(40, 96, 144);
           
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);
            label5.Text = "4";
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;

            food(4, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bb(5);
            button5.BackColor = Color.FromArgb(40, 96, 144);
        
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);

            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            label5.Text = "5";
            food(5, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            bb(6);
            button6.BackColor = Color.FromArgb(40, 96, 144);
        
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);

            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            label5.Text = "6";
            food(6, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bb(7);
            button7.BackColor = Color.FromArgb(40, 96, 144);
       
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;
            label5.Text = "7";
            food(7, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bb(8);
            button8.BackColor = Color.FromArgb(40, 96, 144);
          
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
            label5.Text = "8";
            food(8, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bb(9);
            button9.BackColor = Color.FromArgb(40, 96, 144);
          
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            button10.BackColor = Color.FromArgb(51, 122, 183);
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
            label5.Text = "9";
            food(9,9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bb(10);
            button10.BackColor = Color.FromArgb(40, 96, 144);
       
            button2.BackColor = Color.FromArgb(51, 122, 183);
            button3.BackColor = Color.FromArgb(51, 122, 183);
            button4.BackColor = Color.FromArgb(51, 122, 183);
            button5.BackColor = Color.FromArgb(51, 122, 183);
            button6.BackColor = Color.FromArgb(51, 122, 183);
            button7.BackColor = Color.FromArgb(51, 122, 183);
            button8.BackColor = Color.FromArgb(51, 122, 183);
            button9.BackColor = Color.FromArgb(51, 122, 183);
            button1.BackColor = Color.FromArgb(51, 122, 183);
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
            label5.Text = "10";
            food(10, 10);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            panel3.Height = button1.Height;
            panel3.Top = button1.Top; ;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top; ;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top; ;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top; ;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top; ;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top; ;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top; ;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top; ;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top; ;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top; ;
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
            Form17 oo = new Form17("b",label1.Text);
            oo.Show();
            timer2.Start();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form17 oo = new Form17("a",label1.Text);
            oo.Show();
            timer2.Start();
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
            timer1.Start();
           
            label73.Text = DateTime.Now.ToShortTimeString();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Regex m = new Regex("$(0-9){5,8}^");
            string message = "Do you want to order this food?";
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
                else if (!m.IsMatch( textBox2.Text) )

                {
                    MessageBox.Show("Invalid Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                    textBox2.Clear();
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
                        cm.CommandText = "update food set foodname=@foodname,tk=@price,detais=@details1,details2=@details2 ,image=@img where foodno=@foodno and mid=@username";

                        cm.Parameters.AddWithValue("@foodname", textBox1.Text);
                        cm.Parameters.AddWithValue("@price", textBox2.Text);
                        cm.Parameters.AddWithValue("@details1", textBox3.Text);

                        cm.Parameters.AddWithValue("@details2", textBox4.Text);
                        cm.Parameters.AddWithValue("@foodno", label5.Text);
                        cm.Parameters.AddWithValue("@username", Cryptography.Encrypt(label1.Text));
                        cm.Parameters.AddWithValue("@img", img);
                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();


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

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            label5.Text = "2";
            food(2, 2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            label5.Text = "1";
            food(1, 1);

        }
    }
}
