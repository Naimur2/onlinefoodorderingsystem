using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class log
    {
       
        public static void logout(Form active)
        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            string message = "Do you want to logout?";
            string title = "Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                Form2 gg = new Form2();
                gg.Show();
                active.Hide();
                MySqlCommand cm = new MySqlCommand();

                cm.Connection = con;
                cm.CommandText = "UPDATE `session` SET `username`=@username,`password`=@password WHERE si= 1 ";

                cm.Parameters.AddWithValue("@username", "D7whkN8qe+c=");

                cm.Parameters.AddWithValue("@password", "D7whkN8qe+c=");
                con.Open();
                cm.ExecuteNonQuery();

                con.Close();

            }
            else
            {

            }
        }
        public static void like(int foodno,Label like,Label unlike,string data)
        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            string likee = "like" + foodno.ToString();
            string unlikee = "unlike" + foodno.ToString();
            
            String query1 = "SELECT sum("+likee+"),sum("+unlikee+ ") FROM   "+ data;
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            like.Text = dt1.Rows[0][0].ToString();
            unlike.Text = dt1.Rows[0][1].ToString();
        }


      


        public static void likebutton(int foodno,string username,PictureBox like,PictureBox unlike,Label unliker,Label liker,string database)


        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            String query1 = "SELECT * from orders where username='" +Cryptography.Encrypt( username) + "' and foodno='" + foodno + "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {
                like.BackColor = Color.LightBlue;
                unlike.BackColor = Color.Aqua;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                string likee = "like"+ foodno;
                string unlikee = "unlike"+ foodno;
                string use = Cryptography.Encrypt(username);
                cm.CommandText = "update ratings set  " +likee+ "=1,"+ unlikee + "=0" + "  where username='"+use+"'"  ;

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();

                log.like(foodno, liker, unliker,database);

            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }


        public static void unlikebutton(int foodno, string username, PictureBox like, PictureBox unlike, Label unliker, Label liker,string database)


        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            String query1 = "SELECT * from orders where username='" + Cryptography.Encrypt(username) + "' and foodno='" + foodno + "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            if (dt1.Rows.Count > 0)


            {

                like.BackColor = Color.Aqua;
                unlike.BackColor = Color.LightBlue;
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                string likee = "like" + foodno;
                string unlikee = "unlike" + foodno;
                string use = Cryptography.Encrypt(username);
                cm.CommandText = "update ratings set  " + likee + "=0," + unlikee + "=1" + "  where username='" + use + "'";

                con.Open();
                cm.ExecuteNonQuery();
                con.Close();

              

                log.like(foodno, liker, unliker, database);


            }
            else
            {


                MessageBox.Show("Please oreder this food to give your opinion");

            }
        }









        public static void details(int foodn, Label money, Label foodname, Label details, PictureBox ima)
        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            String query = "SELECT * FROM food where foodno='" + foodn + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            money.Text = dt.Rows[0][2].ToString();
            foodname.Text = dt.Rows[0][1].ToString();
            details.Text = dt.Rows[0][3].ToString() + "\r\n" + dt.Rows[0][5].ToString();
            if (dt.Rows[0][4] != null)
            {
                try
                {
                    byte[] img1 = (byte[])dt.Rows[0][4];
                    MemoryStream ms1 = new MemoryStream(img1);
                    ima.Image = Image.FromStream(ms1);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }







        public static Form activeForm = null;
       public static void openchild(Form childForm,Panel p)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void Exit()
        {
            Form8 n = new Form8();
            n.Show();

        }
    }
    

 
}
