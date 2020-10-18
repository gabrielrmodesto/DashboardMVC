using DashboardMVC.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardMVC.Controllers
{
    public class CustomerOrderController : Controller
    {
        // GET: CustomerOrder
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CustomerList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCustomers()
        {
            using (DashboardContext _context = new DashboardContext())
            {
                var customerList = _context.CustomerSet.Select(c => new
                {
                    c.ID,
                    c.CustomerName,
                    c.CustomerEmail,
                    c.CustomerPhone,
                    c.CustomerCountry,
                    c.CustomerImage
                }).ToList();

                return Json(new { data = customerList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}