using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double normal;
            normal = 16.00;
            double over65; 
            over65 = 0.50;
            double between715;
            between715 = 0.50;
            double ticket;
            double mbr; 
            mbr = 0.85;
            double soldier;
            soldier = 0.50;
            double student;
            student = 0.55;

            Console.Write("Your age: ");
            string userInput1;
            userInput1 = Console.ReadLine();

            int age;
            int.TryParse(userInput1, out age);

            bool mtkMember = false;

            if ( age < 7)
            {
                Console.WriteLine("Ticket: 0 EUR");
            }
            else if (age >= 7)
            {
                Console.Write("Are you member of MTK (Y/N): ");
                string userInput2;
                userInput2 = Console.ReadLine();
                if (userInput2.ToUpper().Equals("Y"))
                {
                    mtkMember = true;
                }
                else
                {
                    mtkMember = false;
                }
            }

            bool student1 = false;

            if (age >= 15 && age < 65)
            {
                Console.Write("Are you student (Y/N): ");
                string userInput3;
                userInput3 = Console.ReadLine();
                if (userInput3.ToUpper().Equals("Y"))
                {
                    student1 = true;
                }
                else
                {
                    student1 = false;
                }
            }

            bool soldier1 = false;

            if (age >= 17 && age < 32 && student1 == false)
            {
                Console.Write("Are you soldier (Y/N): ");
                string userInput4;
                userInput4 = Console.ReadLine();
                if (userInput4.ToUpper().Equals("Y"))
                {
                    soldier1 = true;
                }
                else
                {
                    soldier1 = false;
                }
            }

            if (age < 7)
            {
                Console.WriteLine("Welcome");
            }

            else if (mtkMember && age >= 65)
            {
                ticket = normal * over65 * mbr;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (age >= 65)
            {
                ticket = normal * over65;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (mtkMember && age < 15)
            {
                ticket = normal * between715 * mbr;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (age < 15)
            {
                ticket = normal * between715;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (mtkMember && student1)
            {
                ticket = normal * student * mbr;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (student1)
            {
                ticket = normal * student;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (mtkMember && soldier1)
            {
                ticket = normal * soldier * mbr;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (soldier1)
            {
                ticket = normal * soldier;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else if (mtkMember)
            {
                ticket = normal * mbr;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }
            else
            {
                ticket = normal;
                Console.WriteLine("Ticket: {0} EUR", ticket);
            }

            Console.ReadKey();
        }
    }
}
