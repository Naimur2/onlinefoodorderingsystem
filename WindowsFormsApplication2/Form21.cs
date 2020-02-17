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
    public partial class Form21 : Form
    {
        public Form21(string nn)
        {
            InitializeComponent();

            label1.Text = nn;
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            string queryb = "SELECT memail from mandger where mid='" + label1.Text + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            string mm = Cryptography.Decrypt(zz.Rows[0][0].ToString());
            openChildFormInPanel(new changepass(label1.Text,"customer"));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            b2.Enabled = true;
            b3.Enabled = true;
            openChildFormInPanel(new Form7(label1.Text));
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            b1_Click((object)sender, (EventArgs)e);
            
        }

        private void b3_Click(object sender, EventArgs e)
        {

            b2.Enabled = false;
            b1.Enabled = true;
            
            b3.Enabled = true;
            openChildFormInPanel(new changepass(label1.Text,"customer"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = false;

            log.openchild(new Form19(""), panel1);
        }
    }
}
