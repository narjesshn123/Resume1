using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Application;
using Resume1.AppContext;
using Resume1.Models;

namespace Resume1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger; 
		//private readonly GenericService<Person> _genericService; 
		//public HomeController(GenericService<Person> genericService)
		//{
		//	_genericService = genericService;
		//}
        private readonly IPersonService _genericService;

        public HomeController(IPersonService personService)
        {
            _genericService = personService;
        }
        public IActionResult Index()
        {
			return View();  
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
