// Program to validate the given IP Address

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static bool IsValidIPAddress(string ipAddress)
        {
            bool isValid = true;

            // 1. Four Parts
            // 2. Each part separate with.
            string[] ipParts = ipAddress.Split('.');

            if (ipParts.Length != 4)
            {
                isValid = false;
                return isValid;
            }


            foreach (string ipPart in ipParts)
            {
                int n = -1;

                //3.  Each part should be a number
                isValid = int.TryParse(ipPart, out n);

                if (isValid == false)
                {
                    break;
                }

                // 4.Each part value  should be in between  0 to 255
                if (n < 0 || n > 255)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;

        }

        static void Main(string[] args)
        {
            string str = "192.17.255.45";
            bool isValid = IsValidIPAddress(str);

            Console.WriteLine("IP Address : " + str);
            Console.WriteLine("Is Valid IP Address : " + isValid);

            Console.ReadLine();
        }
    }
}
