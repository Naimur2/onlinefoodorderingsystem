using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            string query = "select * from customer where username='" + this.username.Text + "'";
            string query2 = "select * from customer where  email='" + this.email.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            data.Fill(dt);
            data2.Fill(dt2);
            Regex mRegxExpression = new Regex("^[a-zA -Z0-9_]{4,16}@[a-z0-9A-Z_]{2,10}.[a-z.A-Z0-9]{2,6}$");

            if (dt.Rows.Count == 1)
            {

                MessageBox.Show("Account already Exist,Please choose different username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dt2.Rows.Count == 1)
            {

                MessageBox.Show("Account already Exist,Please choose different email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (username.Text == "")
            {
                label1.Visible = true;
                timer1.Start();
            }
            else if (email.Text == "")
            {
                label2.Visible = true;
                timer2.Start();
            }
            else if (address.Text == "")
            {
                label3.Visible = true;
                timer3.Start();
            }
            else if (password.Text == "")
            {
                label4.Visible = true;
                timer4.Start();
            }
            else if (username.Text.Length < 4)
            {

                label1.Text = "Username should be four character";
                label1.Visible = true;
                timer1.Start();
            }
            else if (username.Text.Length > 10)
            {

                label1.Text = "Username should not be more than ten character";
                label1.Visible = true;
                timer1.Start();
            }
            else if (password.Text.Length < 6)
            {

                label4.Text = "Password minimum six character";
                label4.Visible = true;
                timer4.Start();
            }
            else if (password.Text.Length > 14)
            {

                label4.Text = "Password maximum fourteen character";
                label4.Visible = true;
                timer4.Start();
            }
            else if (!mRegxExpression.IsMatch(email.Text))
            {

                label2.Visible = true;
                timer2.Start();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                profile.Image.Save(ms, profile.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "insert into customer(si,username,name,password,email,phone,address,pic) values (null,@username,@name,@password,@email,@phone,@address,@image)";

                cm.Parameters.AddWithValue("@username", username.Text);
                cm.Parameters.AddWithValue("@name", "mr user");
                cm.Parameters.AddWithValue("@password", password.Text);
                cm.Parameters.AddWithValue("@email", email.Text);
                cm.Parameters.AddWithValue("@phone", "01234567891");
                cm.Parameters.AddWithValue("@address", address.Text);
                cm.Parameters.AddWithValue("@image", img);
                con.Open();
                cm.ExecuteNonQuery();
             
                con.Close();

                MySqlCommand om = new MySqlCommand();
                om.Connection = con;
                om.CommandText = "insert into ratings values (@username,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)";

                om.Parameters.AddWithValue("@username", username.Text);
                con.Open();
                om.ExecuteNonQuery();
                MessageBox.Show("Your account has been created\nPlease login.", "Successful", MessageBoxButtons.OK);
                con.Close();

               
                Form1 mm = new Form1();
                
                mm.Show();
                timer5.Start();
            }

            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            
            mm.Show();
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                email.Focus();


            }
        }

        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                address.Focus();


            }
        }

        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                password.Focus();


            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton1_Click((object)sender, (EventArgs)e);
            }
        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {
            if (username.Text != "")
            {

                label1.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            password.isPassword = false;
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {
            password.isPassword = true;

            if (password.Text != "")
            {
                label4.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
            else if (password.Text == "" && password.isOnFocused != true)
            {
                password.isPassword = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            password.isPassword = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            password.isPassword = false;
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {
            if (email.Text != "")
            {

                label2.Visible = false;
            }
        }

        private void address_OnValueChanged(object sender, EventArgs e)
        {
            if (address.Text != "")
            {

                label3.Visible = false;
            }
        }
    }
}
