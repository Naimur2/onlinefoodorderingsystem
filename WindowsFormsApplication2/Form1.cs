using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
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
        public Form1( string user,string pass)
        {
            InitializeComponent();
            label1.Text =Cryptography.Decrypt( user);
            label2.Text = Cryptography.Decrypt(pass);
        }
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
        





            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 5;
            rectangleShape2.Width += 20;
            count += 20;
            if (rectangleShape2.Width >= 318)
            {
                if (label1.Text == "abcde" && label2.Text == "abcde")
                {

                    Form2 nn = new Form2();
                    nn.Show();
                    this.Hide();
                    timer1.Stop();
                }
                else 
                {
                    Regex mg = new Regex("^[a-zA-Z0-9]{5,11}@[a]{1}[d]{1}[m]{1}[i]{1}[n]{1}.[a]{1}[s]{1}$");
                    Regex oo = new Regex("^[a-zA-Z0-9]{5,11}@[s]{1}[h]{1}[o]{1}[p]{1}.[a]{1}[s]{1}$");
                    Regex ox = new Regex("^[a-zA-Z0-9]{5,11}@[d]{1}[e]{1}[l]{1}[i]{1}[v]{1}[e]{1}[r]{1}[y]{1}.[a]{1}[s]{1}$");
                    Regex og = new Regex("^{a-zA-Z0-9}$");
                    if (label2.Text.Length > 12)
                    {

                        if (oo.IsMatch(label2.Text))
                        {
                            Form14 tt = new Form14(label1.Text);
                            Form16 ss = new Form16(label1.Text);
                            myshop c = new myshop(label1.Text);
                            Form23 cc = new Form23(label1.Text);

                            cc.Show();
                            this.Hide();
                            timer1.Stop();
                        }
                        else if (mg.IsMatch(label2.Text))
                        {

                            Form17 cc = new Form17("d", label1.Text);
                            cc.Show();
                            this.Hide();
                            timer1.Stop();

                        }
                        else if (ox.IsMatch(label2.Text))
                        {

                          //  Form23 cc = new Form23(label1.Text);
                        //    cc.Show();
                         //   this.Hide();
                        //    timer1.Stop();

                        }
                    }
                    else
                    {

                        Form11 tt = new Form11(label1.Text);
                        Form5 ss = new Form5(label1.Text);
                        Form4 cc = new Form4(label1.Text);

                        cc.Show();
                        this.Hide();
                        timer1.Stop();
                    }

                    }

            }
        }
    }
}
