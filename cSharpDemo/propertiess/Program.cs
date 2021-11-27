using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiess
{
    class MyClass
    {
        int salary=35000;
        public int Psalary 
        {
            get
            {
                return salary;
            }
            //set
            //{
            //    salary = value;
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            //m.Psalary = 25000;
            Console.WriteLine(m.Psalary);

            Console.Read();
        }
    }
}
