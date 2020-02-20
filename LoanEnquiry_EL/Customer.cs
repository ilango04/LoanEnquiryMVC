using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEnquiry_EL
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [MaxLength(30)]
        public string name { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Please enter your employment type")]
        public string type { get; set; }
        [MaxLength(30)]
        [Required(ErrorMessage = "Please enter your company name.")]
        public string company { get; set; }
        [Required(ErrorMessage = "select a gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please select a role")]
        [MaxLength(10)]
        public Roles userRole { get; set; }
        [Required(ErrorMessage = "Please enter your 10 digit mobile number.")]
        [MaxLength(10)]
        public long mobileNumber { get; set; }
        [Required(ErrorMessage = "Please enter your emailid")]
        [MaxLength(30)]
        public string mailId { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        [MaxLength(10)]
        public string password { get; set; }
        [Required(ErrorMessage = "Please re-enter a password.")]
        [MaxLength(10)]
        public string confirmPassword { get; set; }

    }
    public enum Roles
    {
        Customer,
        Admin
    }
}
