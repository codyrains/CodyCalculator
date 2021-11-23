using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var calculator = new Calculator();
            return calculator.GetValidInput();
        }

        static void MenuOptionSwitch(int menuOption)
        {
            Calculator calculator = new Calculator();
            DateCalculator dateCalculator = new DateCalculator();

            switch (menuOption)
            {
                case (int)MenuOptionEnum.Addition:
                    calculator.Addition();
                    break;
                case (int)MenuOptionEnum.Subtraction:
                    calculator.Subtraction();
                    break;
                case (int)MenuOptionEnum.Multiplication:
                    calculator.Multiplication();
                    break;
                case (int)MenuOptionEnum.Division:
                    calculator.Division();
                    break;
                case (int)MenuOptionEnum.Date:
                    dateCalculator.DaysUntil();
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
