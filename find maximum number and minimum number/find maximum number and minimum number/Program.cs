using System;

namespace find_maximum_number_and_minimum_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("Enter First Number");
                int number1;
                if (!int.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.WriteLine("Enter Second Number");
                int number2;
                if (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                if (number1 > number2)
                {
                    Console.WriteLine("Maximum Number =" + number1);
                }
                else
                {
                    Console.WriteLine("Minimum Number =" + number1);
                }
                if (number2 > number1)
                {
                    Console.WriteLine("Maximum Number =" + number2);
                }
                else
                {
                    Console.WriteLine("Minimum Number =" + number2);
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
