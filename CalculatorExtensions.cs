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

        public static DateTime GetCurrentDate()
        {
            bool stop = false;
            DateTime value = new DateTime();
            while (!stop)
            {
                string input = Console.ReadLine();

                if (!DateTime.TryParse(input, out value))
                {
                    Console.WriteLine("Invalid input. Please enter a date in the format of mm/dd/yyyy");
                }
                else
                {
                    Console.WriteLine("Is the date " + value.ToShortDateString() +  " correct? (y/n)");
                    string validation = Console.ReadLine();
                    if(validation.ToLower() == "y")
                    {
                        stop = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the correct date (mm/dd/yyyy)");
                    }

                }
            }
            return value;
        }
    }
}
