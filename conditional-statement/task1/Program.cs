using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Prompt user
            Console.Write("Please enter a number: ");

            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            // IF > 0
            if (evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is greater than 0", evaluatedNumber);
            }

            // IF < 0
            else if(evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is less than 0", evaluatedNumber);
            }

            // IF == 0

            else
            {
                Console.WriteLine("Number {0} equals 0", evaluatedNumber);
            }

            // Console.WriteLine("User input was: string: {0} : integer: {1}", userInput , evaluatedNumber);
            // Console.WriteLine("User input was: " + userInput);

            // Wait for user input

            Console.ReadKey();

        }
    }
}
