using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEnquiry_EL
{
    public enum Role
    {
        Customer,
        Admin
    }
    public class Customer
    {
        public string name { get; set; }
        public string type { get; set; }
        public string company { get; set; }
        public long mobileNumber { get; set; }
        public string mailId { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string gender { get; set; }
        public Role userRole { get; set; }

    }
}
