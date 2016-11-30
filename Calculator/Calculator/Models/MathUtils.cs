using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class MathUtils
    {
        public double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        public double Substract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        public double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}