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
            IEnumerable<Customer> customers = new CustomerRepository().ToRegister();
            return View(customers);
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            new CustomerRepository().Add(customer);
            return View();
        }
        public ActionResult Login()
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Login successfull";
                return View();
            }
            return View();
        }
    }
}