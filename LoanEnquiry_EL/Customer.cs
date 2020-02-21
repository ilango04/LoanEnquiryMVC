using System.ComponentModel.DataAnnotations;
namespace LoanEnquiry_EL
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter your name.") ]
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
        public Roles userRole { get; set; }
        [Required(ErrorMessage = "Please enter your 10 digit mobile number.")]
        public long mobileNumber { get; set; }
        [Required(ErrorMessage = "Please enter your emailid")]
        [MaxLength(30)]
        public string mailId { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        [MaxLength(10)]
        public string password { get; set; }
        public Customer(string name,string type,string company,string gender,Roles userRole,long mobileNumber,string mailId,string password)
        {
            this.name = name;
            this.type = type;
            this.company = company;
            this.gender = gender;
            this.userRole = userRole;
            this.mobileNumber = mobileNumber;
            this.mailId = mailId;
            this.password = password;
        }
        public Customer()
        {

        }
    }
    public enum Roles
    {
        Customer,
        Admin
    }
}
