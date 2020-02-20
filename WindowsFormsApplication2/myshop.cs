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

namespace WindowsFormsApplication2
{
    public partial class myshop : Form
    {
        public myshop(string ms)
        {
            InitializeComponent();
           
        }


        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void myshop_Load(object sender, EventArgs e)
        {
           

            
            string queryb = "SELECT username,name,phone,address,pic from customer";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
          

            DataTable cc = new DataTable();

            int i = zz.Rows.Count;
            
            cc.Columns.Add("Username", typeof(string));
            cc.Columns.Add("Name", typeof(string));
          
            cc.Columns.Add("Phone", typeof(string));
           
            cc.Columns.Add("Address", typeof(string));

            cc.Columns.Add("Pic",typeof( Image));
            






            for (int j = 0; j < i; j++)
            {
                
                byte[] img1 = (byte[])zz.Rows[j][4];
                MemoryStream ms1 = new MemoryStream(img1);
                Image image = Image.FromStream(ms1);


              cc.Rows.Add(Cryptography.Decrypt(zz.Rows[j][0].ToString()), zz.Rows[j][1].ToString(), zz.Rows[j][2].ToString(), zz.Rows[j][3].ToString(), Image.FromStream(ms1));
              

            }



            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridView1.RowTemplate.Height = 70;
            
            DataGridView1.DataSource = cc;
            int k = DataGridView1.Rows.Count;
            if (k != 0)
            {
                DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(0, 0));
            }


            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

          
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        { 
            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = false;

            if (DataGridView1.SelectedRows.Count > 0)
            {
                string user=Cryptography.Encrypt( DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty);
                username.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                textBox1.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                textBox2.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
               
                string queryb = "SELECT pic from customer where username='"+user+"'";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zk = new DataTable();
                dataa.Fill(zk);
                


                byte[] img = (byte[])zk.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                bunifuPictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
