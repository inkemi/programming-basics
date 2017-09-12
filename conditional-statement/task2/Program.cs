using System;

namespace task2
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

            int modulo = evaluatedNumber / 2;

            // If userInput is 0

            if (evaluatedNumber == 0)
            {
                Console.WriteLine("Number {0} is even", evaluatedNumber);

            }

            // If modulo = 0

            else if (modulo == 0)
            {
                Console.WriteLine("Number {0} is even", evaluatedNumber);

            }

            // If modulo > or > 0

            else
            {
                Console.WriteLine("Number {0} is odd", evaluatedNumber);

            }

            // Wait for user input

            Console.ReadKey();
        }
    }
}
