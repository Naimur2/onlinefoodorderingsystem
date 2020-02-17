using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
