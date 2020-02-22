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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuLabel2.Visible = false;
        }
        int count;
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {
            Textbox2.isPassword = true;

            if (Textbox2.Text != "")
            {
                bunifuLabel3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
            else if (Textbox2.Text == "" && Textbox2.isOnFocused!=true)
            {
                Textbox2.isPassword = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            Textbox2.isPassword = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            Textbox2.isPassword = true;
        }

        private void Textbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox1.Text != "")
            {

                bunifuLabel3.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            WindowState = FormWindowState.Minimized;

        }

        private void Textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Textbox2.Focus();


            }
        }

        





        public void login()
        {
            try
            {
                string username = Cryptography.Encrypt(Textbox1.Text);

                string password = Cryptography.Encrypt(Textbox2.Text);
                Regex mg = new Regex("^[a-zA-Z0-9]{5,11}@[a]{1}[d]{1}[m]{1}[i]{1}[n]{1}.[a]{1}[s]{1}$");
                Regex oo = new Regex("^[a-zA-Z0-9]{5,11}@[s]{1}[h]{1}[o]{1}[p]{1}.[a]{1}[s]{1}$");
                Regex ox = new Regex("^[a-zA-Z0-9]{5,11}@[d]{1}[e]{1}[l]{1}[i]{1}[v]{1}[e]{1}[r]{1}[y]{1}.[a]{1}[s]{1}$");

                Regex og = new Regex("^{a-zA-Z0-9}$");
                count = count + 1;

                if (count > 3)
            {


                MessageBox.Show("Your System Has been Blocked", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
            else if (Textbox1.Text == "")
            {


                bunifuLabel2.Visible = true;
                timer1.Start();
                count = count - 1;

            }
            else if (Textbox2.Text == "")
            {


                bunifuLabel3.Visible = true;
                timer2.Start();
                count = count - 1;
            }

            else
                {
                    if (Textbox2.Text.Length > 12)
                    {
                        if (oo.IsMatch(Textbox2.Text))
                        {
                            string query = "select * from manager where mid='" + username + "' and  keycode='" + password + "'";

                            MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                            DataTable dt = new DataTable();

                            data.Fill(dt);

                            if (dt.Rows.Count == 1)
                            {


                                defaul();


                                
                             Form14 tt = new Form14(Textbox1.Text);
                              Form16 ss = new Form16(Textbox1.Text);
                               myshop c = new myshop(Textbox1.Text);
                               Form17 cc = new Form17("a", Textbox1.Text);

                               cc.Show();
                                timer3.Start();


                            }

                            else
                            {
                                MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (mg.IsMatch(Textbox2.Text))
                        {
                            string query = "select * from admin where masterid='" + username + "' and  masterkey='" + password + "'";
                            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                            DataTable dt = new DataTable();
                            data.Fill(dt);

                            if (dt.Rows.Count == 1 && bunifuCheckBox1.Checked)
                            {
                                defaul();

                                admin ss = new admin();
                                Form17 cc = new Form17("b", Textbox1.Text);
                                cc.Show();
                                timer3.Start();


                            }


                            else
                            {

                                MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                        }

                        else if (ox.IsMatch(Textbox2.Text))
                        {
                            string query = "select * from deliveryboy where user='" + username + "' and  Password='" + password + "'";

                            MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                            DataTable dt = new DataTable();

                            data.Fill(dt);

                            if (dt.Rows.Count == 1)
                            {


                                defaul();

                                Form17 cc = new Form17("c", Textbox1.Text);

                                cc.Show();
                                timer3.Start();


                            }

                            else
                            {
                                MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }




                    }




                    else
                    {
                        string query = "select * from customer where username='" + username + "' and  password='" + password + "'";

                        MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                        DataTable dt = new DataTable();

                        data.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {



                            defaul();

                            Form11 tt = new Form11(Textbox1.Text);
                            Form5 ss = new Form5(Textbox1.Text);
                            Form17 cc = new Form17("d",Textbox1.Text);

                            cc.Show();
                            timer3.Start();

                        }

                        else
                        {

                            MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }


            }

        }
            catch (Exception ex)
            {


                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }






}


public void defaul()
        {
            if (!CheckBox1.Checked)
            {
                MySqlCommand cm = new MySqlCommand();

                cm.Connection = con;
                cm.CommandText = "UPDATE `session` SET `username`=@username,`password`=@password WHERE si= 1 ";

                cm.Parameters.AddWithValue("@username", "D7whkN8qe+c=");

                cm.Parameters.AddWithValue("@password", "D7whkN8qe+c=");
                con.Open();
                cm.ExecuteNonQuery();

                con.Close();
            }
            else if (CheckBox1.Checked)
            {
                update();

            }
        }
        public void update()

        {

            string user = Cryptography.Encrypt(Textbox1.Text);
            string pass = Cryptography.Encrypt(Textbox2.Text);

            MySqlCommand cm = new MySqlCommand();
            cm.Connection = con;
            cm.CommandText = "UPDATE `session` SET `username`=@username,`password`=@password WHERE si= 1 ";

            cm.Parameters.AddWithValue("@username", user);

            cm.Parameters.AddWithValue("@password", pass);

            con.Open();
            cm.ExecuteNonQuery();

            con.Close();



        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
               


}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void Textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton1_Click((object)sender, (EventArgs)e);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Textbox2.isPassword = false;

           




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bunifuLabel3.Visible = false;

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form6 vv = new Form6();
            vv.Show();
            timer3.Start();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {
            Form13 gg = new Form13();
            gg.Show();
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            Form12 vv = new Form12();
            vv.Show();
            timer3.Start();
        }

      

        private void bunifuLabel4_MouseHover(object sender, EventArgs e)
        {
            bunifuLabel4.ForeColor = Color.DarkBlue;

        }

        private void bunifuLabel4_MouseLeave(object sender, EventArgs e)
        {
            bunifuLabel4.ForeColor = Color.Magenta;

        }

        private void bunifuCheckBox4_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            
            }


        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

            login();
        }

        private void Textbox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void Textbox2_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void bunifuLabel7_Click_1(object sender, EventArgs e)
        {
            Form13 gg = new Form13();
            gg.Show();
        }

        private void bunifuLabel7_MouseHover(object sender, EventArgs e)
        {
            bunifuLabel5.ForeColor = Color.DarkBlue;
        }

        private void bunifuLabel7_MouseLeave(object sender, EventArgs e)
        {
            bunifuLabel5.ForeColor = Color.Magenta;
        }
    }
}
