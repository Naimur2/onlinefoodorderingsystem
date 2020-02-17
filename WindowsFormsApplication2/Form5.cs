using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        public Form5(string ms)
        {
            InitializeComponent();
            label1.Text = ms; 
            
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        
        Regex mg;
        private void Form5_Load(object sender, EventArgs e)
        {

            ree.Text = Cryptography.Encrypt( label1.Text);
            timer2.Start();
            label75.Text = DateTime.Now.ToShortDateString();
            label76.Text = DateTime.Now.ToShortTimeString();









            try
            {

                String query = "SELECT * FROM food";
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                data.Fill(dt);

                //money
                label62.Text = dt.Rows[0][2].ToString();
                label63.Text = dt.Rows[1][2].ToString();
                label64.Text = dt.Rows[2][2].ToString();
                label65.Text = dt.Rows[3][2].ToString();
                label66.Text = dt.Rows[4][2].ToString();
                label67.Text = dt.Rows[5][2].ToString();
                label68.Text = dt.Rows[6][2].ToString();
                label69.Text = dt.Rows[7][2].ToString();
                label70.Text = dt.Rows[8][2].ToString();
                label71.Text = dt.Rows[9][2].ToString();
                //food
                label22.Text = dt.Rows[0][1].ToString();
                label23.Text = dt.Rows[1][1].ToString();
                label24.Text = dt.Rows[2][1].ToString();
                label25.Text = dt.Rows[3][1].ToString();
                label26.Text = dt.Rows[4][1].ToString();
                label27.Text = dt.Rows[5][1].ToString();
                label28.Text = dt.Rows[6][1].ToString();
                label29.Text = dt.Rows[7][1].ToString();
                label30.Text = dt.Rows[8][1].ToString();
                label31.Text = dt.Rows[9][1].ToString();
                //details
                label32.Text = dt.Rows[0][3].ToString() + "\r\n" + dt.Rows[0][5].ToString();
                label33.Text = dt.Rows[1][3].ToString() + "\r\n" + dt.Rows[1][5].ToString();
                label34.Text = dt.Rows[2][3].ToString() + "\r\n" + dt.Rows[2][5].ToString();
                label35.Text = dt.Rows[3][3].ToString() + "\r\n" + dt.Rows[3][5].ToString();
                label36.Text = dt.Rows[4][3].ToString() + "\r\n" + dt.Rows[4][5].ToString();
                label37.Text = dt.Rows[5][3].ToString() + "\r\n" + dt.Rows[5][5].ToString();
                label38.Text = dt.Rows[6][3].ToString() + "\r\n" + dt.Rows[6][5].ToString();
                label39.Text = dt.Rows[7][3].ToString() + "\r\n" + dt.Rows[7][5].ToString();
                label40.Text = dt.Rows[8][3].ToString() + "\r\n" + dt.Rows[8][5].ToString();
                label41.Text = dt.Rows[9][3].ToString() + "\r\n" + dt.Rows[9][5].ToString();
                //photo
                if (dt.Rows[0][4] != null)
                {
                    try
                    {
                        byte[] img1 = (byte[])dt.Rows[0][4];
                        byte[] img2 = (byte[])dt.Rows[1][4];
                        byte[] img3 = (byte[])dt.Rows[2][4];
                        byte[] img4 = (byte[])dt.Rows[3][4];
                        byte[] img5 = (byte[])dt.Rows[4][4];
                        byte[] img6 = (byte[])dt.Rows[5][4];
                        byte[] img7 = (byte[])dt.Rows[6][4];
                        byte[] img8 = (byte[])dt.Rows[7][4];
                        byte[] img9 = (byte[])dt.Rows[8][4];
                        byte[] img10 = (byte[])dt.Rows[9][4];
                        MemoryStream ms1 = new MemoryStream(img1);
                        MemoryStream ms2 = new MemoryStream(img2);
                        MemoryStream ms3 = new MemoryStream(img3);
                        MemoryStream ms4 = new MemoryStream(img4);
                        MemoryStream ms5 = new MemoryStream(img5);
                        MemoryStream ms6 = new MemoryStream(img6);
                        MemoryStream ms7 = new MemoryStream(img7);
                        MemoryStream ms8 = new MemoryStream(img8);
                        MemoryStream ms9 = new MemoryStream(img9);
                        MemoryStream ms10 = new MemoryStream(img10);
                        pictureBox23.Image = Image.FromStream(ms1);
                        pictureBox24.Image = Image.FromStream(ms2);
                        pictureBox25.Image = Image.FromStream(ms3);
                        pictureBox26.Image = Image.FromStream(ms4);

                        pictureBox27.Image = Image.FromStream(ms5);
                        pictureBox28.Image = Image.FromStream(ms6);
                        pictureBox29.Image = Image.FromStream(ms7);
                        pictureBox30.Image = Image.FromStream(ms8);
                        pictureBox31.Image = Image.FromStream(ms9);
                        pictureBox32.Image = Image.FromStream(ms10);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }

                    String query1 = "SELECT sum(like1),sum(unlike1),sum(like2),sum(unlike2),sum(like3),sum(unlike3),sum(like4),sum(unlike4),sum(like5),sum(unlike5),sum(like6),sum(unlike6),sum(like7),sum(unlike7),sum(like8),sum(unlike8),sum(like9),sum(unlike9),sum(like10),sum(unlike10) FROM ratings";
                    MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
                    DataTable dt1 = new DataTable();
                    data1.Fill(dt1);
                    label2.Text = dt1.Rows[0][0].ToString();
                    label3.Text = dt1.Rows[0][1].ToString();

                    label5.Text = dt1.Rows[0][2].ToString();
                    label4.Text = dt1.Rows[0][3].ToString();

                    label7.Text = dt1.Rows[0][4].ToString();
                    label6.Text = dt1.Rows[0][5].ToString();

                    label9.Text = dt1.Rows[0][6].ToString();
                    label8.Text = dt1.Rows[0][7].ToString();

                    label11.Text = dt1.Rows[0][8].ToString();
                    label10.Text = dt1.Rows[0][9].ToString();

                    label13.Text = dt1.Rows[0][10].ToString();
                    label12.Text = dt1.Rows[0][11].ToString();

                    label15.Text = dt1.Rows[0][12].ToString();
                    label14.Text = dt1.Rows[0][13].ToString();

                    label17.Text = dt1.Rows[0][14].ToString();
                    label16.Text = dt1.Rows[0][15].ToString();

                    label19.Text = dt1.Rows[0][16].ToString();
                    label18.Text = dt1.Rows[0][17].ToString();

                    label21.Text = dt1.Rows[0][18].ToString();
                    label20.Text = dt1.Rows[0][19].ToString();


                    string username = Cryptography.Encrypt(label1.Text);

                    String query2 = "SELECT like1,unlike1,like2,unlike2, like3,unlike3, like4,unlike4, like5,unlike5, like6,unlike6, like7,unlike7, like8,unlike8, like9,unlike9, like10,unlike10 FROM ratings where username='" + username + "'";
                    MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
                    DataTable dt2 = new DataTable();
                    data2.Fill(dt2);
                    int a = Int32.Parse(dt2.Rows[0][0].ToString());
                    int b = Int32.Parse(dt2.Rows[0][1].ToString());
                    int c = Int32.Parse(dt2.Rows[0][2].ToString());
                    int d = Int32.Parse(dt2.Rows[0][3].ToString());
                    int ee = Int32.Parse(dt2.Rows[0][4].ToString());
                    int f = Int32.Parse(dt2.Rows[0][5].ToString());
                    int g = Int32.Parse(dt2.Rows[0][6].ToString());
                    int h = Int32.Parse(dt2.Rows[0][7].ToString());
                    int i = Int32.Parse(dt2.Rows[0][8].ToString());
                    int j = Int32.Parse(dt2.Rows[0][9].ToString());
                    int k = Int32.Parse(dt2.Rows[0][10].ToString());
                    int l = Int32.Parse(dt2.Rows[0][11].ToString());
                    int m = Int32.Parse(dt2.Rows[0][12].ToString());
                    int n = Int32.Parse(dt2.Rows[0][13].ToString());
                    int o = Int32.Parse(dt2.Rows[0][14].ToString());
                    int p = Int32.Parse(dt2.Rows[0][15].ToString());
                    int q = Int32.Parse(dt2.Rows[0][16].ToString());
                    int r = Int32.Parse(dt2.Rows[0][17].ToString());
                    int s = Int32.Parse(dt2.Rows[0][18].ToString());
                    int t = Int32.Parse(dt2.Rows[0][19].ToString());
                    //1
                    if (a == 1 && b == 0)
                    {

                        like1.BackColor = Color.LightBlue;
                        unlike1.BackColor = Color.Aqua;


                    }
                    else if (a == 0 && b == 1)
                    {

                        like1.BackColor = Color.Aqua;
                        unlike1.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like1.BackColor = Color.Aqua;
                        unlike1.BackColor = Color.Aqua;

                    }
                    //2
                    if (c == 1 && d == 0)
                    {

                        like2.BackColor = Color.LightBlue;
                        unlike2.BackColor = Color.Aqua;


                    }
                    else if (c == 0 && d == 1)
                    {

                        like2.BackColor = Color.Aqua;
                        unlike2.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like2.BackColor = Color.Aqua;
                        unlike2.BackColor = Color.Aqua;

                    }
                    //3
                    if (ee == 1 && f == 0)
                    {

                        like3.BackColor = Color.LightBlue;
                        unlike3.BackColor = Color.Aqua;


                    }
                    else if (ee == 0 && f == 1)
                    {

                        like3.BackColor = Color.Aqua;
                        unlike3.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like3.BackColor = Color.Aqua;
                        unlike3.BackColor = Color.Aqua;

                    }
                    //4
                    if (g == 1 && h == 0)
                    {

                        like4.BackColor = Color.LightBlue;
                        unlike4.BackColor = Color.Aqua;


                    }
                    else if (g == 0 && h == 1)
                    {

                        like4.BackColor = Color.Aqua;
                        unlike4.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like5.BackColor = Color.Aqua;
                        unlike5.BackColor = Color.Aqua;

                    }
                    //5
                    if (i == 1 && j == 0)
                    {

                        like5.BackColor = Color.LightBlue;
                        unlike5.BackColor = Color.Aqua;


                    }
                    else if (i == 0 && j == 1)
                    {

                        like5.BackColor = Color.Aqua;
                        unlike5.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like5.BackColor = Color.Aqua;
                        unlike5.BackColor = Color.Aqua;

                    }
                    //6

                    if (k == 1 && l == 0)
                    {

                        like6.BackColor = Color.LightBlue;
                        unlike6.BackColor = Color.Aqua;


                    }
                    else if (k == 0 && l == 1)
                    {

                        like6.BackColor = Color.Aqua;
                        unlike6.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like6.BackColor = Color.Aqua;
                        unlike6.BackColor = Color.Aqua;

                    }

                    //7
                    if (m == 1 && n == 0)
                    {

                        like7.BackColor = Color.LightBlue;
                        unlike7.BackColor = Color.Aqua;


                    }
                    else if (m == 0 && n == 1)
                    {

                        like7.BackColor = Color.Aqua;
                        unlike7.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like7.BackColor = Color.Aqua;
                        unlike7.BackColor = Color.Aqua;

                    }
                    //8
                    if (o == 1 && p == 0)
                    {

                        like8.BackColor = Color.LightBlue;
                        unlike8.BackColor = Color.Aqua;


                    }
                    else if (o == 0 && p == 1)
                    {

                        like8.BackColor = Color.Aqua;
                        unlike8.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like8.BackColor = Color.Aqua;
                        unlike8.BackColor = Color.Aqua;

                    }
                    //9
                    if (q == 1 && r == 0)
                    {

                        like9.BackColor = Color.LightBlue;
                        unlike9.BackColor = Color.Aqua;


                    }
                    else if (q == 0 && r == 1)
                    {

                        like9.BackColor = Color.Aqua;
                        unlike9.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like9.BackColor = Color.Aqua;
                        unlike9.BackColor = Color.Aqua;

                    }
                    //10
                    if (s == 1 && t == 0)
                    {

                        like10.BackColor = Color.LightBlue;
                        unlike10.BackColor = Color.Aqua;


                    }
                    else if (s == 0 && t == 1)
                    {

                        like10.BackColor = Color.Aqua;
                        unlike10.BackColor = Color.LightBlue;


                    }
                    else
                    {

                        like10.BackColor = Color.Aqua;
                        unlike10.BackColor = Color.Aqua;

                    }
                }
            }
            catch(Exception bb) {

                MessageBox.Show("Please check your connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
          
            
        }
        public void Order(string foodno,TextBox textbo)
        {
            String query = "SELECT tk FROM food where foodno='" + foodno + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            int price =Int32.Parse( dt.Rows[0][0].ToString());
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
                    { try {

                            int i = Int32.Parse(textbo.Text);

                            string j = (i * price).ToString();
                            MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = "insert into orders values (@ord_no,@username,@foodno,@amount,@tk,@status,@date,@time,@payment,@Message )";
                        cm.Parameters.AddWithValue("@ord_no", null);
                        cm.Parameters.AddWithValue("@username", user);
                        cm.Parameters.AddWithValue("@foodno", foodno);
                        cm.Parameters.AddWithValue("@amount", i.ToString());
                        cm.Parameters.AddWithValue("@tk",j);
                        cm.Parameters.AddWithValue("@status", "pending");
                        cm.Parameters.AddWithValue("@date", label75.Text);
                        cm.Parameters.AddWithValue("@time", label76.Text);
                        cm.Parameters.AddWithValue("@payment", "Pending");
                            cm.Parameters.AddWithValue("@Message", "Your order is pending");
                            con.Open();
                        cm.ExecuteNonQuery();
                        MessageBox.Show("     Your Order is placed, \nPlease checck your status at MyOrder");

                        con.Close();
                        textbox1.Clear();
                    }
                        catch(Exception b)
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
            Order("1",textbox1);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Order("2", textbox3);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            Order("3", textbox5);
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Order("4", textbox7);

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            Order("6", textbox9);
        
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            Order("5", textbox11);
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            Order("7", textbox13);
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            Order("8",textbox15);
       
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            Order("9", textbox17);
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            Order("10", textbox19);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='"+this.ree.Text+ "' and foodno=1";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like1.BackColor = Color.LightBlue;
                unlike1.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like1=1,unlike1=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like1),sum(unlike1) from ratings";
               
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
             
                DataTable dt = new DataTable();
              
                data.Fill(dt);
                label2.Text = dt.Rows[0][0].ToString();
                label3.Text = dt.Rows[0][1].ToString();



            }
            else {


                MessageBox.Show("Please oreder this food to give your opinion");

            }



        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=1";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike1.BackColor = Color.LightBlue;
                like1.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like1=0,unlike1=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like1),sum(unlike1) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label2.Text = dt.Rows[0][0].ToString();
                label3.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=2";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like2.BackColor = Color.LightBlue;
                unlike2.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like2=1,unlike2=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like2),sum(unlike2) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label5.Text = dt.Rows[0][0].ToString();
                label4.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=2";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike2.BackColor = Color.LightBlue;
                like2.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like2=0,unlike2=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like2),sum(unlike2) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label5.Text = dt.Rows[0][0].ToString();
                label4.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=3";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like3.BackColor = Color.LightBlue;
                unlike3.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like3=1,unlike3=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like3),sum(unlike3) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label7.Text = dt.Rows[0][0].ToString();
                label6.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=3";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike3.BackColor = Color.LightBlue;
                like3.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like3=0,unlike3=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like3),sum(unlike3) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label7.Text = dt.Rows[0][0].ToString();
                label6.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=4";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like4.BackColor = Color.LightBlue;
                unlike4.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like4=1,unlike4=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like4),sum(unlike4) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label9.Text = dt.Rows[0][0].ToString();
                label8.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=4";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike4.BackColor = Color.LightBlue;
                like4.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like4=0,unlike4=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like4),sum(unlike4) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label9.Text = dt.Rows[0][0].ToString();
                label8.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=5";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like5.BackColor = Color.LightBlue;
                unlike5.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like5=1,unlike5=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like5),sum(unlike5) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label11.Text = dt.Rows[0][0].ToString();
                label10.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=5";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike5.BackColor = Color.LightBlue;
                like5.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like5=0,unlike5=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like5),sum(unlike5) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label11.Text = dt.Rows[0][0].ToString();
                label10.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=6";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like6.BackColor = Color.LightBlue;
                unlike6.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like6=1,unlike6=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like6),sum(unlike6) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label13.Text = dt.Rows[0][0].ToString();
                label12.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=6";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike6.BackColor = Color.LightBlue;
                like6.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like6=0,unlike6=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like6),sum(unlike6) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label13.Text = dt.Rows[0][0].ToString();
                label12.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=7";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like7.BackColor = Color.LightBlue;
                unlike7.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like7=1,unlike7=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like7),sum(unlike7) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label15.Text = dt.Rows[0][0].ToString();
                label14.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=7";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike7.BackColor = Color.LightBlue;
                like7.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like7=0,unlike7=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like7),sum(unlike7) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label15.Text = dt.Rows[0][0].ToString();
                label14.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=8";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like8.BackColor = Color.LightBlue;
                unlike8.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like8=1,unlike8=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like8),sum(unlike8) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label17.Text = dt.Rows[0][0].ToString();
                label16.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=8";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike8.BackColor = Color.LightBlue;
                like8.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like8=0,unlike8=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like8),sum(unlike8) from ratings ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label17.Text = dt.Rows[0][0].ToString();
                label16.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=9";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like9.BackColor = Color.LightBlue;
                unlike9.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like9=1,unlike9=0 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like9),sum(unlike9) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label19.Text = dt.Rows[0][0].ToString();
                label18.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=8";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike9.BackColor = Color.LightBlue;
                like9.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like9=0,unlike9=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like9),sum(unlike9) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label19.Text = dt.Rows[0][0].ToString();
                label18.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=10";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like10.BackColor = Color.LightBlue;
                unlike10.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like10=1,unlike10=0 where username='" + this.ree.Text + "' ";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like10),sum(unlike10) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label21.Text = dt.Rows[0][0].ToString();
                label20.Text = dt.Rows[0][1].ToString();



            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            String query1 = "SELECT * from orders where username='" + this.ree.Text + "' and foodno=10";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                unlike10.BackColor = Color.LightBlue;
                like10.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update ratings set like10=0,unlike10=1 where username='" + this.ree.Text + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                string query = "select sum(like10),sum(unlike10) from ratings";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                label21.Text = dt.Rows[0][0].ToString();
                label20.Text = dt.Rows[0][1].ToString();
            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (textbox1.Text!="")
            {

                try
                {
                    int c = Int32.Parse(textbox1.Text);
                    if (c < 11 && c>0)
                    {

                        int i = c * Int32.Parse(label62.Text);

                        textbox2.Text = i.ToString();
                    }
                    else
                    {
                        textbox1.Text = "10";
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox1.Clear();
                }




            }
            else if (textbox1.Text == "")
            {
                textbox2.Text = "";

            }



        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {
            if (textbox3.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox3.Text);
                    if (c < 11 && c>0)
                    {

                        int i = c * Int32.Parse(label63.Text);

                        textbox4.Text = i.ToString();
                    }
                    else
                    {
                        textbox3.Text = "10";
                       
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox3.Clear();
                }




            }
            else if (textbox3.Text == "")
            {
                textbox4.Text = "";

            }
        }

        private void bunifuCustomTextbox6_TextChanged(object sender, EventArgs e)
        {
            if (textbox5.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox5.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label64.Text);

                        textbox6.Text = i.ToString();
                    }
                    else
                    {
                        textbox5.Text = "10";
              
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox5.Clear();
                }




            }
            else if (textbox5.Text == "")
            {
                textbox6.Text = "";

            }
        }

        private void bunifuCustomTextbox8_TextChanged(object sender, EventArgs e)
        {
            if (textbox7.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox7.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label65.Text);

                        textbox8.Text = i.ToString();
                    }
                    else
                    {
                        textbox7.Text = "10";
                        MessageBox.Show("You can order at most 1 to 10");
                      
                    }

                }
                catch (Exception ex)
                {

              
                    textbox7.Clear();
                }




            }
            else if (textbox7.Text == "")
            {
                textbox8.Text = "";

            }
        }

        private void bunifuCustomTextbox10_TextChanged(object sender, EventArgs e)
        {
            if (textbox9.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox9.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label66.Text);

                        textbox10.Text = i.ToString();
                    }
                    else
                    {
                        textbox9.Text = "10";
                       
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                   
                    textbox9.Clear();
                }




            }
            else if (textbox9.Text == "")
            {
                textbox10.Text = "";

            }
        }

        private void bunifuCustomTextbox12_TextChanged(object sender, EventArgs e)
        {
            if (textbox11.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox11.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label67.Text);

                        textbox12.Text = i.ToString();
                    }
                    else
                    {
                        textbox11.Text = "10";
                       
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox11.Clear();
                }




            }
            else if (bunifuCustomTextbox11.Text == "")
            {
                textbox11.Text = "";

            }
        }

        private void bunifuCustomTextbox16_TextChanged(object sender, EventArgs e)
        {
            if (textbox13.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox13.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label68.Text);

                        textbox14.Text = i.ToString();
                    }
                    else
                    {
                        textbox13.Text = "10";
                      
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                   
                    textbox13.Clear();
                }




            }
            else if (textbox13.Text == "")
            {
                textbox14.Text = "";

            }
        }

        private void bunifuCustomTextbox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox14_TextChanged(object sender, EventArgs e)
        {
            if (textbox15.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox15.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label69.Text);

                        textbox16.Text = i.ToString();
                    }
                    else
                    {
                        textbox15.Text = "10";
                        
                        MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox15.Clear();
                }




            }
            else if (textbox15.Text == "")
            {
                textbox16.Text = "";

            }
        }

        private void bunifuCustomTextbox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox18_TextChanged(object sender, EventArgs e)
        {
            if (textbox17.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox17.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label70.Text);

                        textbox18.Text = i.ToString();
                    }
                    else
                    {
                        textbox17.Text = "10";
                        MessageBox.Show("You can order at most 1 to 10");
                        
                    
                    }

                }
                catch (Exception ex)
                {

                   
                    textbox17.Clear();
                }




            }
            else if (textbox17.Text == "")
            {
                textbox18.Text = "";

            }
        }

        private void bunifuCustomTextbox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox20_TextChanged(object sender, EventArgs e)
        {
            if (textbox19.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox19.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(label62.Text);

                        textbox20.Text = i.ToString();
                    }
                    else
                    {
                        textbox19.Text = "10";
                        MessageBox.Show("You can order at most 1 to 10");
                       

                    }

                }
                catch (Exception ex)
                {

                    
                    textbox19.Clear();
                }




            }
            else if (textbox19.Text == "")
            {
                textbox20.Text = "";

            }
        }

        private void bunifuCustomTextbox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
          
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox4_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox6_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox8_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
           
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox10_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox12_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox16_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
        
            textbox15.Clear();
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox14_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
           
            textbox17.Clear();
            textbox19.Clear();
        }

        private void bunifuCustomTextbox18_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
           
            textbox19.Clear();
        }

        private void bunifuCustomTextbox20_Enter(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox3.Clear();
            textbox5.Clear();
            textbox7.Clear();
            textbox9.Clear();
            textbox11.Clear();
            textbox13.Clear();
            textbox15.Clear();
            textbox17.Clear();
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            label76.Text = DateTime.Now.ToShortTimeString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
            
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

        private void textbox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton12_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton13_Click((object)sender, (EventArgs)e);
            }
        }

        private void textbox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuButton14_Click((object)sender, (EventArgs)e);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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
    }
}
