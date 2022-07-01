using System;

namespace Tringle
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
                    Console.Write("Please Enter a Number = ");
                    string Usernumber = Console.ReadLine();

                    if (int.TryParse(Usernumber, out int a))
                    {
                        int number = int.Parse(Usernumber);

                        while (number > 0 & number < 10)
                        {
                            for (int i = 1; i <= number; i++)
                            {
                                for (int j = 1; j <= number - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i; k++)
                                {
                                    Console.Write(k + " ");
                                }
                                Console.WriteLine();
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
                    Console.WriteLine("Do you want to continue - YES or NO?");

                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }

                } while (UserChoice != "YES" && UserChoice != "NO");

                Console.Clear();

            } while (UserChoice == "YES");

            Console.ReadLine();
        }
    }
}
