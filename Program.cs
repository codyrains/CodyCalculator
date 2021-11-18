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

                if(menuOption == 5)
                {
                    stop = true;
                }
                else
                {
                    MenuOptionSwitch(menuOption); 
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("Calculator Menu\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Quit\n");
            Console.WriteLine("Enter your option.");
            string menuOption = Console.ReadLine();
            return Int32.Parse(menuOption);
        }

        static void MenuOptionSwitch(int menuOption)
        {
            switch(menuOption)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        static void Addition()
        {

            Console.Write("Enter first number: ");
            Console.ReadLine();
            Console.Write("Enter second number: ");
            Console.ReadLine();
        }

        static void Subtraction()
        {

        }

        static void Multiplication()
        {

        }

        static void Division()
        {

        }

        static InputObject GetInputs()
        {
            Console.Write("Enter first number: ");
            Console.ReadLine();
            Console.Write("Enter second number: ");
            Console.ReadLine();
        }
    }
}
