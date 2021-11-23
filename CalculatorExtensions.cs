using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class CalculatorExtensions
    {
        public int GetValidInput()
        {
            bool stop = false;
            int value = 0;

            while (!stop)
            {
                string input = Console.ReadLine();

                if (!Int32.TryParse(input, out value))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
                else
                {
                    stop = true;
                }
            }

            return value;
        }

        public InputObject GetInputs()
        {
            InputObject inputObject = new InputObject();

            Console.Write("Enter first number: ");
            inputObject.valueOne = GetValidInput();
            Console.Write("Enter second number: ");
            inputObject.valueTwo = GetValidInput();
            return inputObject;
        }
    }
}
