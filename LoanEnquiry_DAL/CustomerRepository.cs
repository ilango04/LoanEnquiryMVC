using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanEnquiry_EL;

namespace LoanEnquiry_DAL
{
    public class CustomerRepository
    {
        public static List<Customer> customerDetails = new List<Customer>();
        public static void Registration(Customer customer)
        {
            customerDetails.Add(customer);
        }
    }
}
