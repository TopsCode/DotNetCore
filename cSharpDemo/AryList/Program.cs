using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AryList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList li = new ArrayList();
            li.Add(89);
            li.Add("Swati");
            li.Add(25000.5);
            li.Add('F');

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
