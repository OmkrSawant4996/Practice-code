using System;

namespace Integers_have_same_last_digit__True_or_False_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                Console.Write("Enter a Number A= ");
                int NumberA;
                if (!int.TryParse(Console.ReadLine(), out NumberA))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.Write("Enter a Number B= ");
                int NumberB;
                if (!int.TryParse(Console.ReadLine(), out NumberB))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                if ((NumberA % 10) == (NumberB % 10))
                {
                    Console.WriteLine("\nInput value is true");
                }
                else
                {
                    Console.WriteLine("\nInput value is false");
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
