using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();

            Console.WriteLine(d);   //  01-01-0001

            d = DateTime.Now;
            Console.WriteLine(d);   //  09-07-2024

            //   DateTime(year, month, day)       
            d = new DateTime(2024, 7, 5);
            Console.WriteLine(d);   //  05-07-2024

            Console.WriteLine("Enter Joining date (dd/mm/yyyy) : ");
            d = DateTime.Parse(Console.ReadLine() );
            Console.WriteLine(d);

            // Formatting dates for display purpose
            //    d = new DateTime(2024, 1, 9);
            d = DateTime.Now;
            Console.WriteLine( d.ToString("yyyy-MM-dd") );
            Console.WriteLine( d.ToString("dd, MMMM, yyyy") );
            Console.WriteLine( d.ToString("ddd, MMMM, yyyy") );
            Console.WriteLine( d.ToString("dddd-dd, MMMM, yyyy") );
            Console.WriteLine( d.ToString("t") );
            Console.WriteLine( d.ToString("T") );


            Console.ReadLine();
        }
    }
}
