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
