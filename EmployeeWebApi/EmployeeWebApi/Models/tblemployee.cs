using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Models
{
    [Table("tblemployee")]
    public class tblemployee
    {
        [Column("emp_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage ="Employee ID is Required")]
        [Display(Name ="Employee ID")]
        public int emp_id { get; set; }

        [Column("f_name")]
        [Display(Name = "First name")]
        //[Required(ErrorMessage = "First name is Required")]
        [StringLength(10,ErrorMessage = "First name must be less than 10 characters.")]
        public string f_name { get; set; }

        [Column("salary")]
        [Display(Name = "Salary")]
        //[Required(ErrorMessage = "Salary is Required")]
        public int salary { get; set; }

        [Column("mobile")]
        [Display(Name = "Mobile No.")]
        //[Required(ErrorMessage = "Mobile No. is Required")]
        public decimal mobile { get; set; }

        [Column("email")]
        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string email { get; set; }

        [Column("password")]
        [Display(Name = "Password")]
        //[Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }

        [Column("dob")]
        [Display(Name = "Date Of Birth")]
        //[Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime? dob { get; set; }

        [Column("address")]
        [Display(Name = "Address")]
        //[Required(ErrorMessage = "Address is Required")]
        public string address { get; set; }

        [Column("state_id")]
        [Display(Name = "State")]
        //[Required(ErrorMessage = "State is Required")]
        public int? state_id { get; set; }

        [Column("city_id")]
        [Display(Name = "City")]
        //[Required(ErrorMessage = "City is Required")]
        public int? city_id { get; set; }

        [Column("gender")]
        [Display(Name = "Gender")]
        //[Required(ErrorMessage = "Gender is Required")]
        public string gender { get; set; }

        [Column("hobbies")]
        [Display(Name = "Hobbies")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string hobbies { get; set; }

        [Column("profilepic")]
        [Display(Name = "Profile Image")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string profilepic { get; set; }

    }
}
