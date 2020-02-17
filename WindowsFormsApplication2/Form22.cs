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
    public partial class Form22 : Form
    {
        public Form22(string ms)
        {
            InitializeComponent();
             label1.Text=ms;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form19("manager"));
            b1.Enabled = false;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void b3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new myshop(label1.Text));
            b1.Enabled = true;
            b2.Enabled = false;
            b3.Enabled = true;
            b4.Enabled = true;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
          b1_Click((object)sender, (EventArgs)e);
            
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            log.openchild(new Form26(), panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form24(label1.Text));
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = false;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form25(label1.Text));
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = false;
            b4.Enabled = true;
        }
    }
}
