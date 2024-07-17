using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {   
        static void Main(string[] args)
        {
           List<Employee> empList = new List<Employee>();

            //Employee emp = new Employee();
            //emp.Id = 10256;
            //emp.Name = "Scott";
            //emp.Email = "scott@gmail.com";

            // Object Initializer
            Employee emp1 = new Employee() { Id = 10256, Name="Scott", Email="scott@gmail.com"  };
            Employee emp2 = new Employee() { Id = 24656, Name = "Smith", Email = "smith@gmail.com" };
            Employee emp3 = new Employee() { Id = 34565, Name = "Sandy", Email = "sandy@gmail.com" };

            empList.Add(emp1);            
            empList.Add(emp2);
            empList.Add(emp3);


            foreach (Employee item in empList)
            {
                Console.WriteLine("{0},{1},{2}", item.Id, item.Name, item.Email);
            }

            Console.ReadLine();
        }
        
    }
}
