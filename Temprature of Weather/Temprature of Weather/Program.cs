using System;

namespace Temprature_of_Weather
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
                    Console.WriteLine("Enter the Temprature: ");
                    string Input = Console.ReadLine();

                    if (int.TryParse(Input, out int a))
                    {
                        int Temprature = int.Parse(Input);

                        while (Temprature > 0 & Temprature < 0 & Temprature < 200)
                        {
                            if (Temprature < 0)
                            {
                                Console.WriteLine("Freezing Weather");
                            }
                            else if (Temprature <= 10)
                            {
                                Console.WriteLine("Very Cold Weather");
                            }
                            else if (Temprature <= 20)
                            {
                                Console.WriteLine("Cold Weather");
                            }
                            else if (Temprature <= 30)
                            {
                                Console.WriteLine("Normal Temperature");
                            }
                            else if (Temprature <= 40)
                            {
                                Console.WriteLine("Its Hot");
                            }
                            else
                            {
                                Console.WriteLine("Its Very Hot");
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
