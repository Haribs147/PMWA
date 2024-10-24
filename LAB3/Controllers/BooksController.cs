using Microsoft.AspNetCore.Mvc;

namespace OnlineLibrary.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
