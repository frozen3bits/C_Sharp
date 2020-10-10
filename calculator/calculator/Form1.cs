using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{  
    public partial class Form1 : Form
    {
        int a = 0;
        char x = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text+"1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            a = 0;
            x = ' ';
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case '+':
                    {
                        a = Convert.ToInt32(textBox1.Text) + a;
                        break;
                    }
                case '-':
                    {
                        a = Convert.ToInt32(textBox1.Text) - a;
                        break;
                    }
                case '*':
                    {
                        a = Convert.ToInt32(textBox1.Text) * a;
                        break;
                    }
                case '/':
                    {
                        a = Convert.ToInt32(textBox1.Text) / a;
                        break;
                    }
                default:
                    {
                        a = Convert.ToInt32(textBox1.Text);
                        break;
                    }
            }
            x = '+';
            textBox1.Text = "0";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case '+':
                    {
                        a = Convert.ToInt32(textBox1.Text) + a;
                        break;
                    }
                case '-':
                    {
                        a = Convert.ToInt32(textBox1.Text) - a;
                        break;
                    }
                case '*':
                    {
                        a = Convert.ToInt32(textBox1.Text) * a;
                        break;
                    }
                case '/':
                    {
                        a = Convert.ToInt32(textBox1.Text) / a;
                        break;
                    }
                default:
                    {
                        a = Convert.ToInt32(textBox1.Text);
                        break;
                    }
            }
            x = '-';
            textBox1.Text = "0";
        }

        private void buttonMulp_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case '+':
                    {
                        a = Convert.ToInt32(textBox1.Text) + a;
                        break;
                    }
                case '-':
                    {
                        a = Convert.ToInt32(textBox1.Text) - a;
                        break;
                    }
                case '*':
                    {
                        a = Convert.ToInt32(textBox1.Text) * a;
                        break;
                    }
                case '/':
                    {
                        a = Convert.ToInt32(textBox1.Text) / a;
                        break;
                    }
                default:
                    {
                        a = Convert.ToInt32(textBox1.Text);
                        break;
                    }
            }
            x = '*';
            textBox1.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case '+':
                    {
                        a = Convert.ToInt32(textBox1.Text) + a;
                        break;
                    }
                case '-':
                    {
                        a -= Convert.ToInt32(textBox1.Text);
                        break;
                    }
                case '*':
                    {
                        a = Convert.ToInt32(textBox1.Text) * a;
                        break;
                    }
                case '/':
                    {
                        a /=  Convert.ToInt32(textBox1.Text);
                        break;
                    }
                default:
                    {
                        a = Convert.ToInt32(textBox1.Text);
                        break;
                    }
            }
            x = '/';
            textBox1.Text = "0";
        }

        private void buttonEql_Click(object sender, EventArgs e)
        {
            if(x != ' ')
            {
                switch (x)
                {
                    case '+':
                        {
                            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + a);
                            break;
                        }
                    case '-':
                        {
                            textBox1.Text = Convert.ToString(a - Convert.ToInt32(textBox1.Text));
                            break;
                        }
                    case '*':
                        {
                            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * a);
                            break;
                        }
                    case '/':
                        {
                            textBox1.Text = Convert.ToString(a / Convert.ToInt32(textBox1.Text));
                            break;
                        }
                }
                
            };
            a = Convert.ToInt32(textBox1.Text);
            x = ' ';
            a = 0;
        }
    }
}
