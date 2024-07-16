// Write a C# Program to reverse the words in the given string 

//   Input :   Welcome to C#
//   Output :  C# to Welcome

//   Input :  I love to reading books
//   Output:  books reading to love I

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp13
{
    class Program
    {
        static string StringReverseWords(string inputStr)
        {
            string[] strArray = inputStr.Split(' ');
            Array.Reverse(strArray);
            string result = String.Join(" ", strArray);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message: ");
            string input = Console.ReadLine();
            string output = StringReverseWords(input);

            Console.WriteLine("Input : " + input);
            Console.WriteLine("Output : " + output);

            Console.ReadLine();
        }
    }
}
