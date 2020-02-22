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



            string queryb = "SELECT mpic,manager.mid,manager.name,mphone,maddress,memail,s_name from manager,shop";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);


            DataTable cc = new DataTable();

            int i = zz.Rows.Count;
            cc.Columns.Add("Pic", typeof(Image));
            cc.Columns.Add("Username", typeof(string));
            cc.Columns.Add("Name", typeof(string));
            
            cc.Columns.Add("Phone", typeof(string));
            cc.Columns.Add("Address", typeof(string));
            
            cc.Columns.Add("Email", typeof(string));
            cc.Columns.Add("Shop name", typeof(string));
         








            for (int j = 0; j < i; j++)
            {

                byte[] img1 = (byte[])zz.Rows[j][0];
                MemoryStream ms1 = new MemoryStream(img1);
                Image image = Image.FromStream(ms1);


                cc.Rows.Add(Image.FromStream(ms1),Cryptography.Decrypt(zz.Rows[j][1].ToString()), zz.Rows[j][2].ToString(), zz.Rows[j][3].ToString(), zz.Rows[j][4].ToString(), zz.Rows[j][5].ToString(), zz.Rows[j][6].ToString());


            }



            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridView1.RowTemplate.Height = 58;
            
            DataGridView1.DataSource = cc;



            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
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

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows.Count != 0)
            {
               
                textBox2.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
            }

            }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {

                MessageBox.Show("Please Select an user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                try
                {
                    string message = "Do you want to Update Your Data?";
                    string title = "Update";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string user = Cryptography.Encrypt(textBox2.Text);
                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = "DELETE FROM `manager` WHERE mid='"+user+"'";
                       
                        con.Open();
                        cm.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Data updsted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




                        string queryb = "SELECT mpic,manager.mid,manager.name,mphone,maddress,memail,s_name from manager,shop";
                        MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                        DataTable zz = new DataTable();
                        dataa.Fill(zz);


                        DataTable cc = new DataTable();

                        int i = zz.Rows.Count;
                        cc.Columns.Add("Pic", typeof(Image));
                        cc.Columns.Add("Username", typeof(string));
                        cc.Columns.Add("Name", typeof(string));

                        cc.Columns.Add("Phone", typeof(string));
                        cc.Columns.Add("Address", typeof(string));

                        cc.Columns.Add("Email", typeof(string));
                        cc.Columns.Add("Shop name", typeof(string));









                        for (int j = 0; j < i; j++)
                        {

                            byte[] img1 = (byte[])zz.Rows[j][0];
                            MemoryStream ms1 = new MemoryStream(img1);
                            Image image = Image.FromStream(ms1);


                            cc.Rows.Add(Image.FromStream(ms1), Cryptography.Decrypt(zz.Rows[j][1].ToString()), zz.Rows[j][2].ToString(), zz.Rows[j][3].ToString(), zz.Rows[j][4].ToString(), zz.Rows[j][5].ToString(), zz.Rows[j][6].ToString());


                        }



                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        DataGridView1.RowTemplate.Height = 50;

                        DataGridView1.DataSource = cc;



                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn = (DataGridViewImageColumn)DataGridView1.Columns[0];
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }
                    else
                    {

                    }
                    }
                catch(Exception ex)
                {
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }
    }
}
