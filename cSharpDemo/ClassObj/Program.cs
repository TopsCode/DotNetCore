using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObj
{
    class Employee
    {
        int id;
        string name;
        double salary;

        internal Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        internal void GetEmployeeDetails()
        {
            id = 1;
            name = "Swati";
            salary = 35000.5;
        }

        internal void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(2,"Swati",25000.5);

            //obj.GetEmployeeDetails();
            obj.ShowEmployeeDetails();

            Console.Read();
        }
    }
}
