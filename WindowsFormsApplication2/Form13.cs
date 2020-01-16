using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form13 : Form
    {
        public Form13(string ms)
        {
            InitializeComponent();
         
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");
        private void Form13_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form14 v = new Form14();
            v.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
          
           
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            bunifuLabel5.Visible = false;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            bunifuLabel7.Visible = false;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            bunifuLabel9.Visible = false;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            bunifuLabel10.Visible = false;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            bunifuLabel11.Visible = false;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
           


        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }
    }
}
