using System;

namespace Fibonacci
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
                    Console.WriteLine("Enter any number: ");
                    string input = Console.ReadLine();

                    int F1 = 0;
                    int F2 = 1;
                    int F3 = 0;

                    if (int.TryParse(input, out int a))
                    {
                        int Number = int.Parse(input);

                        while (Number > 0 & Number < 50)
                        {
                            for (int i = 0; i < Number; i++)
                            {
                                F1 = F2;
                                F2 = F3;
                                F3 = F1 + F2;
                                Console.WriteLine(F3);
                            }
                            break;
                        }
                        incorrect = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
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
