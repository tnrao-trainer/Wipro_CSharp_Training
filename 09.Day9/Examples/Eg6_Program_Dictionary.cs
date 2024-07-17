
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleApp2
{
    class Program
    {
        static Dictionary<string, List<String>> customerList;


        static void ShowCustomersByPlan(string planName)
        {
            if (customerList.ContainsKey(planName))
            {
                List<String> customerNames = customerList[planName];

                Console.WriteLine("Customers in {0} plan : ", planName);
                foreach (String customerName in customerNames)
                {
                    Console.Write("  " + customerName);
                }
            }
            else
            {
                Console.WriteLine("You have ented wrong plan or plan does not exists");
            }
        }


        static void AddCustomer(string planName, string customerName)
        {

        }


        static void Main(string[] args)
        { 
            customerList = new Dictionary<string, List<String>>() 
            {
                                    { "Gold", new List<string>(){ "Tom","Harry"} },
                                    { "Silver",new List<string>(){ "Sam","Peter"} },
                                    { "Paltinum",new List<string>(){ "Kim","Robert"} } 
            };


            Console.WriteLine("Enter the plan : ");
            string plan = Console.ReadLine();

            ShowCustomersByPlan(plan);

            // Code to read plan and customer name from user
            // Add to the customerList 
            

            Console.ReadLine();
        }
    }
}