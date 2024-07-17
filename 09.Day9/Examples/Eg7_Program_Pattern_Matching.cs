using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleApp2
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int len = 2*n - 1;
            int row = 0, col = 0;
            int x;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    row = (i > n - 1) ? len - 1 - i : i;
                    col = (j > n - 1) ? len - 1 - j : j;
                    x =    (row < col) ? row: col; 
                    Console.Write("{0}  ", n - x);
                 
                    //   Console.Write("({0},{1},{2})   ", row, col, n - x);
                }
                Console.WriteLine();  
            }
            Console.ReadLine();
        }
    }
}