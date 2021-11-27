using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    internal delegate void firstDelegate();
    internal delegate string secondDelegate(int age, string name);
    class MyDelegates
    {
        internal void display()
        {
            Console.WriteLine("Inside Display Function");
        }
        internal void show()
        {
            Console.WriteLine("Inside Show Function");
        }

        internal string EmployeeData(int age, string name)
        {
            return "Name: " + name + "\nAge: " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegates m = new MyDelegates();
            firstDelegate del1 = new firstDelegate(m.display);
            //Multicasting
            del1 += new firstDelegate(m.show);
            del1();

            del1 -= new firstDelegate(m.display);
            del1();
            Console.WriteLine("\n--------------");
            secondDelegate del2 = new secondDelegate(m.EmployeeData);
            string str= del2(34,"Swati");

            Console.WriteLine(str);

            Console.Read();
        }
    }
}
