using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    static class DeptsConstants
    {
        public const int SALES_DEPARTMENT = 10;
        public const int ADMIN_DEPARTMENT = 20;
        public const int ACCOUNTS_DEPARTMENT = 30;
        public const int OPERATIONS_DEPARTMENT = 40; 
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your deptno : ");
            int dno = int.Parse(Console.ReadLine());  

            if(dno == DeptsConstants.SALES_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Sales department");
            }

            if (dno == DeptsConstants.ADMIN_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Admin department");
            }

            if (dno == DeptsConstants.ACCOUNTS_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Accounts department");
            }

            if (dno == DeptsConstants.OPERATIONS_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Oplerations department");
            }

            Console.ReadLine();
        }
    }
}
