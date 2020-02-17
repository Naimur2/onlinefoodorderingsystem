using MySql.Data.MySqlClient;
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
    public partial class Form20 : Form
    {
        public Form20(string mm)
        {
            InitializeComponent();
            label1.Text = mm;
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form5(label1.Text));
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form21(label1.Text));
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form11(label1.Text));
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();
            log.openchild(new Form5(label1.Text), panel2);
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
    }
}
