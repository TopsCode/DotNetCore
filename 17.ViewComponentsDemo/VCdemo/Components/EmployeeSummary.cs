using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCdemo.Models;
using WebAppCore.Models;

namespace VCdemo.Components
{    
    public class EmployeeSummary : ViewComponent
    {
        private CompanyContext dc = null;
        public EmployeeSummary(CompanyContext _dc)
        {
            this.dc = _dc;
        }

        //public string Invoke()
        //{
        //    return $"{dc.tblemployees.Count()} Employees," + $"{dc.tblemployees.Sum(s => s.salary)} Sum Of Salary";
        //}

        public IViewComponentResult Invoke(int salary)
        {
            return View(new EmployeeViewModel
            {
                EmployeeCount = dc.tblemployees.Where(x => x.salary == salary).Count(),
                TotalSalary = dc.tblemployees.Where(x => x.salary == salary).Sum(s => s.salary)
            });
        }
    }
}
