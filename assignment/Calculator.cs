using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = "0";
            firstNumber = "0";
            secondNumber = "0";
            operation = ' ';
            isOperation = false;
            isDecimal = false;

            firstNumber = firstNumber.Substring(1);
            secondNumber = secondNumber.Substring(1);
        }

        public static bool isDecimal = false;
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (isOperation == false)
            {
                if (isDecimal == false)
                {
                    firstNumber += ".";
                    isDecimal = true;
                }
            }
            else if (isOperation)
            {
                if (isDecimal == false)
                {
                    secondNumber += ".";
                    isDecimal = true;
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }
        //_____________________OPERATION_________________________//
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            isOperation = true;
            isDecimal = false;
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
            isOperation = true;
            isDecimal = false;
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            operation = '*';
            isOperation = true;
            isDecimal = false;
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            isOperation = true;
            isDecimal = false;
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        public static double equal = 0;
        private void Btn1Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '+':
                    equal = Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber);
                    break;
                case '-':
                    equal = Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber);
                    break;
                case '*':
                    equal = Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber);
                    break;
                case '/':
                    equal = Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber);
                    break;
            }
            equalLabel.Text = Convert.ToString(equal);
        }

        private void BtnClear1_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                if (secondNumber.Length > 0)
                {
                    secondNumber = secondNumber.Substring(0, secondNumber.Length - 1);
                }
            }
            else if (isOperation == false)
            {
                if (firstNumber.Length > 0)
                {
                    firstNumber = firstNumber.Substring(0, firstNumber.Length - 1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        //_____________________NUMBER_________________________//
        public static string firstNumber = "0";
        public static string secondNumber = "0";
        public static char operation;
        public static bool isOperation = false;

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "7";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "7";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }

            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "8";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "8";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }

            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "0";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "0";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }

            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "9";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "9";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "4";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "4";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "5";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "5";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "6";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "6";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "1";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "1";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "2";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "2";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                secondNumber += "3";
                if (secondNumber.Substring(0, 1) == "0")
                {
                    secondNumber = secondNumber.Substring(1);
                }
            }
            else if (isOperation == false)
            {
                firstNumber += "3";
                if (firstNumber.Substring(0, 1) == "0")
                {
                    firstNumber = firstNumber.Substring(1);
                }
            }
            resultTextbox.Text = firstNumber + " " + operation + " " + secondNumber;
        }

        private void resultTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void equalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
