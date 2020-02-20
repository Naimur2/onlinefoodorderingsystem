using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication2
{
    public partial class Form17 : Form
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
        public Form17(string ms,string cm)
        {
            InitializeComponent();
            
            label2.Text = ms;
            label1.Text = cm;

        }
        int count = 0;

        private void Form17_Load(object sender, EventArgs e)
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
                if (label2.Text == "a")
                {
                    timer1.Stop();
                    Form23 nn = new Form23(label1.Text);
                    nn.Show();
                    this.Hide();
                }
                else
                if (label2.Text == "d")
                {
                    timer1.Stop();
                    admin nn = new admin(label1.Text);
                    nn.Show();
                    this.Hide();
                }
                else
                if (label2.Text == "x")
                {
                    timer1.Stop();
                   Form23 nn = new Form23(label1.Text);
                    nn.Show();
                    this.Hide();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
