using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static  bool IsValidUser(string userId, string password)
        {
            if (userId.Trim() == "admin" && password.Trim() == "admin123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int count = 1;

            while (count <= 3)
            {
                Console.WriteLine("Enter User Id : ");
                string userId = Console.ReadLine();

                Console.WriteLine("Enter Password : ");
                string password = Console.ReadLine();


                bool result = IsValidUser(userId, password);


                if (result)
                {
                    Console.WriteLine("Welcome to {0}", userId);
                    break;
                }                    
                else
                {
                  
                    Console.WriteLine("Invalid User Id or Password. Wrong Attempts Count : " + count );
                    
                    if(count == 3)
                        Console.WriteLine("Your account is locked.");
                    
                    count++;
                }
            }

            Console.ReadLine();
        }
    }
}
