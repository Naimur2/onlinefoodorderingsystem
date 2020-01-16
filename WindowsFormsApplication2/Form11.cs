using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form11 : Form
    {
        public Form11(string ms)
        {
            InitializeComponent();
            label1.Text = ms;
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");
        private void Form11_Load(object sender, EventArgs e)
        {
            timer2.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();

            string queryb = "SELECT Food.foodname as Food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from orders,food Where username='" + this.label1.Text + "' and orders.foodno=food.foodno order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource=zz;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            label73.Text = DateTime.Now.ToShortTimeString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form9 cc = new Form9(label1.Text);
            cc.Show();
            timer1.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            Form4 nn = new Form4(label1.Text);
            nn.Show();
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Form12 nn = new Form12(label1.Text);
            nn.Show();
            timer1.Start();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
