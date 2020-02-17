using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Net.Mail;
using System.Net;
namespace WindowsFormsApplication2
{
    public partial class Form16 : Form
    {
        public Form16(string ms)
        {
            InitializeComponent();
            label1.Text = ms;
        }



        MySqlConnection con = new MySqlConnection(Cryptography.con());

        private void Form16_Load(object sender, EventArgs e)
        {
        

            string query = "select area from deliveryboy group by area";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable bb = new DataTable();
            data.Fill(bb);
            int i = bb.Rows.Count;
            if (i >= 0)
            {
                for (int j = 0; j < i; j++)
                {
                    comboBox3.Items.Add(bb.Rows[j][0].ToString());

                }
            }
            comboBox2.Text = "Pending";



            timer1.Start();
            label72.Text = DateTime.Now.ToShortDateString();
            label73.Text = DateTime.Now.ToShortTimeString();


            string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as OrderStatus,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='pending' and order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource = zz;
            if(DataGridView1.Rows.Count==0)
            {

                panel1.Visible = true;

            }
            else
            {

                panel1.Visible = false;

            }

        }
        public void grid()
        {
            string queryb = "SELECT orders.ord_no as SI,orders.customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='"+comboBox1.Text+"' order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource = zz;
            if (zz.Rows.Count != 0)
            {
                textBox2.Text = zz.Rows[0][5].ToString();
                username.Text = zz.Rows[0][0].ToString();
                Foodname.Text = zz.Rows[0][2].ToString();
                quantity.Text = zz.Rows[0][3].ToString();
                Address.Text = zz.Rows[0][1].ToString();
                time.Text = zz.Rows[0][7].ToString();
                date.Text = zz.Rows[0][6].ToString();
              
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Delivered")
            {
                string Body = "Hi" + "Your order in asterisk food of " + quantity.Text + " " + "pice of" + Foodname.Text + " " + "is delivered in your address:" + Address.Text + "\r\n" + "Thank you, Team asterisk";
                textBox1.Text = Body;
            }
            else if (comboBox1.Text == "Invalid address")
            {
                string Body = "Hi" + "We could not deliver your food beasuse there is no valid address of you,please provide valid address and phone number " + "Thank you, Team asterisk";
                textBox1.Text = Body;
            }
            else {
                textBox1.Clear();
            }
            }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form17 oo = new Form17("a",label1.Text);
            oo.Show();
            timer2.Start();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form17 oo = new Form17("c",label1.Text);
            oo.Show();
            timer2.Start();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
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
            timer1.Start();
            
            label73.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            {
                MessageBox.Show("Please Select status","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
            else if(username.Text=="")
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (Foodname.Text == "")
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (quantity.Text == "")
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (Address.Text == "")
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (time.Text == "")
            {

                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("Please write some message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {


              

                try
                {


                    if (comboBox1.Text == "Delivered")
                    {
                        string Body = "Hi " + username.Text + " " + "Your order in asterisk food of " + quantity.Text + " " + "pice of" + Foodname.Text + " " + "is delivered in your address:" + Address.Text + "\r\n" + "Thank you, Team asterisk";
                        int i = Int32.Parse(label2.Text);
                        string aa = comboBox1.Text;

                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = " UPDATE `orders` SET `status` = '" + this.comboBox1.Text + "', `Message` = '"+textBox1.Text+"' WHERE `orders`.`ord_no` = '" + i + "'";
                       

                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data updated");
                        string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='Delivered' order by ord_no desc";
                        MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                        DataTable zz = new DataTable();
                        dataa.Fill(zz);
                        DataGridView1.DataSource = zz;
                        comboBox2.Text = "Delivered";
                    }
                    else if (comboBox1.Text == "Invalid address")
                    {
                        string Body = "Hi " + username.Text + " " + "We could not deliver your food beasuse there is no valid address of you,please provide valid address and phone number " + "Thank you, Team asterisk";
                        int i = Int32.Parse(label2.Text);
                        string aa = comboBox1.Text;
                     
                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = " UPDATE `orders` SET `status` = '" + this.comboBox1.Text + "', `Message` = '" + textBox1.Text + "' WHERE `orders`.`ord_no` = '" + i + "'";


                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data updated");
                      
                        string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='Invalid address' order by ord_no desc";
                        MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                        DataTable zz = new DataTable();
                        dataa.Fill(zz);
                        DataGridView1.DataSource = zz;
                        comboBox2.Text = "Invalid address";
                    }
                    else
                    {
                        
                        int i = Int32.Parse(label2.Text);
                        string aa = comboBox1.Text;

                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = " UPDATE `orders` SET `status` = '" + this.comboBox1.Text + "', `Message` = '" + textBox1.Text + "' WHERE `orders`.`ord_no` = '" + i + "'";


                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data updated");
                        string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='" + this.comboBox1.Text + "' order by ord_no desc";
                        MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                        DataTable zz = new DataTable();
                        dataa.Fill(zz);
                        DataGridView1.DataSource = zz;
                        comboBox2.Text = comboBox1.Text;
                    }
                   
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
           
               
                username.Text = DataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                Foodname.Text = DataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                quantity.Text = DataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                Address.Text = DataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                time.Text = DataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                date.Text = DataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                string queryb = "SELECT delivery.status from delivery where ord_no= '"+username.Text+"' ";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                if (zz.Rows.Count != 0)
                {
                    textBox2.Text = zz.Rows[0].ToString();
                }
                else
                {
                    textBox2.Text = "Not Send to delivery";
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
         

            string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='" + comboBox2.Text + "' order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource = zz;
            try
            {if (DataGridView1.Rows.Count != 0)
                {
                    username.Text = zz.Rows[0][0].ToString();
                    Foodname.Text = zz.Rows[0][2].ToString();
                    quantity.Text = zz.Rows[0][3].ToString();
                    Address.Text = zz.Rows[0][1].ToString();
                    time.Text = zz.Rows[0][7].ToString();
                    date.Text = zz.Rows[0][6].ToString();
                    label2.Text = zz.Rows[0][0].ToString();
                    panel1.Visible = false;
                }
            else
                {
                    panel1.Visible = true;
                }
            }
            catch(Exception cc)
            {


            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='" + comboBox2.Text + "' order by ord_no desc";
            MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
            DataTable zz = new DataTable();
            dataa.Fill(zz);
            DataGridView1.DataSource = zz;
            try
            {
                if (DataGridView1.Rows.Count != 0)
                {
                    textBox2.Text = zz.Rows[0][5].ToString();
                    username.Text = zz.Rows[0][0].ToString();
                    Foodname.Text = zz.Rows[0][2].ToString();
                    quantity.Text = zz.Rows[0][3].ToString();
                    Address.Text = zz.Rows[0][1].ToString();
                    time.Text = zz.Rows[0][7].ToString();
                    date.Text = zz.Rows[0][6].ToString();
                    label2.Text = zz.Rows[0][0].ToString();
                    panel1.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                }
            }
            catch (Exception cc)
            {


            }




        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select user from deliveryboy where area='" + this.comboBox3.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable bb = new DataTable();
            data.Fill(bb);
            for (int i = 0; i < bb.Rows.Count; i++)
            {
                comboBox4.Text =Cryptography.Decrypt( bb.Rows[i][0].ToString());
                    
                    
                    
                    }



        }
       

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {if (comboBox3.Text != "" && comboBox4.Text != "")
            {

                int i = Int32.Parse(label2.Text);
                string aa = comboBox1.Text;

                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = " UPDATE `orders` SET `status` = 'OnTheway' WHERE `orders`.`ord_no` = '" + i + "'";


                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
               

                MySqlCommand mm = new MySqlCommand();
                mm.Connection = con;
                mm.CommandText = "Insert into delivery values(@ord,@user,@status)";
                mm.Parameters.AddWithValue("ord", username.Text);
                mm.Parameters.AddWithValue("user",Cryptography.Encrypt( comboBox4.Text));
                mm.Parameters.AddWithValue("status", "pending");

                con.Open();
                mm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data updated");



                string queryb = "SELECT orders.ord_no as SI,customer.address,food.foodname as food,orders.amount as Quantity,orders.tk as Tk,orders.status as Status,orders.Date as Date,orders.Time as Time from customer,orders,food Where orders.foodno=food.foodno and orders.username=customer.username and orders.status='OnThrway ' order by ord_no desc";
                MySqlDataAdapter dataa = new MySqlDataAdapter(queryb, con);
                DataTable zz = new DataTable();
                dataa.Fill(zz);
                DataGridView1.DataSource = zz;
                comboBox2.Text = "Ontheway";
            }
            else
            {


                MessageBox.Show("Please select delivery boy","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
