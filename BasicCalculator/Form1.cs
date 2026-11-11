using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                string opr = cmbOperator.Text;

                float result = 0;

                if (opr == "+")
                {
                    result = BasicComputation.Addition(num1, num2);
                }
                else if (opr == "-")
                {
                    result = BasicComputation.Subtraction(num1, num2);
                }
                else if (opr == "*")
                {
                    result = BasicComputation.Multiplication(num1, num2);
                }
                else if (opr == "/")
                {
                    result = BasicComputation.Division(num1, num2);
                }
                else
                {
                    MessageBox.Show("Please select a valid operator.");
                    return;
                }

                lblAnswer.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Cannot divide by zero!", "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblAnswer.Text = "Error";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter any valid numbers. Don't leave any fields empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

