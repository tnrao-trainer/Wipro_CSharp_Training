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
        static void Main(string[] args)
        {
            int i;


            i = 1;
            while( i <= 20)
            {
                Console.Write("{0}  ",i);
                i++;
            }

            Console.WriteLine("\n-----------------------------");

            i = 0;
            do
            {
                Console.Write("{0}  ", i);
                i = i + 2;              
            } while (i <= 50);

            Console.WriteLine("\n-----------------------------");

            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0}  ", j);
            }

            Console.WriteLine("\n-----------------------------");

            // 50  45  40 35 30 .............  5

            for (int j = 50; j >= 5; j = j-5)
            {
                Console.Write("{0}  ", j);
            }

            Console.ReadLine();
        }
    }
}
