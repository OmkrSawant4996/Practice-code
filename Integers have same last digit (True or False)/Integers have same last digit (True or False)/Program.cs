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
                bool incorrect = true;
                while (incorrect)
                {
                    Console.Write("Enter number A: ");
                    string First = Console.ReadLine();

                    Console.Write("Enter number B: ");
                    string Second = Console.ReadLine();

                    if (int.TryParse(First, out int a) | int.TryParse(Second, out int b))
                    {
                        int NumberA = int.Parse(First);
                        int NumberB = int.Parse(Second);

                        while (NumberA > 0 | NumberA <= 0 | NumberB > 0 | NumberB <= 0)
                        {
                            if ((NumberA % 10) == (NumberB % 10))
                            {
                                Console.WriteLine("\nInput value is true");
                            }
                            else
                            {
                                Console.WriteLine("\nInput value is false");
                            }
                            break;
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
