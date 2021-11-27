using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string name;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter number A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, c);

            Console.Read();
        }
    }
}
