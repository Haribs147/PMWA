using Microsoft.AspNetCore.Mvc;
using Zadanie1.Models;

namespace Zadanie1.Controllers
{
    public class CalculationController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calculation());
        }

        [HttpPost]
        public IActionResult Index(Calculation calculation)
        {
            if (ModelState.IsValid)
            {
                calculation.Add();
                return View(calculation);
            }
            return View(calculation);
        }
    }
}
