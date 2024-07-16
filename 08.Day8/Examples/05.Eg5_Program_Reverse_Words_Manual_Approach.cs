// Write a C# Program to reverse the words in the given string without using pre-defined methods. 

//   Input :   Welcome to C#
//   Output :  C# to Welcome

//   Input :  I love to reading books
//   Output:  books reading to love I

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static string StringReverse(string inputStr, int start, int end)
        {  
            char[] chars = inputStr.ToCharArray();
            char temp;

            while(start <= end)
            {
                temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }

            string result = new string(chars);
           // Console.WriteLine(result);
            return result;
        }

        static string StringReverseWords(string inputStr)
        {
            string result = "";
            char[] chars = inputStr.ToCharArray();

            int start = 0;
            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                 chars =  StringReverse(new String(chars), start, i-1).ToCharArray();
                 start = i + 1;
                }
            }

            // to reverse the last word
            chars = StringReverse(new String(chars), start, chars.Length-1).ToCharArray();

            result = new String(chars);

            // to reverse the complete sentence 
            result = StringReverse(result,0, result.Length-1);    

            return result;
        }
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter a message: ");
            //            string input = Console.ReadLine();
            string input = "Hello World";
            string output = StringReverseWords(input);

            Console.WriteLine("Input : " + input);
            Console.WriteLine("Output : " + output);

            Console.ReadLine();
        }
    }
}
