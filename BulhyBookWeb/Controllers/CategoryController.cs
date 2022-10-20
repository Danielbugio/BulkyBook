using Microsoft.AspNetCore.Mvc;

namespace BulhyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
