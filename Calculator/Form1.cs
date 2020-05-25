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
        //initialise the public variables in use
        public string equation = "";
        public double first_value;
        public double second_value;
        public string Operator;
        public double result;

        public Form1()
        {
            InitializeComponent();
        }

        //onclick functions for the numerical buttons
        private void BTN1_Click(object sender, EventArgs e)
        {
            equation = equation + "1";
            TBEquationView.Text = equation;
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            equation = equation + "2";
            TBEquationView.Text = equation;
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            equation = equation + "3";
            TBEquationView.Text = equation;
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            equation = equation + "4";
            TBEquationView.Text = equation;
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            equation = equation + "5";
            TBEquationView.Text = equation;
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            equation = equation + "6";
            TBEquationView.Text = equation;
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            equation = equation + "7";
            TBEquationView.Text = equation;
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            equation = equation + "8";
            TBEquationView.Text = equation;
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            equation = equation + "9";
            TBEquationView.Text = equation;
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            equation = equation + "0";
            TBEquationView.Text = equation;
        }



        //onclick functions for the operators
        private void BTNDivide_Click(object sender, EventArgs e)
        {
            if (TBEquationView.Text == null || TBEquationView.Text == "")
            {
                TBEquationView.Text = "";
                equation = "";
            }
            if (Operator == null || Operator == "")
            {
                first_value = System.Convert.ToDouble(TBEquationView.Text);
                Operator = "/";
                TBEquationView.Text = "";
                equation = "";
            }
            else if (Operator == "+")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value + second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "-")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value - second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "/")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value / second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "*")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value * second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
        }

        private void BTNMultiply_Click(object sender, EventArgs e)
        {
            if (TBEquationView.Text == null || TBEquationView.Text == "")
            {
                TBEquationView.Text = "";
                equation = "";
            }
            if (Operator == null || Operator == "")
            {
                first_value = System.Convert.ToDouble(TBEquationView.Text);
                Operator = "*";
                TBEquationView.Text = "";
                equation = "";
            }
            else if (Operator == "+")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value + second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "-")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value - second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "/")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value / second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "*")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value * second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
        }

        private void BTNMinus_Click(object sender, EventArgs e)
        {
            if (TBEquationView.Text == null || TBEquationView.Text == "")
            {
                TBEquationView.Text = "";
                equation = "";
            }
            if (Operator == null || Operator == "")
            {
                first_value = System.Convert.ToDouble(TBEquationView.Text);
                Operator = "-";
                TBEquationView.Text = "";
                equation = "";
            }
            else if (Operator == "+")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value + second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "-")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value - second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "/")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value / second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "*")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value * second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
        }

        private void BTNPlus_Click(object sender, EventArgs e)
        {

            if (TBEquationView.Text == null || TBEquationView.Text == "")
            {
                TBEquationView.Text = "";
                equation = "";
            }
            else if (Operator == null || Operator == "")
            {
                first_value = System.Convert.ToDouble(TBEquationView.Text);
                Operator = "+";
                TBEquationView.Text = "";
                equation = "";
            }
            else if (Operator == "+")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value + second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "-")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value - second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "/")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value / second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
            else if (Operator == "*")
            {
                second_value = Convert.ToDouble(equation);
                result = first_value * second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = result;
                equation = "";
            }
        }

        private void BTNDecimal_Click(object sender, EventArgs e)
        {
            equation = equation + ".";
            TBEquationView.Text = equation;
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            TBEquationView.Text = "";
            first_value = 0;
            second_value = 0;
            Operator = "";
            result = 0;
        }

        private void BTNEquals_Click(object sender, EventArgs e)
        {
            second_value = System.Convert.ToDouble(TBEquationView.Text);

            if(Operator == "+")
            {
                result = first_value + second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = 0;
                second_value = 0;
                Operator = "";
                result = 0;
            }
            if (Operator == "-")
            {
                result = first_value - second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = 0;
                second_value = 0;
                Operator = "";
                result = 0;
            }
            if (Operator == "/")
            {
                result = first_value / second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = 0;
                second_value = 0;
                Operator = "";
                result = 0;
            }
            if (Operator == "*")
            {
                result = first_value * second_value;
                TBEquationView.Text = Convert.ToString(result);
                first_value = 0;
                second_value = 0;
                Operator = "";
                result = 0;
            }
        }
    }
}
