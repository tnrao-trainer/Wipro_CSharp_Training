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

            Console.WriteLine("Enter element to search : ");
            int n = int.Parse(Console.ReadLine());  

            int position = Array.IndexOf(arr, n);

            if (position == -1)
            {
                Console.WriteLine("Element does not exists in the array");
            }
            else
            {
                Console.WriteLine("Yes. Element exists in the array");
            }


            Console.ReadLine();
        }
    }
}
