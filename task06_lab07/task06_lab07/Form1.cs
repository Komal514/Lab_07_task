using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task06_lab07
{
    public partial class Form1 : Form
    {
        private int countdownTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void QuizStart_Click(object sender, EventArgs e)
        {
            try
            {
                countdownTime = int.Parse(label1.Text); timer1.Interval = 1000; // 1 second intervals
                timer1.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void timer1_Tick_TextChanged(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--;
                label2.Text = "Time Left: " + countdownTime + " seconds";
            }
            else
            { timer1.Stop(); MessageBox.Show("Time Over!"); }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

