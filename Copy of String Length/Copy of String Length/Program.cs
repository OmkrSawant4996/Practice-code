using System;

public class FourCopyString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("Enter a word= ");
                string Word = Console.ReadLine();

                int i = Word.Length;

                if (i > 2)
                {
                    string Result = Word.Substring(0, 2);
                    Console.WriteLine("\nResult= " + Result + Result + Result + Result);
                }
                else
                {
                    string Result1 = Word.Substring(0, 1);
                    Console.WriteLine("\nResult= " + Result1);
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
