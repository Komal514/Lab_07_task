using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_task09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the MaxLength
            txtInput.MaxLength = 160;
            // Initialize  the max length
            lblRemainingChars.Text = $"Remaining characters: {txtInput.MaxLength}";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // calculate remaining characters
            int remaining = txtInput.MaxLength - txtInput.Text.Length;

            // Update remaining characters
            lblRemainingChars.Text = $"Remaining characters: {remaining}";
        }

        private void lblRemainingChars_Click(object sender, EventArgs e)
        {

        }
    }
}
