using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    class Program : CalculatorExtensions
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
            
            return GetValidInput();
        }

        static void MenuOptionSwitch(int menuOption)
        {
            switch(menuOption)
            {
                case (int)MenuOptionEnum.Addition:
                    Addition();
                    break;
                case (int)MenuOptionEnum.Subtraction:
                    Subtraction();
                    break;
                case (int)MenuOptionEnum.Multiplication:
                    Multiplication();
                    break;
                case (int)MenuOptionEnum.Division:
                    Division();
                    break;
                case (int)MenuOptionEnum.Date:
                    DaysUntil();
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

        

        static void Addition()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne + inputObj.valueTwo;

            Console.WriteLine(inputObj.resultString(result, "+"));
        }

        static void Subtraction()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne - inputObj.valueTwo;

            Console.WriteLine(inputObj.resultString(result, "-"));
        }

        static void Multiplication()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne * inputObj.valueTwo;

            Console.WriteLine(inputObj.resultString(result, "x"));
        }

        static void Division()
        {
            InputObject inputObj = new InputObject();
            inputObj = GetInputs();

            int result = inputObj.valueOne / inputObj.valueTwo;

            Console.WriteLine(inputObj.resultString(result, "/"));
        }

        static void DaysUntil()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("Please enter the date (mm/dd/yyyy)");
            dateTime = GetCurrentDate();
            var timeSpan = DateTime.Today - dateTime;
            
            if(timeSpan.Days > 0)
            {
                Console.WriteLine("There have been " + timeSpan.Days + " day(s) since then.");
            }
            else if(timeSpan.Days < 0)
            {
                Console.WriteLine("There are " + timeSpan.Days*(-1) + " day(s) until then.");
            }
            else
            {
                Console.WriteLine("That is today's date.");
            }
        }

        static InputObject GetInputs()
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
