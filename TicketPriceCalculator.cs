using System;

namespace DCIT318Assignment1
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.WriteLine("=== Ticket Price Calculator ===");

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Input validation
            while (!int.TryParse(input, out age) || age < 0 || age > 120)
            {
                Console.Write("Invalid input. Please enter a valid age (0–120): ");
                input = Console.ReadLine();
            }

            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
    }
}
