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
    public partial class Form19 : Form
    {
        public Form19(string user)
        {
            InitializeComponent();

            label1.Text = user;

        }

        MySqlConnection con = new MySqlConnection(Cryptography.con());
        private void Form19_Load(object sender, EventArgs e)
        {
           








            string queryb = "SELECT * from shop";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            t1.Text = zz.Rows[0][1].ToString();
            t2.Text = zz.Rows[0][4].ToString();
            t3.Text = zz.Rows[0][3].ToString();
            t4.Text = zz.Rows[0][2].ToString();
            t5.Text = zz.Rows[0][5].ToString();

            if (label1.Text=="manager")
            {
                bunifuButton1.Visible = true;
                t1.Enabled = true;
                t1.ReadOnly = false;


                t2.Enabled = true;
                t2.ReadOnly = false;

                t3.Enabled = true;
                t3.ReadOnly = false;

                t4.Enabled = true;
                t4.ReadOnly = false;

                t5.Enabled = true;
                t5.ReadOnly = false;



            }
            else
            {

            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string queryb = "SELECT mid from manager";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            string user = zz.Rows[0][0].ToString();




            if (t1.Text == "")
            {
                MessageBox.Show("Shopname is Required ", "Save", MessageBoxButtons.OK);



            }
            else if (t2.Text == "")
            {
                MessageBox.Show("Email is Required ", "Save", MessageBoxButtons.OK);



            }
            else if(Cryptography.vmail(t2.Text)==false)

            {


                MessageBox.Show("Email is not valid ", "Save", MessageBoxButtons.OK);




            }


            else   if (t3.Text == "")
            {
                MessageBox.Show("Phone number is Required ", "Save", MessageBoxButtons.OK);



            }

            else if (Cryptography.vphone(t3.Text) == false)

            {


                MessageBox.Show("Phone is not valid ", "Save", MessageBoxButtons.OK);




            }


            else  if (t4.Text == "")
            {
                MessageBox.Show("Address is Required ", "Save", MessageBoxButtons.OK);



            }


            else if (t5.Text == "")



            {
                MessageBox.Show("About is Required ", "Save", MessageBoxButtons.OK);



            }



            else
            {
               



                string message = "Do you want to Update Your Data?";
                string title = "Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                     cm.CommandText = "update shop set  s_name='"+t1.Text+ "',  s_address='" + this.t4.Text + "',  s_phn='" + this.t3.Text + "',  s_email='" + this.t2.Text + "', s_details='" + this.t5.Text + "' where mid='" + user + "'";
                  
                   



                    con.Open();
                    cm.ExecuteNonQuery();

                    con.Close();



                    MessageBox.Show("Youe changes has Been saved ", "Save", MessageBoxButtons.OK);
                }
                else
                {

                }
            }

        }



    }
}
