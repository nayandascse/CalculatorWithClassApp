using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithClassApp
{
    class Calculator
    {
        //public double firstNumber;
        //public double secondNumber;
        public double result;

        public double Add(double firstNumber, double secondNumber)
        {
            result = firstNumber + secondNumber;
            return result;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            result = firstNumber - secondNumber;
            return result;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            result = firstNumber * secondNumber;
            return result;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber!=0)
            {
                result = firstNumber / secondNumber;
                return result;
            }
            else
            {
                MessageBox.Show("Second Number Must Be Grater Than 0");
                return 0;
            }
            
            
        }
    }
}
