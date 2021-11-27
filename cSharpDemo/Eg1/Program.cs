using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eg1
{
    class Person
    {
        int age;
        string name;
        protected void getPerson()
        {
            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }
        protected void ShowPerson()
        {
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee Name: " + name);
        }
    }
    class Student : Person
    {
        int percentage;
        internal void getStudent()
        {
            getPerson();
            Console.Write("Enter percentage: ");
            percentage = Convert.ToInt32(Console.ReadLine());
        }
        internal void ShowStudent()
        {
            ShowPerson();
            Console.WriteLine("Employee percentage: " + percentage);
        }
    }
    class Teacher : Person
    {
        int salary;
        internal void getTeacher()
        {
            getPerson();
            Console.Write("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        internal void ShowTeacher()
        {
            ShowPerson();
            Console.WriteLine("Employee salary: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("-----Student Details-----");
            s.getStudent();
            s.ShowStudent();
            Console.WriteLine("\n-----Teacher Details-----");
            Teacher t = new Teacher();
            t.getTeacher();
            t.ShowTeacher();

            Console.Read();
        }
    }
}
