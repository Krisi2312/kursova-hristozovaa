using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova_rabota_hristozova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var textNumLeft = textBoxleft.Text.Select(i => Convert.ToInt32(textBoxleft.Text)).ToArray();
            */
            int textNumLeft = Convert.ToInt32(textBoxleft.Text);
            int textNumRight = Convert.ToInt32(textBoxright.Text);

            if (textBoxleft.Text.Length == 0 || textBoxright.Text.Length == 0)
            {
                label5.Text = "въвел си едно въвеждане";

            }
            else
            {
                label8.Text = " колко броя въвеждания:" +textBox1.Text ;

                label6.Text = " лява страна: " + textBoxleft.Text;
               
                
                label7.Text = " дясна страна: " + textBoxright.Text;

                if (textNumLeft != textNumRight)
                {
                    label9.Text = textBoxleft.Text + " не е " + textBoxright.Text + " не са равни двете страни";
                }
                
                else 
                {
                    label9.Text = textBoxleft.Text + " e " + textBoxright.Text + " двете страни са равни";
                }
               

            }
            {
                
            }
            // dva teksboksa (tekstovete) da gi preverna v int s int parse i da gi sravnq

        }
    }
}
