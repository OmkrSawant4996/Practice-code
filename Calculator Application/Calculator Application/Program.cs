using System;

namespace Calculator_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = string.Empty;

            do
            {
                bool incorrect = true;
                while (incorrect)
                {
                    Console.WriteLine("Calculator ");
                    Console.WriteLine("\nDo you want to \n1. Add\n2. Substract\n3. Multiply\n4. Divide");
                    Console.Write("\nEnter choice (1:4)= ");
                    string UserChoice = Console.ReadLine();

                    if (int.TryParse(UserChoice, out int a))
                    {
                        Console.Write("\nA: ");
                        string Input1 = Console.ReadLine();

                        Console.Write("\nB: ");
                        string Input2 = Console.ReadLine();

                        int Choice = int.Parse(UserChoice);
                        int number1 = int.Parse(Input1);
                        int number2 = int.Parse(Input2);
                        while (number1 >= 0 | number1 <= 0 | number2 >= 0 | number1 >= 0)
                        {
                            if (Choice == 1)
                            {
                                Console.WriteLine("\nA+B= " + (number1 + number2));
                            }
                            else if (Choice == 2)
                            {
                                Console.WriteLine("\nA-B= " + (number1 - number2));
                            }
                            else if (Choice == 3)
                            {
                                Console.WriteLine("\nAxB= " + (number1 * number2));
                            }
                            else if (Choice == 4)
                            {
                                Console.WriteLine("\nA/B= " + (number1 / number2));
                            }
                            else if (Choice > 4)
                            {
                                Console.WriteLine("Invalid input....!");
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

                    Input = Console.ReadLine().ToUpper();

                    if (Input != "YES" && Input != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }

                } while (Input != "YES" && Input != "NO");

                Console.Clear();

            } while (Input == "YES");

            Console.ReadLine();
        }

    }
}
