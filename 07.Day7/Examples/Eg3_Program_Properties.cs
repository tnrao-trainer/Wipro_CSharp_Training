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

        
        public int StudetnId
        {
            get { return _sid; }
            set { _sid = value; }
        }

        public string StudentName
        {
            get { return _sname; }
            set { _sname = value; }
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
