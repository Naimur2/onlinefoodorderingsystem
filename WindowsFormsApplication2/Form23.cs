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


        }
        private void customize()
        {
            panelfood.Visible = false;
            panelaccount.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            log.openchild(new Form19("manager"), panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.openchild(new myshop(label1.Text), panel2); 
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
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
            log.openchild(new Form14(label1.Text), panel2);
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
            log.openchild(new Form16(label1.Text), panel2);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
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

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            if (panelaccount.Visible == false && panelfood.Visible == false)
            {

                panelaccount.Visible = true;
                panelfood.Visible = false;

            }
            else if (panelaccount.Visible == false && panelfood.Visible == true)
            {

                panelaccount.Visible = true;
                panelfood.Visible = false;

            }
            else if (panelaccount.Visible == true && panelfood.Visible == false)
            {

                panelaccount.Visible = false;
                panelfood.Visible = false;

            }
        }
        }
}
