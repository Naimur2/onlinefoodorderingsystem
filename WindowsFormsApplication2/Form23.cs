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
            label.Text = bb;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            log.openchild(new changepass(label.Text, "deliveryboy"), panel3);
            b1.Enabled = true;
            b2.Enabled = false;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            log.openchild(new Form27(label.Text), panel3);
            b1.Enabled = false;
            b2.Enabled = true;
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            b1_Click((object)sender, (EventArgs)e);
        }
    }
}
