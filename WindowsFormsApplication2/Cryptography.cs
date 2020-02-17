using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace WindowsFormsApplication2
{
    class Cryptography
    {

        public static string Encrypt(string encryptString)
        {
            string hash = "f0xle@rn";
            byte[] data = UTF8Encoding.UTF8.GetBytes(encryptString);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encryptString = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return encryptString;
        }

        public static string Decrypt(string cipherText)
        {
            string hash = "f0xle@rn";
            byte[] data = Convert.FromBase64String(cipherText);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Decrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    cipherText = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return cipherText;
        }






        public static string con()
        {

            return "server=localhost;database=foodbank;username=root;password=;";

        }


       






        public static void mail(string email, string inbox, string subjrct,int i)
        {
            MySqlConnection con = new MySqlConnection(Cryptography.con());

            if (i==1)
            {
                string query = "select * from server where user='admin' ";
                
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
               
                DataTable dt = new DataTable();
             
                data.Fill(dt);
                string mail = Cryptography.Decrypt(dt.Rows[0][1].ToString());
                int port = Int32.Parse(  dt.Rows[0][2].ToString());
                string host = dt.Rows[0][3].ToString();
                string pass= Cryptography.Decrypt(dt.Rows[0][4].ToString());

                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress(mail);
                    message.To.Add(new MailAddress(email));
                    message.Subject = subjrct;
                    message.IsBodyHtml = true; //to make message body as html  

                    message.Body = inbox;

                    smtp.Port = port;
                    smtp.Host = host; //for gmail host  
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(mail, pass);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }




            }
            else if (i ==2)
            {
                string query = "select * from server where user='manager' ";

                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);
                string mail = Cryptography.Decrypt(dt.Rows[0][1].ToString());
                string port = dt.Rows[0][2].ToString();
                string host = dt.Rows[0][3].ToString();
                string pass = Cryptography.Decrypt(dt.Rows[0][4].ToString());
            }

        


        }
        public static void send(string message,string to,string status,string catagory)
            {
            MySqlConnection con = new MySqlConnection(Cryptography.con());
            string query = "select admin.mastermail from admin ";
          

            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            

           
            DataTable dt = new DataTable();

            data.Fill(dt);
            string from = dt.Rows[0][0].ToString();

          
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = con;
            cm.CommandText = "insert into message values (@null,@from,@message,@to,@catagory,@date,@time,@status )";
            cm.Parameters.AddWithValue("@null", null);
            cm.Parameters.AddWithValue("@from", from);
            cm.Parameters.AddWithValue("@message", message);
            cm.Parameters.AddWithValue("@to", to);
            cm.Parameters.AddWithValue("@catagory", catagory);
            cm.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
            cm.Parameters.AddWithValue("@time", DateTime.Now.ToShortTimeString());
            cm.Parameters.AddWithValue("@status", status);

            con.Open();
            cm.ExecuteNonQuery();

            con.Close();



        }
        

        public static bool vmail(string c)
        {
            Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            bool a;
            if (!mRegxExpression.IsMatch(c))
            {
                 a = false;
            }
            else
            {
                a= true;

            }
            return a;
        }

        public static bool vphone(string c)
        {
            Regex mRegxExpression = new Regex("^01+[0-9]{1}[0-9]{8}");
            bool a;
            if (!mRegxExpression.IsMatch(c))
            {
                a = false;
            }
            else
            {
                a = true;

            }
            return a;
        }
    }

    
}
