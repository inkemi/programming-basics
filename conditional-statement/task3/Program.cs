using System;

namespace task3
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

            int modulo = evaluatedNumber % 2;

            // If userInput is 0

            if (evaluatedNumber == 0)
            {
                Console.WriteLine("Number {0} equals even and 0", evaluatedNumber);

            }

            // If modulo = 0

            else if (modulo == 0 && evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is even and positive", evaluatedNumber);

            }


            else if (modulo == 0 && evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is even and negative", evaluatedNumber);

            }

            // If modulo > or > 0


            else if (modulo != 0 && evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is odd and positive", evaluatedNumber);

            }

            else
            {
                Console.WriteLine("Number {0} is odd and negative", evaluatedNumber);

            }

            // Wait for user input

            Console.ReadKey();
        }
    }
}
