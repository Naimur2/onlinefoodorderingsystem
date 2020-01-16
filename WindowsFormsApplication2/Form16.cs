using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");

        private void Form16_Load(object sender, EventArgs e)
        {
            string queryb = "SELECT orders.ord_no as SI,orders.username,customer.address,Food.foodname as Food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='pending' order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource = zz;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0) 
            {
               username.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                Foodname.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
               quantity.Text = DataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                Address.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                time.Text = DataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                date.Text = DataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
            }
        }
    }
}
