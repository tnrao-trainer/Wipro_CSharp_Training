// Write a C# program to separate even numbers and odd numbers into separate arrays from the give array

using System;


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
            int[] arr = { 55,10,15,18,26,14,63, 11 };


            int[] evenArray = new int[arr.Length];
            int[] oddArray = new int[arr.Length];

            int evenIndex = 0;
            int oddIndex = 0;

            foreach (int item in arr)
            {
                if(item % 2 == 0)
                {
                    evenArray[evenIndex] = item;
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = item;
                    oddIndex++;
                }
            }



            PrintArray(arr);
           
            for (int i = 0;i < evenIndex;i++)
            {
                Console.Write("{0}  ", evenArray[i]);
            }
         
            Console.WriteLine();


            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write("{0}  ", oddArray[i]);
            }

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
