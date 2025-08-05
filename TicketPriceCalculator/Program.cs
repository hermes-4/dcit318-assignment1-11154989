using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Movie Ticket Price Calculator***");
            Console.Write("Please enter your age: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int age)) 
            {
                if (age < 0 || age > 100) 
                {
                    Console.WriteLine("Invalid input: Please enter a valid age between 0 and 100.");
                }
                else
                {
                    int ticketPrice = CalculateTicketPrice(age);
                    Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a valid age between 0 and 100.");
            }

        }

        static int CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7; 
            }
            else
            {
                return 10; 
            }
        }
    }
}
