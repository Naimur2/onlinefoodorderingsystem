using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form21 : Form
    {
        public Form21(string nn)
        {
            InitializeComponent();

            label1.Text = nn;
        }

        MySqlConnection con = new MySqlConnection(Cryptography.con());

       
       
        private void Form21_Load(object sender, EventArgs e)
        {
            log.details(11, label62, label22, label32, pictureBox1);
            log.details(12, label63, label23, label33, pictureBox2);
            log.details(13, label64, label24, label34, pictureBox3);
            log.details(14, label65, label25, label35, pictureBox4);
            log.details(15, label67, label27, label37, pictureBox6);
            log.details(16, label68, label28, label38, pictureBox7);
            log.details(17, label69, label29, label39, pictureBox8);
            log.details(18, label66, label26, label36, pictureBox5);
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Order(string foodno, TextBox textbo)
        {
            String query = "SELECT tk FROM food where foodno='" + foodno + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            int price = Int32.Parse(dt.Rows[0][0].ToString());
            if (textbo.Text != "")
            {
                try
                {
                    string user = Cryptography.Encrypt(label1.Text);
                    string message = "Do you want to order this food?";
                    string title = "Order";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {

                            int i = Int32.Parse(textbo.Text);

                            string j = (i * price).ToString();
                            MySqlCommand cm = new MySqlCommand();
                            cm.Connection = con;
                            cm.CommandText = "insert into orders values (@ord_no,@username,@foodno,@amount,@tk,@status,@date,@time,@payment,@Message )";
                            cm.Parameters.AddWithValue("@ord_no", null);
                            cm.Parameters.AddWithValue("@username", user);
                            cm.Parameters.AddWithValue("@foodno", foodno);
                            cm.Parameters.AddWithValue("@amount", i.ToString());
                            cm.Parameters.AddWithValue("@tk", j);
                            cm.Parameters.AddWithValue("@status", "pending");
                            cm.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                            cm.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
                            cm.Parameters.AddWithValue("@payment", "Pending");
                            cm.Parameters.AddWithValue("@Message", "Your order is pending");
                            con.Open();
                            cm.ExecuteNonQuery();
                            MessageBox.Show("     Your Order is placed,     \nPlease checck your status at MyOrder");

                            con.Close();
                            textbox1.Clear();
                        }
                        catch (Exception b)
                        {
                            MessageBox.Show("Please check your connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        textbox1.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textbox1.Clear();
                }
            }
            else
            {
                textbox1.Focus();
                MessageBox.Show("Select your quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Order("11", textbox1);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Order("12", textbox3);

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            Order("13", textbox5);

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Order("14", textbox7);

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            Order("15", textbox11);

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            Order("16", textbox13);

        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            Order("17", textbox15);

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            Order("18", textbox9);

        }
    }
}
