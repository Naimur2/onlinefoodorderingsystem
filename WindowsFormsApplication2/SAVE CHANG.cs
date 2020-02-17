using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication2
{
    public partial class SAVE : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // width of ellipse
                 int nHeightEllipse // height of ellipse

             );
        public SAVE(string a,string b, string c,string d,string e,string f, System.Drawing.Image i)
        {
            InitializeComponent();
            label2.Text = a;
            label3.Text = b;
            label4.Text = c;
            label5.Text = d;
            label6.Text = e;
            label7.Text = f;
            pictureBox3.Image = i;
        }

        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void SAVE_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            if (label2.Text == "")
            {
                label1.Text = "Food name is required";
                button3.Visible = false;
                button2.Left = button3.Left;
                button2.ButtonText = "OK";
            }
            else if (label3.Text == "")
            {
                label1.Text = "Price is required";
                button3.Visible = false;
                button2.Left = button3.Left;
                button2.ButtonText = "OK";
            }
           else if (label4.Text == ""||label4.Text.Length<30|| label4.Text.Length>45)
            {
                label1.Text = "Details is required";
                button3.Visible = false;
                button2.Left = button3.Left;
                button2.ButtonText = "OK";
            }
           

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "")
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);
                    byte[] img = ms.ToArray();



                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "update food set foodname=@foodname,tk=@price,detais=@details1,details2=@details2 ,image=@img where foodno=@foodno and mid=@username";

                    cm.Parameters.AddWithValue("@foodname", label2.Text);
                    cm.Parameters.AddWithValue("@price", label3.Text);
                    cm.Parameters.AddWithValue("@details1", label4.Text);

                    cm.Parameters.AddWithValue("@details2", label5.Text);
                    cm.Parameters.AddWithValue("@foodno", label6.Text);
                    cm.Parameters.AddWithValue("@username", label7.Text);
                    cm.Parameters.AddWithValue("@img", img);
                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    label1.Text = "Image is out of memory";
                    button2.Visible = false;
                    button3.Visible = false;
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Hide();
            timer1.Stop();
        }
    }
}
