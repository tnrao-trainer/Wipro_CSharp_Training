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

            int[] arr = { 10, 20, 30, 40, 50};

            Console.WriteLine("Size of the array : " +  arr.Length);

            // Index based
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            // Item based 
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
