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
using System.Web;
using System.Net.Mail;
using System.Net;
namespace WindowsFormsApplication2
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form2 mm = new Form2();
            mm.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuLabel7_MouseHover(object sender, EventArgs e)
        {
            bunifuLabel7.ForeColor = Color.DarkBlue;
        }

        private void bunifuLabel7_MouseLeave(object sender, EventArgs e)
        {
            bunifuLabel7.ForeColor = Color.Magenta;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string details = textbox1.Text + "\r\n" + textbox2.Text + "\r\n" + textbox3.Text + "\r\n" + textbox4.Text + "\r\n" + textbox5.Text;
            Regex mRegxExpression = new Regex("^[a-zA -Z0-9_]{4,16}@[a-z0-9A-Z_]{2,10}.[a-z.A-Z0-9]{2,6}$");
            string query = "select * from applicant where aemail='" + this.textbox6.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            if (textbox1.Text=="")
            {
                fname.Visible = true;
            }
            else if (textbox2.Text == "")
            {
                lname.Visible = true;
            }
            else if (textbox3.Text == "")
            {
                sname.Visible = true;
            }
            else if (textbox4.Text == "")
            {
                saddress.Visible = true;
            }
            else if (textbox5.Text == "")
            {
                pno.Visible = true;
            }
            else if (textbox6.Text == "")
            {
                mail.Visible = true;
            }
          
          else  if (dt.Rows.Count == 1)
            {

                MessageBox.Show("Account already Exist,Please choose different email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox6.Focus();
            }
            else if (textbox1.Text.Length < 4)
            {

                fname.Visible = true;
            }
            else if (textbox2.Text.Length < 4)
            {
                lname.Visible = true;
                
            }
            else if (!mRegxExpression.IsMatch(textbox6.Text))
            {
                mail.Text = "Invalid email address";
                mail.Visible = true;
            }
            else if (Cryptography.vphone(textbox5.Text)==false)
            {
                pno.Text = "Invalid phone number";
                pno.Visible = true;
            }

            else
            {try
                {
                    string det = textbox1.Text + "\r\n" + textbox2.Text + "\r\n" + textbox3.Text + "\r\n" + textbox4.Text + "\r\n" + textbox5.Text;


                    string nam = textbox1.Text + " " + textbox2.Text;
                    MySqlCommand cm = new MySqlCommand();

                    cm.Connection = con;
                    cm.CommandText = "insert into applicant(si,aemail,details,Name,Shop,addr,Phone) values (@si,@aemail,@details,@name,@shop,@addr,@phone)";

                    cm.Parameters.AddWithValue("@si", null);

                    cm.Parameters.AddWithValue("@aemail", textbox6.Text);
                    cm.Parameters.AddWithValue("@details", det);
                    cm.Parameters.AddWithValue("@name", nam);
                    cm.Parameters.AddWithValue("@shop", textbox3.Text);
                    cm.Parameters.AddWithValue("@addr", textbox4.Text);
                    cm.Parameters.AddWithValue("@phone", textbox5.Text);

                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();
                    string body = "Hi " + textbox1.Text + " " + textbox2.Text + "Thanks for applying ,We will contact You soon" + "\r\n" + " Team asterisk";
                    try
                    {
                        Cryptography.mail(textbox6.Text, body, "Registration to asterix",1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid fmail", "Error");

                    }
                    MessageBox.Show("Thanks for applying,Please Check your inbox", "Success");

                }
                catch(Exception cc)
                {
                    MessageBox.Show("No internet", "Success");
                }

            }
        }

        private void textbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
