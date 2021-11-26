using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeWebApi.Models
{
    public class Employee
    {
        
        [Required(ErrorMessage = "Employee ID is Required")]
        [Display(Name = "Employee ID")]
        public int emp_id { get; set; }
                
        //[Required(ErrorMessage = "First name is Required")]
        [StringLength(10, ErrorMessage = "First name must be less than 10 characters.")]
        public string f_name { get; set; }

        [Display(Name = "Salary")]
        //[Required(ErrorMessage = "Salary is Required")]
        public int salary { get; set; }

        [Display(Name = "Mobile No.")]
        //[Required(ErrorMessage = "Mobile No. is Required")]
        public decimal mobile { get; set; }

        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string email { get; set; }

        [Display(Name = "Password")]
        //[Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }

        [Display(Name = "Date Of Birth")]
        //[Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime? dob { get; set; }

        [Display(Name = "Address")]
        //[Required(ErrorMessage = "Address is Required")]
        public string address { get; set; }

        [Display(Name = "State")]
        //[Required(ErrorMessage = "State is Required")]
        public int? state_id { get; set; }

        [Display(Name = "City")]
        //[Required(ErrorMessage = "City is Required")]
        public int? city_id { get; set; }

        [Display(Name = "Gender")]
        //[Required(ErrorMessage = "Gender is Required")]
        public string gender { get; set; }

        [Display(Name = "Hobbies")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string hobbies { get; set; }

        [Display(Name = "Profile Image")]
        //[Required(ErrorMessage = "Hobbies is Required")]
        public string profilepic { get; set; }
    }
}
