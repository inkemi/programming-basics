using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter 3 number: ");

            // Read user input
            string userInput;
            int x;
            int y;
            int z;
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();



            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            // IF z is smallest

            if (x > y) && (y > z)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", z, y, x);
            }

            if else (y > x) && (x > z)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", y, x, z);
            }

            // IF y is smallest

            if else (x > z) && (z > y)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", z, y, x);
            }


            if (z > x) && (x > y)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", y, x, z);
            }

            // IF x is smallest

            if (z > y) && (y > x)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", x, y, x);
            }


            if (y > z) && (z > x)
            {
                Console.WriteLine("Numbers are small to big: {0}, {1}, {2}", y, x, z);
            }
        }
    }
}
