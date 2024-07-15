using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp13
{
    class Student
    { 
        // Auto-Implemented Properties
        public int StudetnId { get; set; }
        public string StudentName { get; set; }

        public Student()
        {
                StudetnId = 0; 
                StudentName = ""; 
        }
        public Student(int sid)
        {
            StudetnId = sid;
        }
        public Student(int sid, string name)
        {
            StudetnId = sid;
            StudentName = name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student studentObj1 = new Student();
            Student studentObj2 = new Student(9988);
            Student studentObj3 = new Student(7766, "Scott");

            Console.WriteLine("Student Details :  Id :{0}, Name : {1}", studentObj1.StudetnId, studentObj1.StudentName);

            Console.WriteLine("Student Details :  Id :{0}, Name : {1}", studentObj2.StudetnId, studentObj2.StudentName);

            Console.WriteLine("Student Details :  Id :{0}, Name : {1}", studentObj3.StudetnId, studentObj3.StudentName);

            Console.ReadLine(); 
        }
    }
}
