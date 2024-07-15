using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Person
    {
        // Fields
        private int _age;
        private string _name;

        // Properties   
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    class Employee : Person
    {
        private int _id;
        private string _job;

        // Constructor
        public Employee(int n)
        {
            _id = n;
        }
        // Read-only
        public int EmployeeId
        {
            get { return _id; }
        }

        public string Designation
        {
            get { return _job; }
            set { _job = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(58569);

            e1.Age = 25;
            e1.Name = "Ritesh";
            e1.Designation = "Project Manager";

            Console.WriteLine("Employee Id : {0}, Name  : {1}, Age : {2}, Job : {3}", e1.EmployeeId, e1.Name, e1.Age, e1.Designation);

            Console.ReadLine();
        }
    }
}
