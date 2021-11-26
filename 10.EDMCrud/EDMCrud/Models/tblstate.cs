using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Models
{
    [Table("tblstate")]
    public class tblstate
    {
        [Key]
        public int state_id { get; set; }
        public string state_name { get; set; }
    }
}
