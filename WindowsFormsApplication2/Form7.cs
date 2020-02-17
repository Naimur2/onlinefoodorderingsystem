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
    public partial class Form7 : Form
    {
        public Form7(String ms)
        {
            InitializeComponent();
            label1.Text = ms;

        }
        MySqlConnection con = new MySqlConnection(Cryptography.con());


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }
        Regex mg;
        private void Form7_Load(object sender, EventArgs e)
        {
            timer2.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();


            bunifuLabel1.Text=label1.Text;

            string user = Cryptography.Encrypt(label1.Text);
            string queryb = "SELECT name,phone,address,pic,email from customer Where username='" + user+ "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            bunifuMaterialTextbox1.Text = zz.Rows[0][0].ToString();
            bunifuMaterialTextbox2.Text = zz.Rows[0][1].ToString();
            bunifuLabel2.Text = Cryptography.Decrypt(zz.Rows[0][4].ToString());
            bunifuMaterialTextbox4.Text = zz.Rows[0][2].ToString();
            
            byte[] img = (byte[])zz.Rows[0][3];
            MemoryStream ms = new MemoryStream(img);
            bunifuPictureBox2.Image = Image.FromStream(ms);


            bunifuMaterialTextbox1.LineFocusedColor = Color.FromArgb(21, 66, 139);
            bunifuMaterialTextbox1.LineMouseHoverColor= Color.FromArgb(21, 66, 139);

            bunifuMaterialTextbox2.LineFocusedColor = Color.FromArgb(21, 66, 139);
            bunifuMaterialTextbox2.LineMouseHoverColor = Color.FromArgb(21, 66, 139);

            

            bunifuMaterialTextbox4.LineFocusedColor = Color.FromArgb(21, 66, 139);
            bunifuMaterialTextbox4.LineMouseHoverColor = Color.FromArgb(21, 66, 139);

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form4 cc = new Form4(label1.Text);
            cc.Show();
            timer1.Start();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton1_Click(object sender, EventArgs e)
        {

        }

        


        public void save()
        {

            string user = Cryptography.Encrypt(label1.Text);



            string message = "Do you want to Update Your Data?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                Regex mg = new Regex("^01+[0-9]{1}[0-9]{8}");
                if (bunifuMaterialTextbox1.Text == "")
                {

                    bunifuLabel4.Visible = true;

                }
                else if (bunifuMaterialTextbox2.Text == "")
                {

                    bunifuLabel5.Visible = true;

                }
               
                else if (bunifuMaterialTextbox4.Text == "")
                {

                    bunifuLabel7.Visible = true;

                }
                else if (!mg.IsMatch(bunifuMaterialTextbox2.Text))
                {

                    bunifuLabel5.Visible = true;

                }

                else
                {

                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "update customer set name=@name,phone=@phone,address=@address where username=@username";

                    cm.Parameters.AddWithValue("@username", user);
                    cm.Parameters.AddWithValue("@name", bunifuMaterialTextbox1.Text);
                   

                    cm.Parameters.AddWithValue("@phone", bunifuMaterialTextbox2.Text);
                    cm.Parameters.AddWithValue("@address", bunifuMaterialTextbox4.Text);

                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();


                  
                    MessageBox.Show("Youe changes has Been saved ");


                }
            }
            else
            {

            }


        }


        public void cancel()
        {
            string user = Cryptography.Encrypt(label1.Text);
            string queryb = "SELECT name,phone,password,address,pic,email from customer Where username='" + user + "'";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            bunifuMaterialTextbox1.Text = zz.Rows[0][0].ToString();
            bunifuMaterialTextbox2.Text = zz.Rows[0][1].ToString();
          
            bunifuMaterialTextbox4.Text = zz.Rows[0][3].ToString();
            bunifuLabel2.Text = zz.Rows[0][5].ToString();
            byte[] img = (byte[])zz.Rows[0][4];
            MemoryStream ms = new MemoryStream(img);
            bunifuPictureBox2.Image = Image.FromStream(ms);


    



        }






        private void bunifuButton5_Click(object sender, EventArgs e)
        {
           try
            {
                save();


            }
                 catch(Exception)
            {

                MessageBox.Show("Error", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              


           

        }

        

       
        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "")
            {

                bunifuLabel4.Visible = false;

            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text != "")
            {

                bunifuLabel5.Visible = false;

            }

        }

       

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text != "")
            {

                bunifuLabel7.Visible = false;

            }
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bunifuMaterialTextbox2.Focus();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.LostFocus += new EventHandler(vv_LostFocus);
            vv.Show();

        }
        void vv_LostFocus(object sender, EventArgs e)
        {
            Form8 vv = sender as Form8;
           vv.Close();
            vv.Dispose();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            label73.Text = DateTime.Now.ToShortTimeString();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            
            Form4 nn = new Form4(label1.Text);
            nn.Show();
            timer1.Start();
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bunifuButton5_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            bunifuButton5.Visible = true;
           
            bunifuMaterialTextbox1.Enabled = true;
            bunifuMaterialTextbox2.Enabled = true;
          
            bunifuMaterialTextbox4.Enabled = true;
            bunifuMaterialTextbox1.LineFocusedColor = Color.Blue;
            bunifuMaterialTextbox1.LineMouseHoverColor = Color.Blue;

            bunifuMaterialTextbox2.LineFocusedColor = Color.Blue;
            bunifuMaterialTextbox2.LineMouseHoverColor = Color.Blue;

        
            bunifuMaterialTextbox4.LineFocusedColor = Color.Blue;
            bunifuMaterialTextbox4.LineMouseHoverColor = Color.Blue;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
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

        private void Form7_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    bunifuPictureBox2.Image = Image.FromFile(opf.FileName);


                    MemoryStream ms = new MemoryStream();
                    bunifuPictureBox2.Image.Save(ms, bunifuPictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "update customer set pic=@image where username=@username";

                    cm.Parameters.AddWithValue("@username",Cryptography.Encrypt( label1.Text));

                    cm.Parameters.AddWithValue("@image", img);
                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please select image under 40 Mib");

            }
        }
    }
}
