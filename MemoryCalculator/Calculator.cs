// Amber Holcomb-Stone
// Lab 5: Create a Memory Calculator
// Source code adapted and modified from: https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/
// https://www.dreamincode.net/forums/topic/32968-basic-calculator-in-c%23/
// https://github.com/jameswillhoite/CITC2311/tree/master/Lab5/Calculator/Calculator
// https://soumiaw.wordpress.com/2011/01/03/simple-calculator-in-c/
// Form Load Turn Hightlight Off - TabStop to false: https://stackoverflow.com/questions/3421453/why-is-text-in-textbox-highlighted-selected-when-form-is-displayed
// Additional Memory Understanding: https://github.com/CodingGuruInTraining/MemoryCalculator/blob/master/Project%2012-1%20Basic%20Calculator/MemoryCalculator.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCalculator
{
    public class Calculator
    {
        public string input = "";
        public string operand1 = "0";
        public string operand2 = "0";
        public char op;
        public double result = 0.0;


        public void Calculation()
        {
            double num1;
            double num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (op == '+')
            {
                result = num1 + num2;
                input = result.ToString();
            }
            else if (op == '-')
            {
                result = num1 - num2;
                input = result.ToString();
            }
            else if (op == '*')
            {
                result = num1 * num2;
                input = result.ToString();
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    input = result.ToString();
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
        }

        public void Sqrt()
        {
            double num1;
            double.TryParse(input, out num1);
            result = Math.Sqrt(num1);
            input = result.ToString();
        }

        public void Reciprocal()
        {
            double num1;
            double.TryParse(input, out num1);

            if (num1 != 0)
            {
                result = 1 / num1;
                input = result.ToString();
            }
            else
            {
                input = string.Empty;
                throw new DivideByZeroException();
            }
        }

        public void PositiveNegative()
        {
            double num1;
            double.TryParse(input, out num1);

            result = num1 / -1;
            input = result.ToString();
        }



    }
}