using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class OverloadTest
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Integer Overloaded Method");
            Console.WriteLine(x + y);
        }
        public void Add(string x, string y)
        {
            Console.WriteLine("String Overloaded Method");
            Console.WriteLine(x + y);
        }
        public void Add(double x, double y)
        {
            Console.WriteLine("Double Overloaded Method");
            Console.WriteLine(x + y);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            OverloadTest obj = new OverloadTest();
            obj.Add(10, 20);
            obj.Add("Ravi", "Kumar");
            obj.Add(12.23, 15.45);


            Console.ReadLine();
        }
    }
}
