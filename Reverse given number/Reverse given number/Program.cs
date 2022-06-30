using System;

namespace Reverse_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                bool incorrect = true;
                while (incorrect)
                {
                    Console.Write("Please Enter a Number = ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int a))
                    {
                        int number = int.Parse(input);
                        int sum = 0;
                        int reminder = 0;

                        while (number > 0)
                        {
                            while (number > 0)
                            {
                                reminder = number % 10;
                                sum = (sum * 10) + reminder;
                                number = number / 10;
                            }
                            Console.WriteLine("Reverse Number: " + sum);
                        }
                        incorrect = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option\n");
                        incorrect = true;
                    }
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
