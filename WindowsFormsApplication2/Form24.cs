using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form24 : Form
    {
        public Form24(string ms)
        {
            InitializeComponent();
            label11.Text = ms;
            
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
         //   panel1.Controls.Add(childForm);
         //   panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void b1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Form24_Load(object sender, EventArgs e)
        {
           


           
            string queryb = "SELECT mid,name,maddress,memail,mphone,mpic from manager where mid='" + Cryptography.Encrypt(label11.Text) + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            
           

                byte[] img = (byte[])zz.Rows[0][5];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox1.Image = Image.FromStream(ms);
                bunifuPictureBox2.Image = Image.FromStream(ms);

                t1.Text = Cryptography.Decrypt(zz.Rows[0][0].ToString());
                t2.Text = zz.Rows[0][1].ToString();
                t3.Text = zz.Rows[0][3].ToString();
                t4.Text = zz.Rows[0][4].ToString();
                t5.Text = zz.Rows[0][2].ToString();
           
        }

        private void b3_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            string user = Cryptography.Encrypt(label11.Text);
            string queryb = "SELECT keycode from manager where mid='" + user + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);

            Regex mg = new Regex("^[@]$");








            string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());
            if (t7.Text == "")
            {

                MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                t7.Focus();
            }
            else if (t7.Text != pas)
            {
                MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                t7.Focus();
            }
            else if (t8.Text == "")
            {

                MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                t8.Focus();
            }
            else if (t9.Text.Length < 6 || t9.Text.Length > 12)
            {

                MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                t9.Focus();

            }




            else if (t9.Text == "")
            {

                MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                t9.Focus();

            }
            else if (t9.Text != t8.Text)
            {

                MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                t9.Focus();

            }

            else
            {
                string message = "Do you want to Update Your Data?";
                string title = "Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "update manager,session set keycode=@pass,session.password=@pass where mid=@username and session.username=mid=@username";

                    cm.Parameters.AddWithValue("@username", user);
                    

                    string bd = Cryptography.Encrypt(t9.Text+"@shop.as");
                    textBox1.Text = Cryptography.Decrypt(bd);
                    cm.Parameters.AddWithValue("@pass", bd);




                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();



                    MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    
                    

                }
                else {


                }
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox1.Image = Image.FromFile(opf.FileName);


                MemoryStream ms = new MemoryStream();
                bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                bunifuPictureBox1.Image = Image.FromFile(opf.FileName);
                con.Close();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           


            string mail = Cryptography.Encrypt(t3.Text);
            string query1 = "SELECT customer.email from customer where customer.email='"+mail+ "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable z = new DataTable();
            data1.Fill(z);

            string query11 = "SELECT deliveryboy.demail from deliveryboy where  deliveryboy.demail='" + this.t3.Text + "'";
            MySqlDataAdapter data11 = new MySqlDataAdapter(query11, con);
            DataTable z1 = new DataTable();
            data1.Fill(z1);

            string query12 = "SELECT admin.mastermail from admin where  admin.mastermail='" + mail + "'";
            MySqlDataAdapter data12 = new MySqlDataAdapter(query12, con);
            DataTable z2 = new DataTable();
            data1.Fill(z2);


            string user = Cryptography.Encrypt(label11.Text);




            string query = "SELECT keycode from manager where mid='" + user + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable xx = new DataTable();
            data.Fill(xx);
            string pass =Cryptography.Decrypt( xx.Rows[0][0].ToString());
            if (z.Rows.Count == 1 || z1.Rows.Count == 1 || z2.Rows.Count == 1)
            {
                MessageBox.Show("Email is used", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t3.Focus();
            }
         
            else if (t1.Text=="")
            {
                MessageBox.Show("Username is reuqired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t1.Focus();
            }
          else  if (t2.Text == "")
            {
                MessageBox.Show("Name is rqeuired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t2.Focus();
            }
            else if (t3.Text == "")
            {
                MessageBox.Show("Emil is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                    t3.Focus();
            }
            else if (t4.Text == "")
            {
                MessageBox.Show("Phone is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t4.Focus();
            }
            else if (t5.Text == "")
            {
                MessageBox.Show("Address is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t5.Focus();
            }
            else if (t6.Text == "")
            {
                MessageBox.Show("Please insert password to save update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t6.Focus();
            }
            else if (Cryptography.vmail(t3.Text)==false)
            {
                MessageBox.Show("Please Enter Valid Email Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t3.Focus();
            }
            else if (Cryptography.vphone(t4.Text) == false)
            {
                MessageBox.Show("Please Enter Valid Phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t3.Focus();
            }
            else if (t1.Text.Length<5)
            {
                MessageBox.Show("Please enter username in 5 character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t1.Focus();
            }
            else if (t6.Text!=pass)
            {
                MessageBox.Show("Please enter correct password to save changes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                t1.Focus();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                MySqlCommand om = new MySqlCommand();
                om.Connection = con;
                om.CommandText = "Update manager,session set  mid='" + Cryptography.Encrypt( t1.Text)+ "' ,name='" + this.t2.Text + "',memail='" + this.t3.Text + "',mphone='" + this.t4.Text + "',maddress='" + this.t5.Text + "',mpic=@image,session.username='" + Cryptography.Encrypt(t1.Text) + "' where mid='" + user+ "' and session.username='" + user + "'";

                om.Parameters.AddWithValue("image", img);
                con.Open();
                om.ExecuteNonQuery();
                MessageBox.Show("Your Data hs been updated", "Successful", MessageBoxButtons.OK);
                con.Close();
                label11.Text = t1.Text;


                bunifuPictureBox1.Image = bunifuPictureBox2.Image;
               

            }



        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
