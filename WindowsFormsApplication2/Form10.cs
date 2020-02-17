using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form10 : Form
    {

       
        public Form10()
        {
            
            InitializeComponent();
            
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());

        private void Form10_Load(object sender, EventArgs e)
        {
            



            string queryb = "SELECT manager.name as 'Manager Name',shop.s_name as 'Shop name',maddress as Address,memail as Email,mphone as phone,mpic from manager,shop where manager.mid=shop.mid";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
           

            mname.Text = zz.Rows[0][0].ToString();
            sname.Text = zz.Rows[0][1].ToString();
            maddress.Text = zz.Rows[0][2].ToString();
            mmail.Text = zz.Rows[0][3].ToString();
            mphone.Text = zz.Rows[0][4].ToString();


            try {
                byte[] img = (byte[])zz.Rows[0][5];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox1.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {


                bunifuPictureBox1.Image =Properties.Resources.user;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
