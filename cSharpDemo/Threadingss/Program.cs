using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threadingss
{
    class MyClass
    {
        internal void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\tThread: " + Thread.CurrentThread.Name + ": " + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Parent Thread";
            MyClass m = new MyClass();
            Thread t = new Thread(new ThreadStart(m.Display));
            t.Name = "Child Thread";
            t.Start();

            t.Join();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: " + Thread.CurrentThread.Name + ": " + i);
                //Thread.Sleep(1000);
            }

            Console.Read();
        }
    }
}
