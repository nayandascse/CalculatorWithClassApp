using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithClassApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calculate =new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = calculate.Add(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = calculate.Subtract(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = calculate.Multiply(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void dividedButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = calculate.Divide(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }
    }
}
