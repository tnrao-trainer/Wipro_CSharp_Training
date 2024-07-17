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
        static void Main(string[] args)
        {
           HashSet<string> csList = new HashSet<string>();
         //   List<string> csList = new List<string>();
            
            csList.Add("ASP.NET");            
            csList.Add("ASP.NET");            
            csList.Add("ASP.NET");            
            csList.Add("VB.NET");
            csList.Add("VB.NET");
            csList.Add("VB.NET");
            csList.Add("C#.NET");
            csList.Add("C#.NET");
            csList.Add("C#.NET");
     


            foreach (string item in csList)
            {
                Console.Write("  " + item);
            }


            Console.ReadLine();
        }
        
    }
}
