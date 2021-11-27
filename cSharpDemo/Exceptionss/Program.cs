using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionss
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 90;
                int b = 0;
                int c = a / b;

                //throw new OverflowException("Manualy Thrown");

                Console.WriteLine("This will not be Displayed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
