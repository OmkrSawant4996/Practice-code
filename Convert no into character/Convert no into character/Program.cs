using System;

namespace Convert_no_into_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                int number, sum = 0, remainder;
                Console.Write(" Enter your number: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine(" Input is invalid...!");
                    goto Start;
                }

                while (number >= 0)
                {
                    remainder = number % 10;
                    sum = (sum * 10) + remainder;
                    number = number / 10;
                }
                number = sum;
                while (number > 0)
                {
                    remainder = number % 10;
                    switch (remainder)
                    {
                        case 1:
                            Console.Write(" One ");
                            break;

                        case 2:
                            Console.Write(" Two ");
                            break;

                        case 3:
                            Console.Write(" Three ");
                            break;

                        case 4:
                            Console.Write(" Four ");
                            break;

                        case 5:
                            Console.Write(" Five ");
                            break;

                        case 6:
                            Console.Write(" Six ");
                            break;

                        case 7:
                            Console.Write(" Seven ");
                            break;

                        case 8:
                            Console.Write(" Eight ");
                            break;

                        case 9:
                            Console.Write(" Nine ");
                            break;

                        case 10:
                            Console.Write(" Zero ");
                            break;

                        default:
                            Console.WriteLine(" ");
                            break;
                    }
                    number = number / 10;

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
