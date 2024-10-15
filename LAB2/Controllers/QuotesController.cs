using Microsoft.AspNetCore.Mvc;

namespace LAB3.Controllers
{
    public class QuotesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}