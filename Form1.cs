using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operandOne = string.Empty;
        string operandTwo = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "0";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "1";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "2";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "3";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "4";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "5";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "6";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "7";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "8";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += "9";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            input += ".";
            this.bunifuMaterialTextbox1.Text += input;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.bunifuMaterialTextbox1.Text = "";
            this.input = string.Empty;
            this.operandOne = string.Empty;
            this.operandTwo = string.Empty;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '/';
            input = string.Empty;
        }

        private void timesBtn_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '*';
            input = string.Empty;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '+';
            input = string.Empty;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            operandOne = input;
            operation = '-';
            input = string.Empty;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            operandTwo = input;
            double num1, num2;
            double.TryParse(operandOne, out num1);
            double.TryParse(operandTwo, out num2);

            this.bunifuMaterialTextbox1.Text = "";
            this.input = string.Empty;
            this.operandOne = string.Empty;
            this.operandTwo = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                bunifuMaterialTextbox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                bunifuMaterialTextbox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                bunifuMaterialTextbox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    bunifuMaterialTextbox1.Text = result.ToString();
                }
                else
                {
                    bunifuMaterialTextbox1.Text = "undefined";
                }

            }
        }
    }
}