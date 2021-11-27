using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();            
            li.Add(new Employee { empid=1,fname="Swati" });
            li.Add(new Employee { empid=2,fname="Vishal" });
            li.Add(new Employee { empid=3,fname= "Jubin" });

            foreach (var item in li)
            {
                Console.WriteLine("Employee ID: "+item.empid);
                Console.WriteLine("Employee Name: "+item.fname);
            }
            
            Console.Read();
        }
    }
}
