using System;
 

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 55,10,15,18,26,14, 63, 11 };


            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();


            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();


            Array.Clear(arr,0,arr.Length);
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
