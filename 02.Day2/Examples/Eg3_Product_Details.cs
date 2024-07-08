// C# Program to read and print product details 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName;
            int qty;
            double unitPrice;
            bool isDiscounted;

            Console.WriteLine("Enter Product Name :  ");
            productName = Console.ReadLine();

            Console.WriteLine("Enter Quantity to Order :  ");
            qty = int.Parse(  Console.ReadLine() );

            Console.WriteLine("Enter Unit Price :  ");
            unitPrice = double.Parse( Console.ReadLine() );

            Console.WriteLine("Is discount applied :  ");
            isDiscounted = bool.Parse(Console.ReadLine());


            double totalAmount = unitPrice * qty;

            Console.WriteLine();
            Console.WriteLine("------------ Product Details ----------------------");
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Quatity to Order : " + qty);
            Console.WriteLine("Unit Price : " + unitPrice);
            Console.WriteLine("Discount Applied : " + isDiscounted);
            Console.WriteLine("Total Amount : " + totalAmount);


            Console.ReadLine();
        }
    }
}
