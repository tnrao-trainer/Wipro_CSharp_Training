//  Program to perform dynamic operations using List<T>

using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{

    class Program
    {
        // User defined method to print List elements
        static void PrintList(List<string> list)
        {
            foreach (string str in list)
            {
                Console.Write("  {0}", str);
            }
            Console.WriteLine("\n-----------------------------------------------------");
        }
        static void Main(string[] args)
        {
            List<string> csList = new List<string>();
            csList.Add("JAVA");
            csList.Add("ASP.NET");
            csList.Add("SQL SERVER");
            csList.Add("VB.NET");
            csList.Add("C#.NET");

            Console.WriteLine("Actual Items");
            PrintList(csList);

            csList.Insert(0, "SharePoint");
            Console.WriteLine("After Insert");
            PrintList(csList);

            csList.Remove("VB.NET");
            Console.WriteLine("After Remove");
            PrintList(csList);

            csList.RemoveAt(1);
            Console.WriteLine("After RemoveAt");
            PrintList(csList);

            csList.Clear();
            Console.WriteLine("After Clear");
            PrintList(csList);

            Console.ReadLine();
        }

        
    }
}
