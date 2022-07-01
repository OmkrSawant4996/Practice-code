using System;

namespace Print_Alphabet_Triangle
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
                    string Job = Console.ReadLine();

                    char character = 'A';

                    if (int.TryParse(Job, out int a))
                    {
                        int Number = int.Parse(Job);

                        while (Number > 0 & Number <= 26)
                        {
                            for (int i = 0; i < Number; i++)
                            {
                                for (int j = 0; j <= Number - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 0; k <= i; k++)
                                {
                                    Console.Write(character++);
                                }
                                character--;

                                for (int c = i - 1; c >= 0; c--)
                                {
                                    Console.Write(--character);
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
                        Console.WriteLine("\nInvalid Option");
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
