using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Fahrenheit value from the textbox.
                double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);

                // Calculate Celsius using the formula.
                double celsius = (fahrenheit - 32) * 5 / 9;

                // Display the result in the Celsius textbox.
                txtCelsius.Text = celsius.ToString("0.00"); // Format to two decimal places
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid Fahrenheit value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
