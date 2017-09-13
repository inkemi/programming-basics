using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Give N: ");
            string userInput1;
            userInput1 = Console.ReadLine();

            int n;
            int.TryParse(userInput1, out n);

            if (n < 0)
            {
                Console.WriteLine("N is {0} and undefined", n);
            }
            else if (n == 0)
            {
                Console.WriteLine("N is {0} and result is 0", n);
            }
            else if (n > 0)
            {
                int result;
                result = 1;
                int result2;
                result2 = 1;
                int i;
                i = 1;
                for (i = 1; i <= n; i++)
                {
                    result = result * i;
                    Console.WriteLine("{0} * {1} = {2}",result2, i, result);
                    result2 = result;
                }
                Console.WriteLine("N is {0} and result is {1}", n, result);
            }
            else
            {
                Console.WriteLine("N is {0} and it is something wrong with it.", n);
            }

            Console.ReadKey();
        }
    }
}
