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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Enter number of lines : ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('\u2764' + "  ");
                }
                Console.WriteLine();
            }

            

            for (int i = n-1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('\u2764' + "  ");
                }  
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
