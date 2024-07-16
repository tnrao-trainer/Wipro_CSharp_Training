using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    static class TimeUtil
    {
        public static void PrintTime()
        {
           // Console.WriteLine(DateTime.Now.ToString("t"));    // HH:MM
            Console.WriteLine(DateTime.Now.ToString("T"));    // HH:MM:SS
        }
        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Now.ToString("d"));
        }
        public static void PrintDateAndTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            TimeUtil.PrintTime();
            TimeUtil.PrintDate();
            TimeUtil.PrintDateAndTime();

           //   TimeUtil obj = new TimeUtil(); 
           //  Error :  Cannot create instance of the static class 


            Console.ReadLine();
        }
    }
}
