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

            log.like(11, label2, label3, "ratings");
            log.like(12, label5, label4, "ratings");
            log.like(13, label7, label6, "ratings");
            log.like(14, label9, label8, "ratings");

            log.like(15, label13, label12, "ratings");
            log.like(16, label15, label14, "ratings");
            log.like(17, label17, label16, "ratings");
            log.like(18, label11, label10, "ratings");

         

            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "11", like1, unlike1);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "12", like2, unlike2);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "13", like3, unlike3);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "14", like4, unlike4);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "15", like6, unlike6);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "16", like7, unlike7);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "17", like8, unlike8);
            Class1.likecolor(Cryptography.Encrypt(label1.Text), "ratings", "18", like5, unlike5);

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
      
public string bb(int foodno,string database)
        { 
            string query = "select sum(like"+ foodno + "),sum(unlike"+foodno+" )from "+database;

            MySqlDataAdapter data = new MySqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            data.Fill(dt);
            string kk= dt.Rows[0][0].ToString();

            return kk;
        }


        private void like1_Click(object sender, EventArgs e)
        {
            log.likebutton(11, label1.Text, like1, unlike1, label3, label2, "ratings");
          
        }

        private void like2_Click(object sender, EventArgs e)
        {
            log.likebutton(12, label1.Text, like2, unlike2, label4, label5, "ratings");

        }

        private void like3_Click(object sender, EventArgs e)
        {
            log.likebutton(13, label1.Text, like3, unlike3, label6, label7, "ratings");

        }

        private void like4_Click(object sender, EventArgs e)
        {
            log.likebutton(14, label1.Text, like4, unlike4, label8, label9, "ratings");

        }

        private void like6_Click(object sender, EventArgs e)
        {
            log.likebutton(15, label1.Text, like6, unlike6, label12, label13, "ratings");

        }

        private void like7_Click(object sender, EventArgs e)
        {
            log.likebutton(16, label1.Text, like7, unlike7, label14, label5, "ratings");

        }

        private void like8_Click(object sender, EventArgs e)
        {
            log.likebutton(17, label1.Text, like8, unlike8, label6, label7, "ratings");

        }

        private void like5_Click(object sender, EventArgs e)
        {
            log.likebutton(18, label1.Text, like5, unlike5, label10, label11, "ratings");

        }

        private void unlike1_Click(object sender, EventArgs e)
        {
            log.unlikebutton(11, label1.Text, like1, unlike1, label3, label2,"ratings");
           
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            
        }

        private void textbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textbox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textbox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textbox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            

            Class1.number(textbox1, textbox2, label62);
        }

        private void unlike2_Click(object sender, EventArgs e)
        {
            log.unlikebutton(12, label1.Text, like2, unlike2, label4, label5, "ratings");

        }

        private void unlike3_Click(object sender, EventArgs e)
        {
            log.unlikebutton(13, label1.Text, like3, unlike3, label6, label7, "ratings");

        }

        private void unlike4_Click(object sender, EventArgs e)
        {
            log.unlikebutton(14, label1.Text, like4, unlike4, label8, label9, "ratings");

        }

        private void unlike5_Click(object sender, EventArgs e)
        {
            log.unlikebutton(18, label1.Text, like5, unlike5, label10, label11, "ratings");

        }

        private void unlike6_Click(object sender, EventArgs e)
        {
            log.unlikebutton(15, label1.Text, like6, unlike6, label12, label13, "ratings");

        }

        private void unlike7_Click(object sender, EventArgs e)
        {
            log.unlikebutton(16, label1.Text, like7, unlike7, label14, label15, "ratings");

        }

        private void unlike8_Click(object sender, EventArgs e)
        {
            log.unlikebutton(17, label1.Text, like8, unlike8, label16, label17, "ratings");

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {
            Class1.number(textbox3, textbox4, label63);
        }

        private void textbox5_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox5, textbox6, label64);
        }

        private void textbox7_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox7, textbox8, label65);
        }

        private void textbox9_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox9, textbox10, label66);
        }

        private void textbox11_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox11, textbox12, label67);
        }

        private void textbox13_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox13, textbox14, label68);
        }

        private void textbox15_TextChanged(object sender, EventArgs e)
        {

            Class1.number(textbox15, textbox16, label69);
        }

        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton5_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton6_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton7_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton8_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton9_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton12_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton10_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton11_Click((object)sender, (EventArgs)e);
            }
        }

       

        private void textbox1_Enter(object sender, EventArgs e)

        { 


            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox3_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox5_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox7_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox9_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox11_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox13.Clear();
            textbox15.Clear();
        }

        private void textbox13_Enter(object sender, EventArgs e)
        {
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox1.Clear();
            textbox15.Clear();
        }

        private void textbox15_Enter(object sender, EventArgs e)
        {
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox1.Clear();
        }
    }
}
