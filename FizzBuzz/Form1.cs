using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class frmFizzBuzz : Form
    {
        public frmFizzBuzz()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Total;
            String temp;
            String TheDecision = "The number is not divisible";

            temp = txtInput.Text;

            int TheNumber = Int32.Parse(temp);


            Total = TheNumber % 3;
            if (Total == 0)
            {
                TheDecision = "Fizz";
            }
            Total = TheNumber % 5;
            if (Total == 0)
            {
                TheDecision = "Buzz";
            }
            Total = TheNumber % 15;
            if (Total == 0)
            {
                TheDecision = "FizzBuzz";
            }



            txtOutput.Text = TheDecision;
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            txtInput.SelectionStart = 0;

            txtInput.SelectionLength = txtInput.Text.Length;
        }
    }
}
