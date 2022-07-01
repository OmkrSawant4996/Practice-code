using System;

namespace find_maximum_number_and_minimum_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do
            {
                bool incorrect = true;
                while (incorrect)
                {
                    Console.Write("Enter First Number: ");
                    string First = Console.ReadLine();

                    Console.Write("Enter Second Number: ");
                    string Second = Console.ReadLine();

                    if (int.TryParse(First, out int a) | int.TryParse(Second, out int b))
                    {
                        int number1 = int.Parse(First);
                        int number2 = int.Parse(Second);

                        while (number1 >= 0 | number1 < 0 | number2 >= 0 | number2 < 0)
                        {
                            if (number1 > number2)
                            {
                                Console.WriteLine("\nMaximum Number =" + number1);
                            }
                            else
                            {
                                Console.WriteLine("\nMinimum Number =" + number1);
                            }
                            if (number2 > number1)
                            {
                                Console.WriteLine("\nMaximum Number =" + number2);
                            }
                            else
                            {
                                Console.WriteLine("\nMinimum Number =" + number2);
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
