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
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "Pending";
            string user = Cryptography.Encrypt(label1.Text);
            timer2.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();

            string queryb = "SELECT orders.ord_no as SI, customer.address as Address, food.foodname as food, orders.amount as Quantity, orders.tk as Tk, orders.status as Status, orders.Date as Date, orders.Time as Time,orders.message from customer,orders,food Where orders.foodno=food.foodno and customer.username='" + user + "' and orders.username='" + user + "' order by ord_no desc";

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
            Form12 nn = new Form12();
            nn.Show();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Exit?";
            string title = "Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                Form2 gg = new Form2();
                gg.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
           
            if (DataGridView1.Rows.Count != 0)
            {

                si.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                Foodname.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                quantity.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                Address.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                time.Text = DataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                date.Text = DataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                textBox1.Text = DataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                textBox2.Text = DataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string user = Cryptography.Encrypt(label1.Text);
 
            string queryb = "SELECT orders.ord_no as SI, customer.address as Address, food.foodname as food, orders.amount as Quantity, orders.tk as Tk, orders.status as Status, orders.Date as Date, orders.Time as Time,orders.message from customer,orders,food Where orders.foodno=food.foodno and customer.username='" + user + "' and orders.username='" + user + "' and status='" + this.comboBox2.Text + "' order by ord_no desc";

            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();

            dataa.Fill(zz);
            DataGridView1.DataSource = zz;
            if (DataGridView1.Rows.Count != 0)
            {

                si.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                Foodname.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                quantity.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                Address.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                time.Text = DataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                date.Text = DataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                textBox1.Text = DataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                textBox2.Text = DataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string user = Cryptography.Encrypt(label1.Text);

                string queryb = "SELECT orders.ord_no as SI, customer.address as Address, food.foodname as food, orders.amount as Quantity, orders.tk as Tk, orders.status as Status, orders.Date as Date, orders.Time as Time,orders.message from customer,orders,food Where orders.foodno=food.foodno and customer.username='" + user + "' and orders.username='" + user + "' and status='" + this.comboBox2.Text + "' order by ord_no desc";

                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();

                dataa.Fill(zz);
                DataGridView1.DataSource = zz;
                if (DataGridView1.Rows.Count != 0)
                {
                panel1.Visible = false;
                    si.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                    Foodname.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                    quantity.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                    Address.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                    time.Text = DataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                    date.Text = DataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                    textBox1.Text = DataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                    textBox2.Text = DataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                }
            else
            {
                panel1.Visible = true;

            }
        }
    }
}
