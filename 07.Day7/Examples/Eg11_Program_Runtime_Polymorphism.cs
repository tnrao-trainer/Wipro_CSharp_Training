using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Person
    {
        public virtual void Print()
        {
            Console.WriteLine("Person details from parent class.");
        }
    }
    class Employee : Person
    { 
        public override void Print()
        {
            Console.WriteLine("Employee details from child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;

            p1 = new Person();
            p1.Print();

            p1 = new Employee();
            p1.Print();
            

            Console.ReadLine();
        }
    }
}
