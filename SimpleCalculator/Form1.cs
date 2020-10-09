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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            return;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare output of try block for later use
            Decimal result;

            //start error checking
            try
            {
                // get vars and store as Decimal
                Decimal op1, op2;
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
            catch (FormatException)
            {
                MessageBox.Show(
                   "FormatExcpetion: Non-numberic input for operator." + "\n",

                   "FormatExcpetion Error");

                tbResult.Text = "";
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                   "OverflowException: Numeric output too large." + "\n",

                   "OverflowException Error");

                tbResult.Text = "";
                return;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                   "DivideByZeroException: Cannot divide by 0." + "\n",

                   "DivideByZeroException Error");

                tbResult.Text = "";
                return;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(
                   "InvalidOperationException: Operator missing or invalid. (Use +, -, *, /)" + "\n",

                   "InvalidOperationException Error");

                tbResult.Text = "";
                return;
            }
            // Catch all others and show stack
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),

                    "Error");

                tbResult.Text = "";
                return;
            }

            // send result to form
            tbResult.Text = Convert.ToString(result);

            return;
        }
    }
}
