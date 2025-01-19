using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        
        private bool isDegrees = true; 
        public Form1()
        {
            InitializeComponent();
            cmbMode.Items.Add("Градусы");
            cmbMode.Items.Add("Радианы");
            cmbMode.SelectedIndex = 0; 
        }

       

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        float a, b;
        int count;
        bool znak = true;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;

        }

        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }
private void btnEqual_Click(object sender, EventArgs e)
       
            {
                calculate();
                label1.Text = "";
            }

       

        private void calculate()
            {
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 2:
                        b = a - float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 4:
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    default:
                        break;
                }

            }

        private void btnTrigFunction_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(textBox1.Text, out double angle))
            {
                double result = 0;
                double angleInRadians = isDegrees ? angle * Math.PI / 180 : angle;

                switch (button.Text)
                {
                    case "sin":
                        result = Math.Sin(angleInRadians);
                        break;
                    case "cos":
                        result = Math.Cos(angleInRadians);
                        break;
                    case "tan":
                        result = Math.Tan(angleInRadians);
                        break;
                }

                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDegrees = cmbMode.SelectedIndex == 0; 
        }
    }
}
