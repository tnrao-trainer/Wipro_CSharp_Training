using System;

namespace ConsoleApp13
{
    internal class Program
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
            int[] arr = new int[10] { 56, 11, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;
            Console.WriteLine("Selection sort");

            Console.WriteLine("Initial array is: ");
            PrintArray(arr);
            Console.WriteLine("------------------------------");

            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;

               // Console.Write("Iteration-{0} : ", i + 1);
               // PrintArray(arr);
            }


            Console.WriteLine("------------------------------");
            Console.WriteLine("Sorted Array");
            PrintArray(arr);

            Console.ReadLine();
        }
    }
}
