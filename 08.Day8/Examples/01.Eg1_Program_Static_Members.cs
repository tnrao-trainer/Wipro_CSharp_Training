using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    // Context:  Maintain the student details belongs to a particular college
    class Student
    {
        private string _sname;
        private static string _cname; // static item


        public string Name
        {
            get { return _sname; }
            set { _sname = value; }
        }

        // static property
        public static string CollegeName
        {
            get { return _cname; }
            set { _cname = value; }
        }

        public void Print()
        {
            Console.WriteLine("Student Name : {0}, College Name :{1}", _sname, _cname);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student.CollegeName = "CBIT";

            Student obj1 = new Student();
            obj1.Name = "Ravi";

            Student obj2 = new Student();
            obj2.Name = "Ragu";

            obj1.Print();
            obj2.Print();

            Console.WriteLine("\n");
            Student.CollegeName = "VNR";
            obj1.Print();
            obj2.Print();

            Console.ReadLine();
        }
    }
}
