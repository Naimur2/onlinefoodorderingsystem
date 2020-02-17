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
using System.IO;
using Bunifu.UI.WinForms.BunifuButton;

namespace WindowsFormsApplication2
{
    public partial class admin : Form
    {
        public admin(string ma)
        {
            InitializeComponent();
            label1.Text = ma;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            b5_Click((object)sender, (EventArgs)e);
            timer1.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();
            bunifuButton2_Click((object)sender, (EventArgs)e);

        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
           
            label73.Text = DateTime.Now.ToShortTimeString();
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void enable(BunifuButton a, BunifuButton b)
        {
            
            a.Enabled = false;
           b.Enabled = true;
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form10());
            b1.Enabled = false;
            b2.Enabled = true;
            
            b3.Enabled = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            enable(b2, b1);
        }

        private void b4_Click(object sender, EventArgs e)
        {
           
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = false;
            b3.Enabled = true;
            log.openchild(new Form19(""), panel4);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b3_Click_1(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = false;


        }
    }
}
