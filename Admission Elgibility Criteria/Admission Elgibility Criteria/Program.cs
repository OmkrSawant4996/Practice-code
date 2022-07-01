using System;

namespace Admission_Elgibility_Criteria
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
                    Console.Write("Marks in Maths: ");
                    string Input1 = Console.ReadLine();

                    Console.Write("Marks in Physics: ");
                    string Input2 = Console.ReadLine();

                    Console.Write("Marks in Chemistry: ");
                    string Input3 = Console.ReadLine();

                    if (int.TryParse(Input1, out int a) | int.TryParse(Input2, out int b) | int.TryParse(Input3, out int c))
                    {
                        int Maths = int.Parse(Input1);
                        int Physics = int.Parse(Input2);
                        int Chemistry = int.Parse(Input3);

                        int Total1 = Maths + Physics + Chemistry;
                        int Total2 = (Maths + Physics) | (Maths + Chemistry);

                        while (Total1 > 0 | Total2 > 0)
                        {
                            if (Maths > 100 || Physics > 100 || Chemistry > 100)
                            {
                                Console.WriteLine("Invalid Input...!");
                            }

                            else if (Total2 >= 140)
                            {
                                Console.WriteLine("\nThe Candidate is Eligible for Admission");
                            }
                            else if (Total1 >= 180)
                            {
                                Console.WriteLine("\nThe Candidate is Eligible for Admission");
                            }
                            else if (Total2 < 140 && Total1 <= 180)
                            {
                                Console.WriteLine("\nThe Candidate is Not Eligible for Admission");
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
