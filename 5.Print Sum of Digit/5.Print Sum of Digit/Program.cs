using System;

namespace _5.Print_Sum_of_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = "";
            do
            {
                bool Value = true;
                while (Value)
                {
                    Console.Write("Enter any number: ");
                    string Input = Console.ReadLine();

                    if (int.TryParse(Input, out int a))
                    {
                        int sum = 0;
                        int reminder = 0;
                        int Number = int.Parse(Input);

                        while (Number > 0 | Number < 0)
                        {
                            reminder = Number % 10;
                            Number = Number / 10;
                            sum = sum + reminder;
                        }
                        Console.WriteLine("\nSum of digit= " + sum);
                        Value = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input...!\n");
                        Value = true;
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
