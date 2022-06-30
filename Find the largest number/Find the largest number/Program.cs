using System;

namespace Find_the_largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("please Enter First Number");
                int number1;
                if (!int.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.WriteLine("Please Enter Second Number");
                int number2;
                if (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.WriteLine("Please Enter Three Number");
                int number3;
                if (!int.TryParse(Console.ReadLine(), out number3))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                if (number1 > number2 && number1 > number3)
                {
                    Console.WriteLine("The Largest No is " + number1);
                }
                else if (number2 > number3 && number2 > number1)
                {
                    Console.WriteLine("The Largest No is " + number2);
                }
                else
                {
                    Console.WriteLine("The Largest No is " + number3);
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
