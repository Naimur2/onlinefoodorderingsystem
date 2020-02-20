using Bunifu.Framework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Class1
    {
        public static void number(System.Windows.Controls.TextBox textbox1, System.Windows.Controls.TextBox textbox2, System.Windows.Controls.Label labeltk)
        {
            
        }

        internal static void number(BunifuCustomTextbox textbox1, BunifuCustomTextbox textbox2, System.Windows.Forms.Label labeltk)
        {
            if (textbox1.Text != "")
            {

                try
                {
                    int c = Int32.Parse(textbox1.Text);
                    if (c < 11 && c > 0)
                    {

                        int i = c * Int32.Parse(labeltk.Text);

                        textbox2.Text = i.ToString();
                    }
                    else
                    {
                        textbox1.Text = "10";
                        System.Windows.Forms.MessageBox.Show("You can order at most 1 to 10");

                    }

                }
                catch (Exception ex)
                {


                    textbox1.Clear();
                }




            }
            else if (textbox1.Text == "")
            {
                textbox2.Text = "";

            }
        }
    }
}
