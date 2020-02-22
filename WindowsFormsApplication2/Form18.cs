using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.IO;
using Bunifu.UI.WinForms.BunifuButton;

namespace WindowsFormsApplication2
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
          
        }
        public void cc()
        {


            string queryb = "SELECT mid,name,mphone,maddress,mpic from manager";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);


            DataTable cc = new DataTable();

            int i = zz.Rows.Count;

            cc.Columns.Add("Username", typeof(string));
            cc.Columns.Add("Name", typeof(string));

            cc.Columns.Add("Phone", typeof(string));

            cc.Columns.Add("Address", typeof(string));

            cc.Columns.Add("Pic", typeof(Image));







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



            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void admin_Load(object sender, EventArgs e)
        {


            cc();

        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
        
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            log.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            log.logout(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
           
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void enable(BunifuButton a, BunifuButton b)
        {
            
            a.Enabled = false;
           b.Enabled = true;
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void b3_Click(object sender, EventArgs e)
        {
           
        }

        private void b4_Click(object sender, EventArgs e)
        {
           
        }

        private void b5_Click(object sender, EventArgs e)
        {
           

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b3_Click_1(object sender, EventArgs e)
        {
            


        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

            string usernam = Cryptography.Encrypt(textBox2.Text);
            string mail = Cryptography.Encrypt(textBox1.Text);

           
            if (Class1.checkusername(usernam)==false)
            {
                MessageBox.Show("Username Not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
          else if(textBox2.Text.Length<4 || textBox2.Text.Length > 12)
            {
                MessageBox.Show("Username should be 4 to 12 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }


            else if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Please add InFormation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (textBox1.Text.Length < 6 || textBox1.Text.Length > 12)
            {

                MessageBox.Show("Password should be 6 to 12 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                string message = "Do you want to Update Your Data?";
                string title = "Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    Image profile = bunifuPictureBox2.Image;
                    profile.Save(ms, profile.RawFormat);
                    byte[] img = ms.ToArray();
                    string user = Cryptography.Encrypt(textBox2.Text);
                    string pass = Cryptography.Encrypt(textBox1.Text + "@shop.as");

                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "insert into manager(mid,name,keycode,maddress,memail,mphone,mpic) values (@mid,@name,@keycode,@maddress,@memail,@mphone,@mpic)";
                    cm.Parameters.AddWithValue("@mid", user);
                    cm.Parameters.AddWithValue("@keycode", pass);
                    cm.Parameters.AddWithValue("@name", "Not updated");
                    cm.Parameters.AddWithValue("@maddress", "Not updated");
                    cm.Parameters.AddWithValue("@memail", textBox3.Text);
                    cm.Parameters.AddWithValue("@mphone", "Not updated");
                    cm.Parameters.AddWithValue("@mpic", img);
                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Data updsted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cc();
                }
                else
                {

                }
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string message = "Do you want to clear  Data?";
            string title = "Update";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "Truncate Table manager";

                con.Open();
                cm.ExecuteNonQuery();

                con.Close();
            }
            else
            {

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox2.Image = Image.FromFile(opf.FileName);
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
