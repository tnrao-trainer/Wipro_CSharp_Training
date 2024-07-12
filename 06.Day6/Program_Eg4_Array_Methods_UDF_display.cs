using System;
using System.Runtime.Remoting.Services;


namespace ConsoleApp13
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] arr = { 55,10,15,18,26,14, 63, 11 };


            PrintArray(arr); 

            Array.Reverse(arr);
            PrintArray(arr);
            

            Array.Sort(arr);  
            Array.Reverse(arr);
            PrintArray(arr);

            Array.Clear(arr,0,arr.Length);
            PrintArray(arr);


             


            Console.ReadLine();
        }
    }
}
