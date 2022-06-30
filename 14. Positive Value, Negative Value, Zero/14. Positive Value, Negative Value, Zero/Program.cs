using System;

namespace _14.Positive_Value__Negative_Value__Zero
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
                    Console.WriteLine("Enter any Number: ");
                    string Input = Console.ReadLine();

                    if (int.TryParse(Input, out int a))
                    {
                        int number = int.Parse(Input);
                        if (number > 0)
                        {
                            Console.WriteLine(number + " is a positive number");
                        }
                        else if (number < 0)
                        {
                            Console.WriteLine(number + " is not a negative number");
                        }
                        else
                        {
                            Console.WriteLine(number + " is a not a positive and negative number");
                        }
                        incorrect = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input...!\n");
                        incorrect = true;
                    }
                }
                do
                {
                    Console.WriteLine("\nDo you want to check another grade - YES or NO?");

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
