using System;

namespace Find_the_largest_number
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
                    Console.Write("Please Enter First Number = ");
                    string Input1 = Console.ReadLine();

                    Console.Write("Please Enter Second Number = ");
                    string Input2 = Console.ReadLine();

                    Console.Write("Please Enter Third Number = ");
                    string Input3 = Console.ReadLine();

                    if ((int.TryParse(Input1, out int a)) | (int.TryParse(Input2, out int b)) | (int.TryParse(Input2, out int c)))
                    {
                        int number1 = int.Parse(Input1);
                        int number2 = int.Parse(Input2);
                        int number3 = int.Parse(Input3);
                        while ((number1 > 0 | number1 <= 0) & (number2 > 0 | number2 <= 0) & (number2 > 0 | number2 <= 0))
                        {
                            if (number1 > number2 && number1 > number3)
                            {
                                Console.WriteLine("\nThe Largest No is " + number1);
                            }
                            else if (number2 > number3 && number2 > number1)
                            {
                                Console.WriteLine("\nThe Largest No is " + number2);
                            }
                            else
                            {
                                Console.WriteLine("\nThe Largest No is " + number3);
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
