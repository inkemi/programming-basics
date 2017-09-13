using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter 3 numbers: ");

            // Read user input
            string userInput1;
            string userInput2;
            string userInput3;

            Console.WriteLine("Give three numbers: ");

            Console.Write("Number 1: ");
            userInput1 = Console.ReadLine();

            Console.Write("Number 2: ");
            userInput2 = Console.ReadLine();

            Console.Write("Number 3: ");
            userInput3 = Console.ReadLine();

            // Evaluate user input

            int number1;
            int.TryParse(userInput1, out number1);

            int number2;
            int.TryParse(userInput2, out number2);

            int number3;
            int.TryParse(userInput3, out number3);

           

            // IF number1 is smallest

            if (number2 > number3 && number3 > number1)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number1, number3, number2);
            }

            else if (number3 > number2 && number2 > number1)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number1, number2, number3);
            }

            // IF number2 is smallest

            else if (number1 > number3 && number3 > number2)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number2, number3, number1);
            }


            else if (number3 > number1 && number1 > number2)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number2, number1, number3);
            }

            // IF number3 is smallest

            else if (number1 > number2 && number2 > number3)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number3, number2, number1);
            }


            else if (number2 > number1 && number1 > number3)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", number3, number1, number2);
            }

            else 
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine("Numbers are: {0}, {1}, {2}", number1, number2, number3);
            }

            Console.ReadKey();

        }
    }
}
