using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class DateCalculator : CalculatorExtensions
    {
        public DateCalculator(Logger logger) : base(logger) { }

        public void DaysUntil()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("Please enter the date (mm/dd/yyyy)");
            dateTime = GetCurrentDate();
            var timeSpan = DateTime.Today - dateTime;

            if (timeSpan.Days > 0)
            {
                Console.WriteLine("There have been " + timeSpan.Days + " day(s) since then.");
            }
            else if (timeSpan.Days < 0)
            {
                Console.WriteLine("There are " + timeSpan.Days * (-1) + " day(s) until then.");
            }
            else
            {
                Console.WriteLine("That is today's date.");
            }
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
                    _logger.Log("Invalid user input: " + input);
                }
                else
                {
                    Console.WriteLine("Is the date " + value.ToShortDateString() + " correct? (y/n)");
                    string validation = Console.ReadLine();
                    if (validation.ToLower() == "y")
                    {
                        stop = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the correct date (mm/dd/yyyy)");
                        _logger.Log("Invalid user input: " + input);
                    }

                }
            }
            return value;
        }
    }
}
