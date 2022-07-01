using System;

namespace Prime_Number
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
                    Console.Write("Enter number: ");
                    string First = Console.ReadLine();

                    if (int.TryParse(First, out int a))
                    {
                        int number = int.Parse(First);
                        int i = 2;
                        int b = (int)number;

                        while (number > 0 | number <= 0)
                        {
                            if (number % i == 0)
                            {
                                Console.WriteLine("\n" + number + " Not a Prime Number");
                            }
                            else if (number % b == 0)
                            {
                                Console.Write("\n" + number + " Is a Prime Number");
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
