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
    public partial class changepass : Form
    {
        public changepass(string ll,string catagory)
        {
            InitializeComponent();
            label1.Text = ll;
            label2.Text = catagory;
        }

        MySqlConnection con = new MySqlConnection(Cryptography.con());


        public void pass(string mm)
        {
            if (mm == "customer")
            {
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT password from customer where username='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());

                if (t1.Text == "")
                {

                    MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t1.Text != pas)
                {
                    MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t2.Text == "")
                {

                    MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                    t2.Focus();
                }
                else if (t3.Text.Length < 6 || t3.Text.Length > 12)
                {

                    MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }




                else if (t3.Text == "")
                {

                    MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }
                else if (t3.Text != t2.Text)
                {

                    MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

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
                        cm.CommandText = "update customer set password=@pass where username=@username";

                        cm.Parameters.AddWithValue("@username", user);
                        cm.Parameters.AddWithValue("@pass", Cryptography.Encrypt(t3.Text));




                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();



                        MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    }
                    else { }
                }




            }
            else if (mm == "manager")
            {
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT keycode from manager where mid='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());
                if (t1.Text == "")
                {

                    MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t1.Text + @"shop.as" != pas)
                {
                    MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t2.Text == "")
                {

                    MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                    t2.Focus();
                }
                else if (t3.Text.Length < 6 || t3.Text.Length > 12)
                {

                    MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }




                else if (t3.Text == "")
                {

                    MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }
                else if (t3.Text != t2.Text)
                {

                    MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

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
                        cm.CommandText = "update manager set keycode=@pass where username=@username";

                        cm.Parameters.AddWithValue("@username", user);
                        string aa = "@shop.as";

                        string bb = t3.Text + aa;

                        string bd = Cryptography.Encrypt(bb);
                        cm.Parameters.AddWithValue("@pass", bd);




                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();



                        MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    }
                    else { }
                }

            }
            else if (mm == "deliveryboy")
            {
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT password from deliveryboy where user='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());

                if (t1.Text == "")
                {

                    MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t1.Text + "@delivery.as" != pas)
                {
                    MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t2.Text == "")
                {

                    MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                    t2.Focus();
                }
                else if (t3.Text.Length < 6 || t3.Text.Length > 12)
                {

                    MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }




                else if (t3.Text == "")
                {

                    MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }
                else if (t3.Text != t2.Text)
                {

                    MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

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
                        cm.CommandText = "update deliveryboy set Password=@pass where user=@username";

                        cm.Parameters.AddWithValue("@username", user);
                        string aa = "@delivery.as";
                        string bb = t3.Text + aa;
                        string bd = Cryptography.Encrypt(bb);
                        cm.Parameters.AddWithValue("@pass", bd);



                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();



                        MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    }
                    else
                    {




                    }

                }

            }
            else if (mm == "deliveryboy")
            {
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT password from deliveryboy where user='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());

                if (t1.Text == "")
                {

                    MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t1.Text + "@delivery.as" != pas)
                {
                    MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t2.Text == "")
                {

                    MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                    t2.Focus();
                }
                else if (t3.Text.Length < 6 || t3.Text.Length > 12)
                {

                    MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }




                else if (t3.Text == "")
                {

                    MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }
                else if (t3.Text != t2.Text)
                {

                    MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

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
                        cm.CommandText = "update deliveryboy set Password=@pass where user=@username";

                        cm.Parameters.AddWithValue("@username", user);
                        string aa = "@delivery.as";
                        string bb = t3.Text + aa;
                        string bd = Cryptography.Encrypt(bb);
                        cm.Parameters.AddWithValue("@pass", bd);



                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();



                        MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    }
                    else
                    {


                    }


                }
            }
            else if (mm == "admin")
            {
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT password from deliveryboy where user='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                string pas = Cryptography.Decrypt(zz.Rows[0][0].ToString());

                if (t1.Text == "")
                {

                    MessageBox.Show("Please input Old password", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t1.Text + "@delivery.as" != pas)
                {
                    MessageBox.Show("Your Old password is not matched ", "Save", MessageBoxButtons.OK);
                    t1.Focus();
                }
                else if (t2.Text == "")
                {

                    MessageBox.Show("New password is required ", "Save", MessageBoxButtons.OK);
                    t2.Focus();
                }
                else if (t3.Text.Length < 6 || t3.Text.Length > 12)
                {

                    MessageBox.Show("Please should be 6 to twelve character ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }




                else if (t3.Text == "")
                {

                    MessageBox.Show("Please retype new password is required ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

                }
                else if (t3.Text != t2.Text)
                {

                    MessageBox.Show("Please retype same password  ", "Save", MessageBoxButtons.OK);
                    t3.Focus();

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
                        cm.CommandText = "update admin set masterid=@pass where user=@username";

                        cm.Parameters.AddWithValue("@username", user);
                        string aa = "@delivery.as";
                        string bb = t3.Text + aa;
                        string bd = Cryptography.Encrypt(bb);
                        cm.Parameters.AddWithValue("@pass", bd);



                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();



                        MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                    }
                }
            }
        }

      
           





        

        private void changepass_Load(object sender, EventArgs e)
        {
            if (label2.Text == "Admin")
            {

                label3.Visible = true;
                label4.Text = "@shop.as";
                label4.Visible = true;
                label3.Text = "Please enter '@admin.as' after password when you log in otherwise you cannot login.";

                label5.Text = "@admin.as";
                label5.Visible = true;
                label6.Text = "@admin.as";
                label6.Visible = true;

            }

            else
            if (label2.Text == "customer")
            {
               
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT pic from customer where username='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);


                byte[] img = (byte[])zz.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox2.Image = Image.FromStream(ms);

            }
            else if (label2.Text == "manager")
            {
                label3.Visible = true;
                label4.Text = "@shop.as";
                label4.Visible = true;
                label3.Text = "Please enter '@shop.as' after password when you log in otherwise you cannot login.";

                label5.Text = "@shop.as";
                label5.Visible = true;
                label6.Text = "@shop.as";
                label6.Visible = true;
                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT mpic from manager where username='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);


                byte[] img = (byte[])zz.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox2.Image = Image.FromStream(ms);



            }
            else if (label2.Text == "deliveryboy")
            {
                label3.Visible = true;
                label4.Text = "@delivery.as";
                label4.Visible = true;
                label3.Text = "Please enter '@delivery.as' after password when you log in otherwise you cannot login.";

                label5.Text = "@delivery.as";
                label5.Visible = true;

                label6.Text = "@delivery.as";
                label6.Visible = true;



                string user = Cryptography.Encrypt(label1.Text);
                string queryb = "SELECT D_pic from deliveryboy where user='" + user + "'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);


                byte[] img = (byte[])zz.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox2.Image = Image.FromStream(ms);



            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {try
            {

                pass(label2.Text);
            }
            catch(Exception y)
            {

                MessageBox.Show("Error","Error");


            }
            
        }
    }
}
