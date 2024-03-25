using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Resume1.AppContext;
using Resume1.Models;

namespace Resume1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		//private readonly IGenericService<Person> _genericService;
	
		public HomeController()
		{
            //_genericService = genericRepository;
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
