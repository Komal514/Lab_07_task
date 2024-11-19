
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  addition
        private double Add(double a, double b)
        {
            return a + b;
        }

        // subtraction
        private double Subtract(double a, double b)
        {
            return a - b;
        }

        // multiplication
        private double Multiply(double a, double b)
        {
            return a * b;
        }

        // division
        private double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation(Add);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation(Subtract);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation(Multiply);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                PerformCalculation(Divide);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PerformCalculation(Func<double, double, double> operation)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double result = operation(num1, num2);
                lblResult.Text = $"Result: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}







