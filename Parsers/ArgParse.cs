using System;

namespace PurcellTechTest.Parsers
{
    public class ArgParse{
        public static int[] parseArguments(string[] args){
            // Convert string arguments to integers
            int[] numbers = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = int.Parse(args[i]);
            }
            return numbers;
        }
    }
}
