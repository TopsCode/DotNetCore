using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public class Employee
    {
        [BindNever]
        public int emp_id { get; set; }
        public string f_name { get; set; }
        [BindNever]
        public string l_name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public int salary { get; set; }

    }
}
