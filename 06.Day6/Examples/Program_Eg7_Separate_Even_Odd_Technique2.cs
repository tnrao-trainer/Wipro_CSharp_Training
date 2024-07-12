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
        
        static int GetEvenCount(int[] arr)
        {
            int count = 0;

            foreach (int item in arr)
            {
                if(item % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int GetOddCount(int[] arr)
        {
            int count = 0;

            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 55,10,15,18,26,14,63, 11 };

            int evenCount = GetEvenCount(arr);
            int oddCount = GetOddCount(arr);

            int[] evenArray = new int[evenCount];
            int[] oddArray = new int[oddCount];

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
            PrintArray(evenArray);
            PrintArray(oddArray);  

            Console.ReadLine();
        }
    }
}
