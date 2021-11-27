using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancess
{
    class Employee
    {
        int id;
        string name;
        protected void getEmployee()
        {
            Console.Write("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }
        protected void ShowEmployee()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
        }
    }
    class Payroll : Employee
    {
        double salary;
        internal void GetPayrollDetails()
        {
            getEmployee();
            Console.Write("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        internal void ShowPayrollDetails()
        {
            ShowEmployee();
            Console.WriteLine("Employee Salary: "+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetPayrollDetails();
            p.ShowPayrollDetails();

            Console.Read();
        }
    }
}
