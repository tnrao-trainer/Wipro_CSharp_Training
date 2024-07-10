using Microsoft.SqlServer.Server;
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
            int empid = 546452;
            string ename = "Narasimha";
            string job = "Manager";

            Console.WriteLine("Employee Details :  " + empid + "," +  ename + "," +  job);

            Console.WriteLine("Employee Details :  {0},{1},{2}", empid, ename, job);

            string output = string.Format("Employee Details :  {0},{1},{2}", empid, ename, job);
            Console.WriteLine(output);


            Console.ReadLine();
        }
    }
}
