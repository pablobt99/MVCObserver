using System.Diagnostics;
using EcoMvcObserver.Departments;
using Microsoft.AspNetCore.Mvc;
using Observer.Models;
using Observer.Subject;

namespace Observer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsset _it;
        private readonly IFinance _finance;
        private readonly IResignation _resignation;

        public HomeController(IAsset it, IFinance finance,
            IResignation resignation)
        {
            _it = it;
            _finance = finance;
            _resignation = resignation;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ITDept()
        {
            _it.AllocateAsset();

            ViewBag.Dept = "IT - Allocated assets";
            return View("Index");
        }

        [HttpPost]
        public IActionResult Finance()
        {
            _finance.CalculateSalary();

            ViewBag.Dept = "Finance - Calculated salary";
            return View("Index");
        }

        [HttpPost]
        public void EmployeeSeparate(string EmployeeId)
        {
            // does something related to employee seperate

            _resignation.NotifyObserver(EmployeeId);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
