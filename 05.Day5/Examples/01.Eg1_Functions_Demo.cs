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
        static void Hello()
        {
            Console.WriteLine("Hi, Good Morning..!");
        }

        static void Greeting(string uname)
        {
            Console.WriteLine("Hi {0}, How are you?", uname);
        }

        static int Sum(int x, int y)
        {
            return x+y;
        }

        static string GetCurrentUserName()
        {
            return "Scott";
        }

        static void Main(string[] args)
        {         
            Hello();
            Greeting("Smith");

            int n = Sum(10,20);
            Console.WriteLine("Sum Result : " + n);

            string str = GetCurrentUserName();
            Console.WriteLine("GetCurrentUserName result : " +  str);

            Console.ReadLine();
        }
    }
}
