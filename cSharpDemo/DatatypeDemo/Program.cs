using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte: {0} to {1}",Byte.MinValue,Byte.MaxValue);
            Console.WriteLine("SByte: {0} to {1}",SByte.MinValue,SByte.MaxValue);
            Console.WriteLine("Short: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("UShort: {0} to {1}", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("Int16: {0} to {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("Int32: {0} to {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("Int64: {0} to {1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("UInt16: {0} to {1}", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("UInt32: {0} to {1}", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("UInt64: {0} to {1}", UInt64.MinValue, UInt64.MaxValue);

            Console.WriteLine("Decimal: {0} to {1}", Decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine("Double: {0} to {1}", double.MinValue, double.MaxValue);

            Console.Read();
        }
    }
}
