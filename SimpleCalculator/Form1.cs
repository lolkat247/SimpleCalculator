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
            // declare flag for errors
            bool isInvalid = false;

            // get vars and store as Decimal
            Decimal op1, op2;
            try
            {
                op1 = Convert.ToDecimal(tbOp1.Text);
                op2 = Convert.ToDecimal(tbOp2.Text);
            }
            catch (Exception)
            {
                isInvalid = true;
                op1 = 0.0m;
                op2 = 0.0m;
            }


            // do operation and get result
            Decimal result = 0.0m;
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
                    isInvalid = true;
                    break;
            }

            // send result to form
            if (isInvalid)
            {
                MessageBox.Show("Invalid input; please try again.");
                tbResult.Text = "";
            }
            else 
            {
                tbResult.Text = Convert.ToString(result);
            }
        }
    }
}
