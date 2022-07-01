using System;

public class FourCopyString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string User = string.Empty;

            do
            {
                bool incorrect = true;
                while (incorrect)
                {
                    Console.Write("\nEnter a Word= ");
                    string UserChoice = Console.ReadLine();

                    if (int.TryParse(UserChoice, out int a))
                    {

                        String Choice = UserChoice;
                        int i = UserChoice.Length;


                        while (i > 0)
                        {
                            if (i >= 2)
                            {
                                string Result = Choice.Substring(0, 2);
                                Console.WriteLine("\nResult= " + Result + Result + Result + Result);
                            }
                            else
                            {
                                string Result1 = Choice.Substring(0, 1);
                                Console.WriteLine("\nResult= " + Result1);
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

                    User = Console.ReadLine().ToUpper();

                    if (User != "YES" && User != "NO")
                    {
                        Console.WriteLine("\nInvalid choice, please say Yes or No");
                    }

                } while (User != "YES" && User != "NO");

                Console.Clear();

            } while (User == "YES");

            Console.ReadLine();
        }
    }
}
