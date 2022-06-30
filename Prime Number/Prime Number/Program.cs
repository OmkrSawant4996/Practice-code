using System;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                Console.Write("Enter Number = ");
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                int i = 2;
                int a = (int)number;

                if (number % i == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                }
                else if (number % a == 0)
                {
                    Console.Write("It Is Prime Number");
                }

                do
                {
                    Console.WriteLine("\nDo you want to continue - YES or NO?");

                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("\nInvalid choice, please say Yes or No");
                    }

                } while (UserChoice != "YES" && UserChoice != "NO");

                Console.Clear();

            } while (UserChoice == "YES");

            Console.ReadLine();
        }
    }
}
