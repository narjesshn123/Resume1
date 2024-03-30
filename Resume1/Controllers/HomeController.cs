using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Resume.Application;
using Resume.Service;
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
        private readonly IPersonService _personService;
        private readonly IJobService _jobService;

        public HomeController(IPersonService personService, IJobService jobService)
        {
            _personService = personService;
            _jobService = jobService;   
        }
        public IActionResult Index()
        {
			var person = _personService.GetPersonById(2); 
			return View();  
		}
        [HttpGet]
        public IActionResult Base()
        {
            return View();
        }
        [HttpPost]
		public IActionResult Base(Person person)
		{
           
            _personService.Create(person);
                _personService.Save(); 

            
            return View(person);

        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
