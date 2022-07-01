using System;

namespace Electrycity_Bill
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
                    Console.Write("Customer Id= ");
                    string UserId = Console.ReadLine();

                    Console.Write("Customer Name= ");
                    string UserName = Console.ReadLine();

                    Console.Write("Unit consume by the customer= ");
                    string unit = Console.ReadLine();

                    if (int.TryParse(UserId, out int a))
                    {
                        int Unit = int.Parse(unit);

                        while (Unit >= 0)
                        {
                            if (Unit == 0 || Unit <= 50)
                            {
                                Console.WriteLine("\nCustomer id no: {0}\nCustomer Name: {1}\nTotal unit consume:{2}\nNet amount paid by the customer: 100", UserId, UserName, Unit);
                            }
                            else if (Unit <= 199)
                            {
                                Console.WriteLine("\nCustomer id no: {0}\nCustomer Name: {1}\nTotal unit consume:{2}\nAmount Charges @Rs.1.20 per unit: {3}\nNet amount Paid by the customer: {4}", UserId, UserName, Unit, Unit * 1.20, Unit * 1.20);
                            }
                            else if (Unit < 400)
                            {
                                Console.WriteLine("\nCustomer id no: {0}\nCustomer Name: {1}\nTotal unit consume:{2}\nAmount Charges @Rs.1.50 per unit: {3}\nNet amount Paid by the customer: {4}", UserId, UserName, Unit, Unit * 1.50, Unit * 1.50);
                            }
                            else if (Unit < 600)
                            {
                                Console.WriteLine("\nCustomer id no: {0}\nCustomer Name: {1}\nTotal unit consume:{2}\nAmount Charges @Rs.1.80 per unit: {3}\nSurcharge Amount:{4} \nNet amount Paid by the customer: {5}", UserId, UserName, Unit, Unit * 1.80, Unit * 0.15, (Unit * 1.80) + (Unit * 0.15));
                            }
                            else if (Unit >= 600)
                            {
                                Console.WriteLine("\nCustomer id no: {0}\nCustomer Name: {1}\nTotal unit consume:{2}\nAmount Charges @Rs.2.00 per unit: {3}\nSurcharge Amount: {4}\nNet amount Paid by the customer: {5}", UserId, UserName, Unit, Unit * 2.00, Unit * 0.15, (Unit * 2.00) + (Unit * 0.15));
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
