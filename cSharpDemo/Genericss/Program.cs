using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    class MyGen<Type1, Type2>
    {
        Type1 id;
        Type2 name;

        public MyGen(Type1 id, Type2 n)
        {
            this.id = id;
            name = n;
        }

        internal void display()
        {
            Console.WriteLine("Value1: " + id);
            Console.WriteLine("Value2: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGen<int, string> m = new MyGen<int, string>(4435,"Swati");
            Console.WriteLine("----Object 1----");
            m.display();
            
            Console.WriteLine("----Object 2----");
            MyGen<string, DateTime> m2 = new MyGen<string, DateTime>("Swati",DateTime.Now);
            m2.display();

            Console.Read();
        }
    }
}
