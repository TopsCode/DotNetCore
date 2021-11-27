using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        string[] fname = new string[5];
        public string this[int index]
        {
            get 
            {
                if (index >= 0 && index < 5)
                {
                    return fname[index];
                }
                else
                {
                    return "Invalid Index";
                }
            }
            set 
            {
                fname[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m[0] = "Aarti";
            m[2] = "Swati";
            m[4] = "Vishal";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name[{0}]: {1}",i,m[i]);
            }
            Console.Read();
        }
    }
}
