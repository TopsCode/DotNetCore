using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Weekdays
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            int i;
            day = Weekdays.Thursday.ToString();
            i = (int)Weekdays.Thursday;
            Console.WriteLine("Day: " + day);
            Console.WriteLine("i: " + i);

            Console.Read();
        }
    }
}
