using System;

namespace Admission_Elgibility_Criteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            string UserChoice = string.Empty;

            do
            {
                Console.Write("Marks in Maths= ");
                int Maths;
                if (!int.TryParse(Console.ReadLine(), out Maths))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.Write("Marks in Physics= ");
                int Physics;
                if (!int.TryParse(Console.ReadLine(), out Physics))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                Console.Write("Marks in Chemistry= ");
                int Chemistry;
                if (!int.TryParse(Console.ReadLine(), out Chemistry))
                {
                    Console.WriteLine("Invalid Input...!");
                    goto Start;
                }

                int Total1 = Maths + Physics + Chemistry;
                int Total2 = (Maths + Physics) | (Maths + Chemistry);

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
