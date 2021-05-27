using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void clearbutton(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void del_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int length = s.Length;
            if (length > 0)
            {
                textBox1.Text = s.Substring(0, s.Length - 1);
            }
            else
            {
                textBox1.Text = "";
            }
            
        }

        private void intchang_Click(object sender, EventArgs e)
        {
            float s = float.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(s * (-1));
            // string 轉 int : int.Parse(string);
            // int 轉 string : Convert.ToString(int);

        }

        private void point_chick(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "")
            {
                textBox1.Text = "0";
            }
            else if (s == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }
        float num1;
        float num2;
        string fun = "";
        private void setnum()
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            setnum();
            fun = "%";
     
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            setnum();
            fun = "*";
        }

        private void reduce_Click(object sender, EventArgs e)
        {
            setnum();
            fun = "-";
        }

        private void add_click(object sender, EventArgs e)
        {
            setnum();
            fun = "+";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            if (fun == "+")
            {
                textBox1.Text = Convert.ToString(num1 + num2);
            }
            else if (fun == "-")
            {
                textBox1.Text = Convert.ToString(num1 - num2);
            }
            else if (fun == "*")
            {
                textBox1.Text = Convert.ToString(num1 * num2);
            }
            else if (fun == "%")
            {       
                textBox1.Text = Convert.ToString(num1 / num2);
            }

        }

        private void root_Click(object sender, EventArgs e)
        {
            Double num = float.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(num));
        }
    }
}
