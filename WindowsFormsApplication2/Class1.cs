using Bunifu.Framework;
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
    class Class1
    {
        public static void number(System.Windows.Controls.TextBox textbox1, System.Windows.Controls.TextBox textbox2, System.Windows.Controls.Label labeltk)
        {
            
        }

        internal static void number(BunifuCustomTextbox textbox1, BunifuCustomTextbox textbox2, System.Windows.Forms.Label labeltk)
        {
            if (textbox1.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox1.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(labeltk.Text);

                        textbox2.Text = i.ToString();
                    }
                    else
                    {
                        textbox1.Text = "10";
                        System.Windows.Forms.MessageBox.Show("You can order at most 1 to 10");

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

        public static bool checkusername(String user)
        {
            bool a;
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            string query = " select * FROM manager where manager.mid = '" + user + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);


            string query1 = " select * FROM customer where customer.username = '" + user + "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);

            string query2 = " select * FROM admin where admin.masterid = '" + user + "'";
            MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            data2.Fill(dt2);

            string query3 = " select * FROM deliveryboy where  deliveryboy.user = '" + user + "'";
            MySqlDataAdapter data3 = new MySqlDataAdapter(query3, con);
            DataTable dt3 = new DataTable();
            data3.Fill(dt3);
            if(dt.Rows.Count==1|| dt1.Rows.Count == 1 || dt2.Rows.Count == 1 || dt3.Rows.Count == 1 )
            {

                a = false;
            }
            else
            {
                a = true;
            }
            return a;
        }



        public static void likecolor(String username,String database,String foodno,PictureBox like,PictureBox unlike)
        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());
            String query2 = "SELECT like" +foodno+ ",unlike"+foodno+"  FROM  "+database+"  where username= '"+ username+"'";
            MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            data2.Fill(dt2);
            int a = Int32.Parse(dt2.Rows[0][0].ToString());
            int b = Int32.Parse(dt2.Rows[0][1].ToString());
            if (a == 1 && b == 0)
            {

                like.BackColor = Color.LightBlue;
                unlike.BackColor = Color.Aqua;


            }
            else if (a == 0 && b == 1)
            {

                like.BackColor = Color.Aqua;
                unlike.BackColor = Color.LightBlue;


            }
            else if (a == 0 && b == 0)
            {

                like.BackColor = Color.White;
                unlike.BackColor = Color.White;

            }





        }
    }
}
