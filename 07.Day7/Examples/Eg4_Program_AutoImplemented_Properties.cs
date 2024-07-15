using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Student
    {
        // Auto-Implemented Properties
        public int StudetnId { get; set; }
        public string StudentName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student studentObj = new Student();

            Console.WriteLine("Enter Student Id : ");
            studentObj.StudetnId = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Enter Student Name :");
            studentObj.StudentName = Console.ReadLine(); 

            Console.WriteLine("Student Name :  " + studentObj.StudentName);
            Console.WriteLine("Student Id :  " + studentObj.StudetnId);

            
            Console.ReadLine(); 
        }
    }
}
