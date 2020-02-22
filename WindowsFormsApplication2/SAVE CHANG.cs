using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication2
{
    public partial class SAVE : Form
    {
      
        public SAVE(string a)
        {
            InitializeComponent();
            label1.Text = a;
        }

        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void SAVE_Load(object sender, EventArgs e)
        {
            
           

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            log.openchild(new Form27(label1.Text), panel2);

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            log.openchild(new changepass(label1.Text,"deliveryboy"), panel2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }
    }
}
