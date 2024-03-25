using Microsoft.AspNetCore.Mvc;

namespace Resume1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
