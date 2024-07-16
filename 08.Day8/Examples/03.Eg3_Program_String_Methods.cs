using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{ 
    class Employee
    {
        public string Name { get; set; }
        public string Job{ get; set; }
        public int Deptno { get; set; }

        public Employee()
        {
            Name = "Smith";
            Job = "Sales Head";
            Deptno = 20;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // string is a keyword which is act as a alias of String Class
            string message1 = "Hello World";
            String message2 = "Welcome to C#";

            string str = String.Empty;  // Create Empty String

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message1[0]);
            Console.WriteLine(message1[message1.Length - 1]);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(message1.ToUpper());
            Console.WriteLine(message1.ToLower());
            Console.WriteLine("-------------------------------------");

            
            string s1 = "       ABC TECH          ";
            Console.WriteLine("With spaces : {0}", s1.Length);

            string s2 = s1.TrimStart();
            Console.WriteLine("After trim start : {0}", s2.Length);

            string s3 = s1.TrimEnd();
            Console.WriteLine("After trim End : {0}", s3.Length);

            string s4 = s1.Trim();
            Console.WriteLine("After trim : {0}", s4.Length);
            Console.WriteLine("-------------------------------------");


            string skillsStr = "ASP.NET,VB.NET,C#.NET";
            string[] strArray = skillsStr.Split(',');
            for (int i = 0; i < strArray.Length; i++) 
            {
             
                Console.WriteLine("{0}.{1}", i+1, strArray[i]);
            }
            Console.WriteLine("-------------------------------------");

            bool flag = message2.Contains("C#");
            Console.WriteLine("Contains : {0}", flag);


            int n = message1.IndexOf("llo");
            Console.WriteLine("IndexOf : {0}", n);

            n = message1.LastIndexOf('l');
            Console.WriteLine("LastIndexOf : {0}", n);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Substring : {0}", message2.Substring(3));
            Console.WriteLine("Substring : {0}", message2.Substring(3, 4));
            Console.WriteLine("-------------------------------------");

            flag = message1.StartsWith("Welcome");
            Console.WriteLine("Starts With : {0}", flag);
            Console.WriteLine("-------------------------------------");

            Employee employee = new Employee();


            string formatStr = string.Format("Mr./Mrs. {0} is working as {1} under Deptartment : {2}", employee.Name, employee.Job, employee.Deptno);

            Console.WriteLine(formatStr);

            Console.ReadLine();
        }
    }
}
