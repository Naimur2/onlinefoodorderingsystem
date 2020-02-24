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
            customize();
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

        private void customize()
        {
            panelfood.Visible = false;
            panelaccount.Visible = false;
           
        }
        private void hideSubMenu()
        {
            if (panelfood.Visible == true)
                panelaccount.Visible = false;
            if (panelaccount.Visible == true)
                panelfood.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            if (panelfood.Visible == false && panelaccount.Visible == true)
            {
                panelfood.Visible = true;
                panelaccount.Visible = false;

            }
            else
               if (panelfood.Visible == true && panelaccount.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;

            }
            else
               if (panelfood.Visible == false && panelaccount.Visible == false)
            {
                panelfood.Visible = true;
                panelaccount.Visible = false;

            }
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

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton4_MouseHover(object sender, EventArgs e)
        {
            panelfood.Height = 244;
        }

        private void bunifuButton4_MouseLeave(object sender, EventArgs e)
        {
            panelfood.Height = 61;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            
            if (panelaccount.Visible==false && panelfood.Visible==false)
            {

                panelaccount.Visible = true;
                panelfood.Visible = false;
                

            }
        else    if (panelaccount.Visible == false && panelfood.Visible == true)
            {

                panelaccount.Visible = true;
                panelfood.Visible = false;
               


            }
         else   if (panelaccount.Visible == true && panelfood.Visible == false)
            {

                panelaccount.Visible = false;
                panelfood.Visible = false;
                

            }

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            
            if (panelfood.Visible==false && panelaccount.Visible==true)
            {
                panelfood.Visible = true;
                panelaccount.Visible = false;
               
            }
            else
                if (panelfood.Visible == true && panelaccount.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
              
            }
            else
                if (panelfood.Visible == false && panelaccount.Visible == false)
            {
                panelfood.Visible = true;
                panelaccount.Visible = false;
               
            }

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
           
            if (panelfood.Visible == false && panelaccount.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;

                
            }
            else
               if (panelfood.Visible == true || panelaccount.Visible == true)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
               

            }
            openChildFormInPanel(new Form11(label1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form7(label1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form5(label1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new changepass(label1.Text, "customer"));
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
           
            if (panelfood.Visible == false && panelaccount.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
              
            }
            else
                 if (panelfood.Visible == true || panelaccount.Visible == true)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
                
            }
            openChildFormInPanel(new Form19("customer"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form21(label1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.openchild(new Form26(label1.Text), panel2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
