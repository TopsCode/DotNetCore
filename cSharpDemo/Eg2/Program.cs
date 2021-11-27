using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eg2
{
    class Student
    {
        int roll;
        protected void getStudent()
        {
            Console.Write("Enter roll NO: ");
            roll = Convert.ToInt32(Console.ReadLine());
        }
        protected void ShowStudent()
        {
            Console.WriteLine("Employee Roll: " + roll);
        }
    }
    class Test : Student
    {
        protected int m1, m2;
        protected void getTestMarks()
        {
            getStudent();
            Console.Write("Enter Marks 1: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
        }
        protected void ShowTestMarks()
        {
            ShowStudent();
            Console.WriteLine("Marks 1: " + m1);
            Console.WriteLine("Marks 2: " + m2);
        }
    }
    class Result : Test
    {
        int total;
        internal void getResult()
        {
            getTestMarks();
            total = m1 + m2;
        }
        internal void ShowResult()
        {
            ShowTestMarks();
            Console.WriteLine("Total marks: " + total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result r = new Result();
            r.getResult();
            r.ShowResult();
            Console.Read();
        }
    }
}
