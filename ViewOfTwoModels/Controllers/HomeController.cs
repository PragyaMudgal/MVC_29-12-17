using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewOfTwoModels.ViewModel;

namespace ViewOfTwoModels.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(string id)
        {
            TempData["Pragya"] = id;
            TempData.Keep("Pragya");
            return View();
        }
        public ActionResult ThankYou()
        {
            return View();
        }

        public ActionResult GetDetails()
        {
            EmployeeDepartmentVM vmVar = new EmployeeDepartmentVM()
            {
                FirstName = "Pragya",
                LastName = "Mudgal",
                DeptId = 2,
                DeptName = "Financial Services"
            };
            return View(vmVar);
        }
	}
}