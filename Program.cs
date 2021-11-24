using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class Program
    {
        private static Calculator _calculator;
        private static DateCalculator _dateCalculator;

        static void Main(string[] args)
        {
            Initialize();
            bool stop = false;

            while (!stop) 
            {
                int menuOption = Menu();

                if(menuOption == (int)MenuOptionEnum.Quit)
                {
                    stop = true;
                }
                else
                {
                    MenuOptionSwitch(menuOption); 
                }
                Console.WriteLine("\n");
            }
        }

        static void Initialize()
        {
            Logger logger = new Logger();
            _calculator = new Calculator(logger);
            _dateCalculator = new DateCalculator(logger);
        }

        static int Menu()
        {
            Console.WriteLine("Calculator Menu\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Date and Time");
            Console.WriteLine("6. Quit\n");
            Console.WriteLine("Enter your option (number only).");

            return _calculator.GetValidInput();
        }

        static void MenuOptionSwitch(int menuOption)
        {
            switch (menuOption)
            {
                case (int)MenuOptionEnum.Addition:
                    _calculator.Addition();
                    break;
                case (int)MenuOptionEnum.Subtraction:
                    _calculator.Subtraction();
                    break;
                case (int)MenuOptionEnum.Multiplication:
                    _calculator.Multiplication();
                    break;
                case (int)MenuOptionEnum.Division:
                    _calculator.Division();
                    break;
                case (int)MenuOptionEnum.Date:
                    _dateCalculator.DaysUntil();
                    break;

                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        Menu();
                        break;
                    }
            }
        }
    }
}
