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
            bunifuButton3_Click((object) sender, (EventArgs) e);
            



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
            t1.Enabled = false;
            t1.ReadOnly = true;
            label2.Visible = false;
            textBox1.Visible = false;

            DataGridView1.Enabled = true;
            int i = DataGridView1.Rows.Count;
            if (i != 0)
            {
                DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(0, 0));
            }

            t7.Visible = false;
            label9.Visible = false;
            radButton3.Visible = false;
            radButton4.Visible = false;
            radButton1.Visible = true;
            radButton2.Visible = true;
            bunifuButton1.Enabled = true;
            bunifuButton3.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        { t1.Focus();
            t7.Clear();
            textBox1.Clear();

            bunifuPictureBox1.Image = Properties.Resources.user;
            t1.Enabled = true;
            t1.ReadOnly = false;
            label2.Visible = true;
            textBox1.Visible = true;
            DataGridView1.Enabled = false;

            t7.Visible = true;
            label9.Visible = true;
            radButton3.Visible = true;
            radButton4.Visible = true;
            radButton1.Visible = false;
            radButton2.Visible = false;
            bunifuButton1.Enabled = false;
            bunifuButton3.Enabled = true;
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
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

        private void radButton3_Click(object sender, EventArgs e)
        {
            String usernam = Cryptography.Encrypt(t1.Text);
            string queryb = "select* FROM manager,customer,admin,deliveryboy where customer.username = '" + usernam + "' and manager.mid = '" + usernam + "' and admin.masterid = '" + usernam + "' and deliveryboy.user = '" + usernam + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            string query2 = "SELECT phone from deliveryboy where phone='" + t4.Text + "'";
            MySqlDataAdapter data2 = new MySqlDataAdapter(query2, con);
            DataTable z1 = new DataTable();
            data2.Fill(z1);


            string mail = Cryptography.Encrypt(t3.Text);
            string query1 = "SELECT customer.email,deliveryboy.demail,admin.mastermail from customer,deliveryboy,admin where email='" + mail + "' and demail='" + this.t3.Text + "' and mastermail='" + mail + "'";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable z = new DataTable();
            data1.Fill(z);

            if (zz.Rows.Count == 1)
            {
                MessageBox.Show("Username is not available","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                t1.Focus();
            }
            else if (z.Rows.Count == 1)
            {
                MessageBox.Show("Email is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t3.Focus();
            }
            else if (z1.Rows.Count == 1)
            {
                MessageBox.Show("Phone is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t4.Focus();
            }



            else if (t1.Text== "")
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t1.Focus();
            }
            else if (t1.Text.Length <4 || t1.Text.Length > 12)
            {
                MessageBox.Show("Username Should be 4  to twelve charcter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t1.Focus();
            }
            else if (t2.Text.Length < 4 )
            {
                MessageBox.Show("Name Should have 4 chrctre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t2.Focus();
            }
            else if (t2.Text=="")
            {
                MessageBox.Show("Name is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t2.Focus();
            }
            else if (t3.Text == "")
            {
                MessageBox.Show("Email is reuired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t3.Focus();
            }
            else if (Cryptography.vmail(t3.Text)==false)
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
            else if (t7.Text == "")
            {
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t7.Focus();
            }
            else if (t7.Text.Length<6 || t7.Text.Length > 12)
            {
                MessageBox.Show("Password should be 6 to 12 charcter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t7.Focus();
            }
            else
            {
                string user = Cryptography.Encrypt(label1.Text);
                string message = "Do you want to order this food?";
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
                    cm.CommandText = "insert into deliveryboy(user,password,name,demail,phone,area ,address,D_pic) values (@username,@password,@name,@email,@phone,@area,@address,@image)";

                    cm.Parameters.AddWithValue("@username", Cryptography.Encrypt(t1.Text));
                    cm.Parameters.AddWithValue("@name", t2.Text);
                    cm.Parameters.AddWithValue("@password", Cryptography.Encrypt(textBox1.Text));
                    cm.Parameters.AddWithValue("@email", t3.Text);
                    cm.Parameters.AddWithValue("@phone", t4.Text);
                    cm.Parameters.AddWithValue("@address", t6.Text);
                    cm.Parameters.AddWithValue("@area", t5.Text);
                    cm.Parameters.AddWithValue("@image", img);
                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();
                   
                    MessageBox.Show("User is Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    data();
                }
                else
                {

                }
            }
        }

        private void t7_TextChanged(object sender, EventArgs e)
        {
           textBox1.Text = t7.Text + "@delivery.as";
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
                cm.CommandText =" DELETE FROM `deliveryboy` WHERE user = '"+user+ "' ";
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

        private void radButton4_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            textBox1.Clear();
        }
    }
}
