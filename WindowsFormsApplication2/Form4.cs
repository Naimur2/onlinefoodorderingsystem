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
   
    public partial class Form4 : Form
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
        public Form4(string ms)
        {
            InitializeComponent();
            label1.Text = ms;

        }
        int count;
        private void Form4_Load(object sender, EventArgs e)
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
            if (rectangleShape2.Width >= 320)
            {

                timer1.Stop();
                
                Form20 nn = new Form20(label1.Text);
                nn.Show();
                this.Hide();
            }
        }
    }
}
