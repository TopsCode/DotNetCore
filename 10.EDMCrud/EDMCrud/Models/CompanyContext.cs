using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Models
{
    public class CompanyContext: DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<tblemployee> tblemployees { get; set; }
        public DbSet<tblstate> tblstates { get; set; }
    }
}
