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
    public partial class Form27 : Form
    {
        public Form27(string ll)
        {
            InitializeComponent();
            label1.Text = ll;
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());

        private void Form27_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "Pending";
            int k = DataGridView1.Rows.Count;
            if (k != 0)
            {
                DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(0, 0));
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {


                username.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                Address.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
            }
            }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Please select status", "Error", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "update delivery set status=@sta where ord_no=@ord";


                cm.Parameters.AddWithValue("@sta", comboBox1.Text);

                cm.Parameters.AddWithValue("@ord", username.Text);
             
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBox1.Text = comboBox1.Text;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryb = "SELECT Orders.ord_no,address,delivery.status from delivery,orders,customer where delivery.Ord_no=orders.Ord_no and orders.username=customer.username and delivery.status='"+comboBox2.Text+"' and user='" + Cryptography.Encrypt(label1.Text) + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();

            dataa.Fill(zz);

            DataTable cc = new DataTable();

            int i = zz.Rows.Count;

            cc.Columns.Add("Orderno", typeof(string));
            cc.Columns.Add("Address", typeof(string));
            cc.Columns.Add("Status", typeof(string));

            for (int j = 0; j < i; j++)
            {

                cc.Rows.Add(zz.Rows[j][0].ToString(), zz.Rows[j][1].ToString(), zz.Rows[j][1].ToString());

            }
            DataGridView1.DataSource = cc;
        }
    }
}
