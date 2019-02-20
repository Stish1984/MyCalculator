using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
                double fstnumb = 0, scndnumb = 0, result = 0;
                char znak = '+';

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // c
        {
            textBox1.Clear();
            fstnumb = 0;
            scndnumb = 0;
            result = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                                 
        }

        private void button11_Click(object sender, EventArgs e) //x^2
        {
            fstnumb = Convert.ToDouble(textBox1.Text);
            result = Math.Pow ( fstnumb, 2 );
            textBox1.Text = Convert.ToString(result);
        }

        private void button16_Click(object sender, EventArgs e)  // x^3
        {
            fstnumb = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(fstnumb, 3);
            textBox1.Text = Convert.ToString(result);
        }
     
        private void button25_Click(object sender, EventArgs e)  // =
        {
               
            scndnumb = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    result = fstnumb + scndnumb;
                    return;
                case '-':
                    result = fstnumb - scndnumb;
                    break;
                case '*':
                    result = fstnumb * scndnumb;
                    break;
                case '/':
                    result = fstnumb / scndnumb;
                    break;
            }
            textBox1.Text = result.ToString();
        }
              
        private void button2_Click(object sender, EventArgs e)   //   CE
        {
            textBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fstnumb = Convert.ToDouble(textBox1.Text);
            result = fstnumb/100;
            textBox1.Text = Convert.ToString(result);
        }
        private void button4_Click(object sender, EventArgs e)  //  <=
        {
            if (textBox1.Text!="")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button22_Click(object sender, EventArgs e)   //  +/-
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else
                    textBox1.Text = '-' + textBox1.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)  //Sqrt
        {
            fstnumb = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(fstnumb);
            textBox1.Text = Convert.ToString(result);
        }

        private void button21_Click_1(object sender, EventArgs e)  // 1/x
        {
            fstnumb = Convert.ToDouble(textBox1.Text);
            result = 1/fstnumb;
            textBox1.Text = Convert.ToString(result);
        }

         private void button23_Click(object sender, EventArgs e)   //0-9
        {
            if (textBox1.Text != "")
            {
                string ending = textBox1.Text.Substring(textBox1.Text.Length - 1);
                if (ending == "+"  )
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                }
                else if (ending == "-")
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                }
                else if (ending == "*")
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                }
                else if (ending == "/")
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                }
                else
                    textBox1.Text += (sender as Button).Text;
            }
            else
                textBox1.Text += (sender as Button).Text;
         }

        private void button5_Click(object sender, EventArgs e)   //  +,-,*,/
        { 
                string ending = textBox1.Text.Substring(textBox1.Text.Length - 1);
                if (ending == "+")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    znak = (sender as Button).Text[0];
                    fstnumb = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + znak;
                }
                else if (ending == "-")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    znak = (sender as Button).Text[0];
                    fstnumb = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + znak;
                }
                else if (ending == "*")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    znak = (sender as Button).Text[0];
                    fstnumb = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + znak;
                }
                else if (ending == "/")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    znak = (sender as Button).Text[0];
                    fstnumb = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + znak;
                }
                else
                {
                    znak = (sender as Button).Text[0];
                    fstnumb = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + znak;
                }
        }
    }
}
