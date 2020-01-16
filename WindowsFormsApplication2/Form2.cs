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
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {try { 
            string username = Textbox1.Text;

            string password = Textbox2.Text;

            string query = "select * from customer where username='" + username + "' and  password='" + password + "'";
            string query2 = "select * from customer where email='" + username + "' and  password='" + password + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            MySqlDataAdapter bata = new MySqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            DataTable ct = new DataTable();
            data.Fill(dt);
            bata.Fill(ct);
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
            else if (!bunifuCheckBox1.Checked)
            {
                MessageBox.Show("You should accept our terms", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count = count - 1;
            }
            else
            {


                if (dt.Rows.Count == 1)
                {





                        Form11 tt = new Form11(Textbox1.Text);
                        Form5 ss = new Form5(Textbox1.Text);
                    Form4 cc = new Form4(Textbox1.Text);
                    Form9 ok = new Form9(Textbox1.Text);
                    cc.Show();
                        timer3.Start();


                }
                else if (ct.Rows.Count == 1)
                {
                        Form11 tt = new Form11(Textbox1.Text);
                        Form5 ss = new Form5(Textbox1.Text);
                    Form4 cc = new Form4(Textbox1.Text);
                   Form7 gg = new Form7(Textbox1.Text);
                    cc.Show();
                        timer3.Start();
                    }
                else
                {
                    MessageBox.Show("Your Username or Password is Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
            catch (Exception ex)
            {


                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }
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
    }
}
