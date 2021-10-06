using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Ask the user to enter an integer
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            String binary1 = num1.ToString();
            String binary2 = num2.ToString();

            //detects binary in numbers and adds them together as binary
            if (Regex.IsMatch(binary1, "^[01]+$") && Regex.IsMatch(binary2, "^[01]+$"))
            {
                String binarySum = binary1 + binary2;
                String result = Convert.ToInt32(binarySum, 2).ToString();

                return Convert.ToDouble(result);
            }

            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 !=0 && num2 == 0)
            {
                //attempting to divide a non-zero number by zero - return positive infinity
                return (double.PositiveInfinity);
            }

            if (num1 == 0 && num2 == 0)
            {
                // both numbers are zero
                // 0 divided by 0 is 1

                return 1;
            }

            return (num1 / num2);
        }

        public int Factorial(double num)
        {
            //allow double for num so as to allow exception catching

            int a;

            if (!int.TryParse(num.ToString(), out a))
                throw new ArgumentException("Number is not an integer");

            if (num < 0)
                throw new ArgumentException("Number is less than 0");

            if (num == 0)
                return 1;

            int n = Convert.ToInt32(num);   //should be able to convert, exception accounted for previously

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            return n;
        }

        public double Triangle(double num1, double num2)
        {
            return (num1 * num2 * 0.5);
        }

        public double Circle(double num1)
        {
            //round to 2 decimal places
            return Math.Round((num1 * num1 * 3.1415), 2);
        }

        public double UnknownFunctionA(double num1, double num2)
        {
            //2 factorial, 1 subtract, 1 divide
            //permutation

            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        public double UnknownFunctionB(double num1, double num2)
        {

            //3 factorial, 1 subtract, 1 divide, 1 multiply
            //combination

            return Divide(Factorial(num1), Multiply(Factorial(Subtract(num1, num2)), Factorial(num2)));
        }

        public double MTBF(double num1, double num2)
        {
            return (Add(num1, num2));
        }

        public double Availability(double num1, double num2)
        {
            return Math.Round(Divide(num1, MTBF(num1, num2)), 3);   // round to 3 decimal place
        }

        public double DefectDensity(double defects, double codeSize)
        {
            return Divide(defects, codeSize); //round to 3 decimal places
        }
    }
}
