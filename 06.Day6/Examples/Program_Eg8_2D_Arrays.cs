using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D - Array
            int[,] ar = new int[,]
            {
                { 1, 2, 3, 4 },
                { 4, 5, 6, 7 },
                { 7, 8, 9, 9 }
            };
            Console.WriteLine("Length : " + ar.Length);

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write("  " + ar[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Rank of the Array  : " + ar.Rank);


            Console.ReadLine();
        }
    }
}
