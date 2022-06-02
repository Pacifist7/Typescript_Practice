using Microsoft.AspNetCore.Mvc;

namespace IMDB_Lab.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
