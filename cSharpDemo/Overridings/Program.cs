using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridings
{
    abstract class Employee
    {
        virtual internal void Display()
        {
            Console.WriteLine("Inside Employee Method");
        }
    }
    class Payroll : Employee
    {
        override internal void Display()
        {
            Console.WriteLine("Inside Payroll Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Payroll();
            obj.Display();

            Console.Read();
        }
    }
}
