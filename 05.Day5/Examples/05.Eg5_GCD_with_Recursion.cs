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
        static int FindGcd(int a, int b)
        {
            // Everything divides 0
            if (a == 0) 
                return b;

            if (b == 0)
                return a;

            // Base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return FindGcd(a - b, b);


            return FindGcd(a, b - a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindGcd(98,56));
            Console.WriteLine(FindGcd(0,56));
            Console.WriteLine(FindGcd(98,0));
            Console.WriteLine(FindGcd(98,98));
            Console.WriteLine(FindGcd(25,15));


            Console.ReadLine();
        }
    }
}
