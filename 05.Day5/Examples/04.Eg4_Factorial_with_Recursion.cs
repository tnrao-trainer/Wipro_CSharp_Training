using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {

        static int  Factorial(int n)
        {
          //  Console.WriteLine(n);
          //  Console.ReadLine();

            if (n == 1)
                return 1;
            else 
                return n * Factorial(n - 1);
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine( Factorial(5));
           

            Console.ReadLine();           
        }
    }
}
