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
            int fact = 1;

            for(int i = 1; i <=n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine( Factorial(5));
            Console.WriteLine( Factorial(6));

            Console.ReadLine();           
        }
    }
}
