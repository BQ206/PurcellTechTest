using System;

namespace PurcellTechTest.Services
{
    public static class LogicService
    {
        public static int MissingNumberLogic(int[] numbers)
        {
            Console.WriteLine("Processing data in LogicService...");
            int n = numbers.Length;
            // get expected value based on the length of the array
            int expected = (n * (n + 1) / 2);
            // then calculate the actual value
            int actual = 0;
            for(int i = 0; i < n; i ++){
                actual += numbers[i];
            }
            // take the expected value minus the actual value to find the missing number
            return expected - actual;
        }
    }
}
