using System;
using PurcellTechTest.Services;
using PurcellTechTest.Parsers;

namespace PurcellTechTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Purcell tech test missing number problem.");
            Console.WriteLine("Please enter numbers separated by spaces (e.g. 3 0 1) which will represent the array [3,0,1]");

            // get the user input
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (inputArray.Length == 0)
            {
                Console.WriteLine("Please enter numbers.");
                return;
            }
            // parse the input
            var numbers = ArgParse.parseArguments(inputArray);
            // get the missing number using the logicservce
            int missingNumber = LogicService.MissingNumberLogic(numbers);
            // missing number found
            Console.WriteLine("The following is the missing number:");
            Console.WriteLine(missingNumber);
        }
    }
}
