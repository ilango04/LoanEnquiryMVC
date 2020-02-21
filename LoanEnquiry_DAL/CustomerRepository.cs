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
        Customer customer = new Customer();
        public IEnumerable<Customer> ToRegister()
        {
           return customerDetails;
        }
        public void Add(Customer customer)
        {
            customerDetails.Add(customer);
        }
    }
}
