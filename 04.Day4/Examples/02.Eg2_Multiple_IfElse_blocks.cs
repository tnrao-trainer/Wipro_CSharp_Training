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
        static void Main(string[] args)
        {
            const int SALES_DEPARTMENT = 10;
            const int ADMIN_DEPARTMENT = 20;
            const int ACCOUNTS_DEPARTMENT = 30;
            const int OPERATIONS_DEPARTMENT = 40;


            Console.WriteLine("Enter your deptno : ");
            int dno = int.Parse(Console.ReadLine());

            if (dno == SALES_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Sales department");
            }  
            else if (dno == ADMIN_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Admin department");
            }
            else if (dno == ACCOUNTS_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Accounts department");
            }
            else if (dno == OPERATIONS_DEPARTMENT)
            {
                Console.WriteLine("You are belongs to Operations department");
            }
            else
            {
                Console.WriteLine("Inavalid dept number");
            }


            Console.ReadLine();
        }
    }
}
