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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=foodbank;username=root;password=;");

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            button1_Click((object)sender, (EventArgs)e);

        



        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            label5.Text = "2";
            String query = "SELECT * FROM food where foodno=2";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like2),sum(unlike2) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            label5.Text = "1";
            String query = "SELECT * FROM food where foodno=1";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text= dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);

            String query1 = "SELECT sum(like1),sum(unlike1) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "3";
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            
            String query = "SELECT * FROM food where foodno=3";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString(); label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like3),sum(unlike3) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "4";
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            
            String query = "SELECT * FROM food where foodno=4";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString(); label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like4),sum(unlike4) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            label5.Text = "5";
            String query = "SELECT * FROM food where foodno=5";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString(); label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like5),sum(unlike5) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            label5.Text = "6";
            String query = "SELECT * FROM food where foodno=6";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString(); label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);

            String query1 = "SELECT sum(like6),sum(unlike6) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;
            label5.Text = "7";
            String query = "SELECT * FROM food where foodno=7";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString(); label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like7),sum(unlike7) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
            label5.Text = "8";
            String query = "SELECT * FROM food where foodno=8";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);

            String query1 = "SELECT sum(like8),sum(unlike8) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
            label5.Text = "9";
            String query = "SELECT * FROM food where foodno=9";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);
            String query1 = "SELECT sum(like9),sum(unlike9) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
            label5.Text = "10";
            String query = "SELECT * FROM food where foodno=10";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            label22.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            label2.Text = dt.Rows[0][1].ToString();
            label62.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            label32.Text = dt.Rows[0][3].ToString();
            byte[] img1 = (byte[])dt.Rows[0][4];
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBox23.Image = Image.FromStream(ms1);
            pictureBox6.Image = Image.FromStream(ms1);

            String query1 = "SELECT sum(like10),sum(unlike10) FROM ratings";
            MySqlDataAdapter data1 = new MySqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            label4.Text = dt1.Rows[0][0].ToString();
            label3.Text = dt1.Rows[0][1].ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 vv = new Form8();
            vv.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            panel3.Height = button1.Height;
            panel3.Top = button1.Top; ;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top; ;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top; ;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top; ;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top; ;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top; ;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top; ;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top; ;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top; ;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top; ;
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(opf.FileName);
                con.Close();
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            label22.Text = textBox1.Text;
            label62.Text = textBox2.Text;
            label32.Text = textBox3.Text + "\r\n" + textBox4.Text;
            pictureBox23.Image = pictureBox6.Image;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form16 oo = new Form16();
            oo.Show();
            this.Hide();
        }
    }
}
