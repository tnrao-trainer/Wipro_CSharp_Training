

using System;
using System.Collections;
using System.Collections.Generic;
 

namespace ConsoleApp13
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add("Hello"); // Allowed, due it is weakly typed

            foreach(int item in arrayList)
            {
                Console.Write("  " + item);
            }

            int x = (int) arrayList[0];     //  Typecasting is required
            Console.WriteLine();


            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);   
            list.Add(30);
        //    list.Add("Hello");  // Error due it is strongly typed 
            
            foreach(int item in list)
            {
                Console.Write("  " + item);
            }

            int y = list[0];    // no need typecasting

            Console.ReadLine();
        }
    }
}