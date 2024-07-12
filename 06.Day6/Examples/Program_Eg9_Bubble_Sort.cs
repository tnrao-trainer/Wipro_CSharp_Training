using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = false;
            var n = arr.Length;
            int tempVar = 0;

            for (int i = 0; i < n - 1; i++)
            {
                flag = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tempVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempVar;
                        flag = true;
                    }
                }
                  
                if (flag == false)
                {
                    break;
                }                   
            }




            //Sorted array
            foreach (int num in arr)
            {
                Console.Write("{0}  ", num);
            }
            Console.Read();
        }
    }
}