using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Student
    {
        private int _sid;
        private string _sname;

        public int GetSid() { return _sid; }
        public void SetSid(int sid) { _sid = sid; }


        public string GetSname()
        {
            return _sname;
        }

        public void SetSname(string str)
        {
            _sname = str;
        }

        public void ReadStudentDetails()
        {
            Console.WriteLine("Enter Student Id ");
            _sid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name : ");
            _sname = Console.ReadLine();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Details :  Id :{0}, Name : {1}", _sid, _sname);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student studentObj = new Student();

            studentObj.ReadStudentDetails();
            studentObj.PrintStudentDetails();


            studentObj.SetSid(4465456);            
            studentObj.SetSname("Narasimha");

            Console.WriteLine("Student Name :  " + studentObj.GetSname());
            Console.WriteLine("Student Id :  " + studentObj.GetSid());

            studentObj.PrintStudentDetails();   // All Details 

            Console.ReadLine();


        }
    }
}
