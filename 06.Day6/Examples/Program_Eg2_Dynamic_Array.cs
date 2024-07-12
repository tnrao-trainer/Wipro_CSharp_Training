using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks;

            Console.WriteLine("Enter no. of subjects :");
            int n = int.Parse(Console.ReadLine());  

            marks = new int[n]; // allocate the size for the array at runtime 


            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enters marks [Subject - {0}] : ", i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("---------------------------------");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(" " + marks[i]);
            }


            Console.ReadLine();
        }
    }
}
