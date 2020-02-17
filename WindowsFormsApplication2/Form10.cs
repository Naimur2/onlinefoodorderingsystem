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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            string usernam = Cryptography.Encrypt(textBox2.Text);
            string mail = Cryptography.Encrypt(textBox2.Text);

            string query = " select* FROM manager,customer,admin,deliveryboy where customer.username = '" + usernam + "' and manager.mid = '" + usernam + "' and admin.masterid = '" + usernam + "' and deliveryboy.user = '" + usernam + "'";

            string query2 = "select * from customer,manager,admin,deliveryboy where  customer.email='" + mail + "' and manager.memail='" +textBox3.Text + "' and deliveryboy.demail ='" + textBox3.Text + "' and admin.mastermail='" + mail + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(query2, con);

            DataTable dt = new DataTable();
            DataTable it = new DataTable();

            data.Fill(dt);
            dat.Fill(it);
            if (dt.Rows.Count==1)
            {
                MessageBox.Show("Username Not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
          else  if (it.Rows.Count == 1)
            {
                MessageBox.Show("Username Not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



          else  if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Please add InFormation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (textBox1.Text.Length < 6)
            {

                MessageBox.Show("Password should be 6character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Image profile = Properties.Resources.user;
                profile.Save(ms, profile.RawFormat);
                byte[] img = ms.ToArray();
                string user = Cryptography.Encrypt(textBox2.Text);
                string pass = Cryptography.Encrypt(textBox1.Text);
              
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "insert into manager(mid,name,keycode,maddress,memail,mphone,mpic) values (@mid,@name,@keycode,@maddress,@memail,@mphone,@mpic)";
                cm.Parameters.AddWithValue("@mid", user);
                cm.Parameters.AddWithValue("@keycode", pass);
                cm.Parameters.AddWithValue("@name", "Not updated");
                cm.Parameters.AddWithValue("maddress", "Not updated");
                cm.Parameters.AddWithValue("@memail", textBox3.Text);
                cm.Parameters.AddWithValue("@mphone", "Not updated");
                cm.Parameters.AddWithValue("@image", img);
                con.Open();
                cm.ExecuteNonQuery();

                con.Close();
            }
         
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = con;
            cm.CommandText = "Truncate Table manager)";
           
            con.Open();
            cm.ExecuteNonQuery();

            con.Close();
        }
    }
}
