using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanEnquiry_EL;
using LoanEnquiry_DAL;

namespace LoanEnquiryMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration(Customer customer)
        {
            CustomerRepository.Registration(customer);
            ViewBag.Message = "Registered successfull";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login successfull";
            return View();
        }
    }
}