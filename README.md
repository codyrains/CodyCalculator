# CodyCalculator

A calculator application that allows the user to add, subtract, multiply or divide two integers and return the correct value.

Requirements list:

1. A master loop around the calculator itself, allowing the user to repeatedly interact with it or quit the application.
2. Created an additional class (CalculatorExtensions.cs) that Calculator.cs and DateCalculator.cs inherit from. The default ReadLine reads a string input. This method only allows integers, and will tell the user to enter an integer only if they enter a letter or other character. Also added the getInput method that gets console input for the calculator and dateCalculator class.
3. Calculated and displayed data to get the current date and display the amount of days since/until a specific date.
4. Implemented a log that records errors, invalid inputs, or other important events and writes them to a text file.
