using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Poo
{
    public partial class Form1 : Form
    {
        string operador;
        double Result;
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(TxtResultado.Text);
            switch(operador)
            {
                case "+":
                    Result = num1 + num2;
                    break;
                case "-":
                    Result = num1 - num2;
                    break;
                case "*":
                    Result = num1 * num2;
                    break;
                case "/":
                    try
                    {
                        Result = num1 / num2;
                        break;
                    }
                    catch
                    {
                        TxtResultado.Text = "Math ERROR";
                        break;
                    }

            }
            TxtResultado.Text = Result.ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (TxtResultado.TextLength>1)
            {
                TxtResultado.Text = TxtResultado.Text.Remove(TxtResultado.Text.Length - 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ".";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Double.Parse(TxtResultado.Text);
            TxtResultado.Clear();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Double.Parse(TxtResultado.Text);
            TxtResultado.Clear();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Double.Parse(TxtResultado.Text);
            TxtResultado.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Double.Parse(TxtResultado.Text);
            TxtResultado.Clear();
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
        }
    }
}
