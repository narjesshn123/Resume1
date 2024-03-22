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
		//private readonly IGenericRepository<Person> _genericRepository;
		//public HomeController(IGenericRepository<Person> genericRepository)
		//{
		//	_genericRepository = genericRepository;
		//}
		public IActionResult Index()
		{
			//var person = _genericRepository.GetAll();

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
