 using System;
namespace ObjectOrientedProgram
{
    class Employee
    {
       public int EmployeeId { get; set; }
       public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
			
            emp.EmployeeId = 123;
            emp.EmployeeName = "Sai Kumar";
            emp.EmployeeEmail = "saikumar@gmail.com";
			
            Console.WriteLine(emp.EmployeeId);
            Console.WriteLine(emp.EmployeeName);
            Console.WriteLine(emp.EmployeeEmail);
			
            Console.ReadLine();
 
        }
    }

 
 
}