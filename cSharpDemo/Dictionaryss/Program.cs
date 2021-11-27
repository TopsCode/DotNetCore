using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("Name", "Swati");
            dic.Add("Id", 345);
            dic.Add("Salary", 35000.5);

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.Read();
        }
    }
}
