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
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number)) { return true; }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " +
                    Convert.ToString(min) + " and " + Convert.ToString(max) + ".",

                    "Entry Error");
                textBox.Focus();
                return false;
            }
            else { return true; }
        }

        public bool IsOperator(TextBox textBox)
        {
            string[] ops = { "+", "-", "*", "/" };
            if (ops.Contains(textBox.Text)) { return true; }
            else 
            {
                MessageBox.Show("Invalid operator; use +, -, *, /", "Entry Error");
                textBox.Focus();

                return false;
            }
        }

        public bool IsValidData()
        {
            if (
                IsPresent(tbOp1, "Operand 1") &&
                IsPresent(tbOp2, "Operand 2") &&
                IsPresent(tbOper, "Operator") &&

                IsDecimal(tbOp1, "Operand 1") &&
                IsDecimal(tbOp2, "Operand 2") &&
                IsOperator(tbOper) &&

                IsWithinRange(tbOp1, "Operand 1", 0m, 1000000m) &&
                IsWithinRange(tbOp2, "Operand 2", 0m, 1000000m)

            ) { return true; }
            else { return false; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            return;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare output of try block for later use
            decimal result;

            //start error checking
            try
            {
                // get vars and store as Decimal
                decimal op1, op2;
                op1 = Convert.ToDecimal(tbOp1.Text);
                op2 = Convert.ToDecimal(tbOp2.Text);

                // do operation and get result
                result = 0.0m;
                switch (tbOper.Text)
                {
                    case "+":
                        result = op1 + op2;
                        break;

                    case "-":
                        result = op1 - op2;
                        break;

                    case "*":
                        result = op1 * op2;
                        break;

                    case "/":
                        result = op1 / op2;
                        break;

                    default:
                        throw new InvalidOperationException(); // operator is null
                }
            }
            // Catch all others and show stack
            catch (Exception ex)
            {
                if (IsValidData()) {
                    MessageBox.Show(
                        ex.ToString(),

                        "Error");

                    tbResult.Text = "";
                }
                return;
            }

            // send result to form
            tbResult.Text = Convert.ToString(result);

            return;
        }
    }
}
