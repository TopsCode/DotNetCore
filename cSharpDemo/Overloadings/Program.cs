using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadings
{
    class Shape
    {
        internal void Area(double r)
        {
            Console.WriteLine("Area Of Circle: {0}", 3.14 * r * r);
        }
        internal void Area(int a)
        {
            Console.WriteLine("Area Of Square: {0}", a * a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape obj = new Shape();
            obj.Area(10);
            obj.Area(10.5);

            Console.Read();
        }
    }
}
