using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get current time and date
            DateTime now = DateTime.Now;

            // Format time and date as desired
            string timeString = now.ToString("03:04:50 AM"); // Hour, Minute, Second, AM/PM
            string dateString = now.ToString("Tuesday, November 19, 2024"); // Day of Week, Month, Day, Year

            // Update the label text
            label1.Text = dateString + Environment.NewLine + timeString;
        }

    }
}
