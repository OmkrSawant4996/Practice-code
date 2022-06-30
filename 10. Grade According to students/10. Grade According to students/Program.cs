using System;

namespace _10.Grade_According_to_students
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
                    Console.WriteLine("Enter any Score: ");
                    string Input = Console.ReadLine();

                    if (int.TryParse(Input, out int a))
                    {
                        int Score = int.Parse(Input);

                        if (Score <= 49)
                        {
                            Console.WriteLine("Grade F");
                        }
                        else if (Score >= 50 && Score <= 59)
                        {
                            Console.WriteLine("Grade D");
                        }
                        else if (Score >= 60 && Score <= 69)
                        {
                            Console.WriteLine("Grade C");
                        }
                        else if (Score >= 70 && Score <= 79)
                        {
                            Console.WriteLine("Grade B");
                        }
                        else if (Score <= 100)
                        {
                            Console.WriteLine("Grade A");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input,score is between 0 to 100 ");
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
