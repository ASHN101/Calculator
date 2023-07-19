using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbxInput1.Text);
            double num2 = double.Parse(tbxInput2.Text);
            double answer = num1 / num2;
            lblAnswer.Text = "= "+answer.ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbxInput1.Text);
            double num2 = double.Parse(tbxInput2.Text);
            double answer = num1 * num2;
            lblAnswer.Text = "= " + answer.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbxInput1.Text);
            double num2 = double.Parse(tbxInput2.Text);
            double answer = num1 + num2;
            lblAnswer.Text = "= " + answer.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbxInput1.Text);
            double num2 = double.Parse(tbxInput2.Text);
            double answer = num1 - num2;
            lblAnswer.Text = "= " + answer.ToString();
        }

        private void tbxInput1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
