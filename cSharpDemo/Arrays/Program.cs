using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 1;
            ar[1] = 5;
            ar[2] = 6;
            ar[3] = 9;
            ar[4] = 3;

            Console.WriteLine("Array Data: ");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(" "+ar[i]);
            }
            Console.Read();
        }
    }
}
