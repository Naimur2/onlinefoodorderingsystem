using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class Form23 : Form
    {
        public Form23(string bb)
        {
            InitializeComponent();
            customize();
            label1.Text = bb;
        }
        private void Form23_Load(object sender, EventArgs e)
        {
            log.openchild(new Form19(""), panel2);
            show(panelfood, panelaccount, panel6, bunifuButton4);

        }
        private void customize()
        {
            panelfood.Visible = false;
            panelaccount.Visible = false;
            panel6.Visible = false;

        }
        public void show(Panel Show,Panel Hide,Panel Hide1,BunifuButton button)
        {
            if(Show.Visible==false)
            { 
                Show.Visible = true;
                Hide.Visible = false;
                Hide1.Visible = false;
                
            }
            else if (Show.Visible == true)
            {
               if(Hide.Visible==false || Hide1.Visible==false)
                { 
                    Show.Visible = false;
                    
                }
            }

        }








        private void button1_Click(object sender, EventArgs e)
        {
            log.openchild(new Form19(""), panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.openchild(new myshop(label1.Text), panel2); 
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            show(panel6, panelaccount, panelfood, bunifuButton1);

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            if (panelfood.Visible == false && panelaccount.Visible == false && panel6.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
                panel6.Visible = false;
            }
            else
                 if (panelfood.Visible == true || panelaccount.Visible == true || panel6.Visible == true)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
                panel6.Visible = false;
            }
            log.openchild(new Form16(label1.Text), panel2);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (panelfood.Visible == false && panelaccount.Visible == false && panel6.Visible == false)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
                panel6.Visible = false;
            }
            else
                 if (panelfood.Visible == true || panelaccount.Visible == true || panel6.Visible == true)
            {
                panelfood.Visible = false;
                panelaccount.Visible = false;
                panel6.Visible = false;
            }
            log.openchild(new Form24(label1.Text), panel2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            log.openchild(new Form22(label1.Text), panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            log.openchild(new Form25(label1.Text), panel2);

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            

            show(panelfood, panelaccount, panel6, bunifuButton4);
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            show(panelaccount, panelfood, panel6, bunifuButton8);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.openchild(new Form14("SELECT foodno SI, foodname as Foodname FROM food where foodno between 1 and 10 order by foodno"), panel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log.openchild(new Form14("SELECT foodno SI, foodname as Foodname FROM food where foodno between 11 and 18 order by foodno"), panel2);

        }

        private void panelfood_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            log.openchild(new Form14("SELECT foodno SI, foodname as Foodname FROM food where foodno between 19 and 26 order by foodno"), panel2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
