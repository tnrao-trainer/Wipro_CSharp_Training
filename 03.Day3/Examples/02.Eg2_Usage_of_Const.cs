using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    static class Constants
    {
        public const int PIZZA_PRICE = 300;
        public const int PUFF_PRICE = 50;
        public const int PEPSI_PRICE = 130;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                // Constants.PEPSI_PRICE = 4564;    // error

                Console.WriteLine("Welcome to AMB Mall Multiplex Cafeteria!");

                // Read number of items
                Console.Write("Enter the number of pizzas: ");
                int numPizzas = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of puffs: ");
                int numPuffs = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of pepsis: ");
                int numPepsis = int.Parse(Console.ReadLine());

                // Calculate total costs
                int totalPizzaCost = numPizzas * Constants.PIZZA_PRICE;
                int totalPuffCost = numPuffs * Constants.PUFF_PRICE;
                int totalPepsiCost = numPepsis * Constants.PEPSI_PRICE;
                int grandTotal = totalPizzaCost + totalPuffCost + totalPepsiCost;

                // Calculate GST and CESS
                double gstAmount = grandTotal * 0.09;
                double cessAmount = grandTotal * 0.09;

                // Display bill details
                Console.WriteLine("\nBill Details:");
                Console.WriteLine($"Total cost of pizzas: Rs.{totalPizzaCost}");
                Console.WriteLine($"Total cost of puffs: Rs.{totalPuffCost}");
                Console.WriteLine($"Total cost of pepsis: Rs.{totalPepsiCost}");
                Console.WriteLine($"Grand Total: Rs.{grandTotal}");
                Console.WriteLine($"GST Amount (9%): Rs.{gstAmount:F2}");
                Console.WriteLine($"CESS Amount (9%): Rs.{cessAmount:F2}");
                Console.WriteLine($"Final Total: Rs.{grandTotal + gstAmount + cessAmount:F2}");
 


                Console.ReadLine();
        }
    }
}
