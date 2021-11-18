using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class CalculatorExtensions
    {
        public static int GetValidInput()
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
    }
}
