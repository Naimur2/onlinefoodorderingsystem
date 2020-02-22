using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        public Form9(string mm)
        {
            InitializeComponent();
            label1.Text = mm;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            log.openchild(new Form22(label1.Text),panel2);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            log.openchild(new Form16(label1.Text), panel2);

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            log.openchild(new Form14(label1.Text), panel2);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
           
            label73.Text = DateTime.Now.ToShortTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            log.openchild(new Form19("manager"), panel2);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            log.logout(this);

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            log.openchild(new changepass(label1.Text,"admin"), panel2);

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            log.openchild(new admin(), panel2);

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            log.openchild(new Form10(), panel2);
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            log.openchild(new Form14(label1.Text), panel2);
        }
    }
}
