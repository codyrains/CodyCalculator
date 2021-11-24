using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class Calculator : CalculatorExtensions
    {
        public Calculator(Logger logger) : base (logger) { }

        public void Addition()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne + inputObj.valueTwo;

            Console.WriteLine(inputObj.resultString(result, "+"));
        }

        public void Subtraction()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne - inputObj.valueTwo;
            Console.WriteLine(inputObj.resultString(result, "-"));
        }

        public void Multiplication()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne * inputObj.valueTwo;
            Console.WriteLine(inputObj.resultString(result, "x"));
        }

        public void Division()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            if (inputObj.valueTwo == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please re-enter inputs.");
                Division();
            }
            else
            {
                int result = inputObj.valueOne / inputObj.valueTwo;
                Console.WriteLine(inputObj.resultString(result, "/\n"));
            }
        }
    }
}
