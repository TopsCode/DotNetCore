using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Services
{
    public class VisitorCounter : IVisitorCounter
    {
        public int Counter { get; set; }

        public int GetCount()
        {
            Counter++;
            return Counter;
        }
    }
}
