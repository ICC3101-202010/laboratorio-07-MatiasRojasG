using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Poo
{
    public partial class Form1 : Form
    {
        List<double> resultados = new List<double> { };
        string operador;
        double Result;
        double num1, num2;
        Boolean ban_but=true, ban_num=true, ban_ope=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(ban_but==false)
            {
                if(ban_ope==false)
                {
                    num2 = Double.Parse(TxtResultado.Text);
                    f_switch(operador);
                    ban_num = true;
                    ban_but = true;
                    ban_ope = true;
                }
            }
        } //Boton Igual




        private void button13_Click(object sender, EventArgs e)
        {
            if (TxtResultado.TextLength>1)
            {
                TxtResultado.Text = TxtResultado.Text.Remove(TxtResultado.Text.Length - 1, 1);
            }
        }  //Boton Del

        private void button1_Click(object sender, EventArgs e)
        {
            if(ban_num==true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "1";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "1";
            }

            ban_but = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "2";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "2";
            }
            ban_but = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "3";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "3";
            }
            ban_but = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "4";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "4";
            }
            ban_but = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "5";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "5";
            }
            ban_but = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "6";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "6";
            }
            ban_but = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "7";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "7";
            }
            ban_but = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "8";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "8";
            }
            ban_but = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "9";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "9";
            }
            ban_but = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                TxtResultado.Clear();
                TxtResultado.Text = "0";
                ban_num = false;
            }
            else
            {
                TxtResultado.Text += "0";
            }
            ban_but = false;
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ",";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            ban_num = true;

            if(ban_ope)
            {
                num1 = Double.Parse(TxtResultado.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_but==false)
                {
                    num2 = Double.Parse(TxtResultado.Text);
                    f_switch(operador);
                    num1 = Double.Parse(TxtResultado.Text);
                    ban_num = true;
                    ban_but = true;
                }

            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            if (ban_but == false)
            {
                num1 = Double.Parse(TxtResultado.Text);
                TxtResultado.Clear();
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            if (ban_but == false)
            {
                num1 = Double.Parse(TxtResultado.Text);
                TxtResultado.Clear();
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            if (ban_but == false)
            {
                num1 = Double.Parse(TxtResultado.Text);
                TxtResultado.Clear();
            }
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

         private void buttonAns_Click(object sender, EventArgs e)
         {
         operador = "ans";
         if (ban_but == true)
         {
            TxtResultado.Text=Result.ToString();
         }
         }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
            ban_num = true;
            ban_but = true;
            ban_ope = true;
        }
        private double f_switch(string ope)
        {
            switch (operador)
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
                    Result = num1 / num2;
                    break;
            }
            TxtResultado.Text = Result.ToString();
            return Result;
        }
    }
}
