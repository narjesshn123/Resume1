using Microsoft.AspNetCore.Mvc;
using Resume1.AppContext;

namespace Resume1.Controllers
{
	public class PersonController : Controller
	{
		private readonly AppContext.ResumeContext _context;

        public PersonController(AppContext.ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
			return View();
		}
	}
}
