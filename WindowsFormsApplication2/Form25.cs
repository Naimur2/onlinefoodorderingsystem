using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form25 : Form
    {
        public Form25(string mm)
        {
            InitializeComponent();
            label1.Text = mm;
        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void Form25_Load(object sender, EventArgs e)
        {
          
            



            string queryb = "SELECT user,name,demail,phone,area,address,D_pic from deliveryboy";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();

            dataa.Fill(zz);

            DataTable cc = new DataTable();

            int i = zz.Rows.Count;
            
            cc.Columns.Add("Username", typeof(string));
            cc.Columns.Add("Name", typeof(string));
            cc.Columns.Add("Email", typeof(string));
            cc.Columns.Add("Phone", typeof(string));
            cc.Columns.Add("Area", typeof(string));
            cc.Columns.Add("Address", typeof(string));
            cc.Columns.Add("Pic", typeof(Image));
            
            


            for (int j=0;j<i;j++)
            {
                byte[] img1 = (byte[])zz.Rows[j][6];
                MemoryStream ms1 = new MemoryStream(img1);
                cc.Rows.Add(Cryptography.Decrypt( zz.Rows[j][0].ToString()), zz.Rows[j][1].ToString(), zz.Rows[j][2].ToString(), zz.Rows[j][3].ToString(), zz.Rows[j][4].ToString(), zz.Rows[j][5].ToString(), Image.FromStream(ms1));
                
            }
            DataGridView1.RowTemplate.Height = 70;
            DataGridView1.DataSource = cc;

           

            DataGridView1.DataSource = cc;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            int k = DataGridView1.Rows.Count;
            if (k != 0)
            {
                DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(0, 0));
            }



        }
        public void data()
        {


            string queryb = "SELECT user,name,demail,phone,area,address,D_pic from deliveryboy";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();

            dataa.Fill(zz);

            DataTable cc = new DataTable();

            int i = zz.Rows.Count;

            cc.Columns.Add("Username", typeof(string));
            cc.Columns.Add("Name", typeof(string));
            cc.Columns.Add("Email", typeof(string));
            cc.Columns.Add("Phone", typeof(string));
            cc.Columns.Add("Area", typeof(string));
            cc.Columns.Add("Address", typeof(string));
            cc.Columns.Add("Pic", typeof(Image));




            for (int j = 0; j < i; j++)
            {
                byte[] img1 = (byte[])zz.Rows[j][6];
                MemoryStream ms1 = new MemoryStream(img1);
                cc.Rows.Add(Cryptography.Decrypt(zz.Rows[j][0].ToString()), zz.Rows[j][1].ToString(), zz.Rows[j][2].ToString(), zz.Rows[j][3].ToString(), zz.Rows[j][4].ToString(), zz.Rows[j][5].ToString(), Image.FromStream(ms1));

            }
            DataGridView1.RowTemplate.Height = 70;
            DataGridView1.DataSource = cc;



            DataGridView1.DataSource = cc;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
           
          
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        { 
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                t1.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                t2.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                t3.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                t4.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                t5.Text = DataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                t6.Text = DataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                bunifuPictureBox1.Image= DataGridView1.SelectedRows[0].Cells[6].Value as Image;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            



        }

        private void radButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void t7_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox1.Image = Image.FromFile(opf.FileName);
                con.Close();
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

            string mail = Cryptography.Encrypt(t3.Text);
            string query1 = "SELECT customer.email,deliveryboy.demail,admin.mastermail from customer,deliveryboy,admin where email='" + mail + "' and demail='" + this.t3.Text + "' and mastermail='" + mail + "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable z = new DataTable();
            data1.Fill(z);



            if (t2.Text.Length < 4)
            {
                MessageBox.Show("Name Should have 4 chrctre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t2.Focus();
            }
            else if (t2.Text == "")
            {
                MessageBox.Show("Name is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t2.Focus();
            }
            else if (t3.Text == "")
            {
                MessageBox.Show("Email is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t3.Focus();
            }
            else if (Cryptography.vmail(t3.Text) == false)
            {
                MessageBox.Show("Emil address is is not vlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t3.Focus();
            }
            else if (t4.Text == "")
            {
                MessageBox.Show("Email is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t4.Focus();
            }
            else if (Cryptography.vphone(t4.Text) == false)
            {
                MessageBox.Show("Email address is is not vlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t4.Focus();
            }
            else if (t5.Text == "")
            {
                MessageBox.Show("Area is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t5.Focus();
            }
            else if (t6.Text == "")
            {
                MessageBox.Show("Address is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t6.Focus();
            }
            else if (z.Rows.Count == 1)
            {
                MessageBox.Show("Email is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t3.Focus();
            }

            else
            {

                string user = Cryptography.Encrypt(label1.Text);
                string message = "Do you want to update data?";
                string title = "Order";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    MemoryStream ms = new MemoryStream();
                    bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "update deliveryboy set name=@name,demail=@email,phone=@phone,address=@address,area=@area,D_pic=@image";


                    cm.Parameters.AddWithValue("@name", t2.Text);

                    cm.Parameters.AddWithValue("@email", t3.Text);
                    cm.Parameters.AddWithValue("@phone", t4.Text);
                    cm.Parameters.AddWithValue("@address", t6.Text);
                    cm.Parameters.AddWithValue("@area", t5.Text);
                    cm.Parameters.AddWithValue("@image", img);
                    con.Open();
                    cm.ExecuteNonQuery();



                    data();
                }
                else
                {


                }


            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string user = Cryptography.Encrypt(t1.Text);
            string message = "Do you want to remove this deliveryboy?";
            string title = "Order";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                MemoryStream ms = new MemoryStream();
                bunifuPictureBox1.Image.Save(ms, bunifuPictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = " DELETE FROM `deliveryboy` WHERE user = '" + user + "' ";
                con.Open();
                cm.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("User is deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data();
            }
            else
            {

            }
        }
    }
}
