using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequenceMVC.Controllers
{
    public class FibonacciController : Controller
    {
        // GET: Fibonacci
        public ActionResult Index()
        {                              
            int sum = 1;
            int total = 0;
            int newTotal = 0;

            for (int ctr = 1; ctr < 21; ctr++)
            {
                total = newTotal + sum;
                newTotal = sum;
                sum = total;
            }

            ViewBag.total = total;

            return View();
        }
    }
}