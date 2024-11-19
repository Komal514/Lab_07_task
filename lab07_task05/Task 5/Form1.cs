using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtNumber.Text, out num))
            {
                if (num < 0)
                {
                    MessageBox.Show("Please enter a non-negative number.");
                }
                else
                {
                    int factorial = CalculateFactorial(num);
                    lblFactorial.Text = "Factorial: " + factorial;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void tnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
