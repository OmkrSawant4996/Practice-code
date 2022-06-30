using System;

namespace Replaceletterbyposition
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
                    Console.Write("Enter the word: ");
                    String Word = Console.ReadLine();

                    Console.Write("\nEnter the position of the letter you want to remove: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int a))
                    {
                        int Number = int.Parse(input);

                        while (Number > 0)
                        {
                            String Result = "";

                            Result = Word.Substring(0, Number) + Word.Substring(Number + 1);
                            Console.WriteLine("\nAlphabet removed and the out put is= " + Result);
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
