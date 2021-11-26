using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="First name is Required.")]
        [StringLength(15,ErrorMessage ="First name cannot be less than 15 characters.")]
        public string fname { get; set; }

        [Required(ErrorMessage ="Date of bith is required.")]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime dob { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage ="Enter valid Email address")]
        public string email { get; set; }

        [Required(ErrorMessage = "PhoneNo is required.")]
        [DisplayName("Phone number")]
        public int PhoneNo { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [Required(ErrorMessage = "Photo is required.")]
        [FileExtensions(Extensions ="png,jpg,jpeg,gif")]
        public string photo { get; set; }

        [Required(ErrorMessage = "password is required.")]
        [StringLength(11,MinimumLength =5,ErrorMessage ="minimum length is 5 and maximum is 11.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm new password")]
        [Compare("password",ErrorMessage ="passwords mismatch.")]
        public string cnfpassword { get; set; }


    }
}
