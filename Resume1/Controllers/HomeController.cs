using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Resume.Application;
using Resume.Service;
using Resume1.Models;
using Syncfusion.EJ2.Schedule;

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
        private readonly ILanguageService _languageService;
        //private readonly 

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
        [HttpGet]
        public IActionResult Job()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Job(Job job)
        {

            _jobService.Create(job);
            _jobService.Save();


            return View(job);

        }
        [HttpGet]
        public IActionResult Education()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Education(EducationalRecord educational)
        {

            //_jobService.Create(educational);
            //_jobService.Save();


            return View(educational);

        }
        [HttpGet]
        public IActionResult Language()
        {
            var languages = new List<Languages>
    {
        new Languages() { Id = 1, Name = "فارسی" },
        new Languages(){ Id = 2, Name = "انگلیسی"},
        new Languages(){ Id = 3, Name = "فرانسه"},
        new Languages(){ Id = 4, Name = "ایتالیایی"},
        new Languages(){ Id = 5, Name = "آلمانی "},
        new Languages(){ Id = 6, Name = "اسپانیایی"}
    };
            return View(languages);
        }
        [HttpPost]
        public IActionResult Language(Languages language)
        {

            //_jobService.Create(job);
            //_jobService.Save();


            return View(language);

        }
        [HttpGet]
        public IActionResult Skill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Skill(Skills skills)
        {

            //_jobService.Create(job);
            //_jobService.Save();


            return View(skills);

        }
        [HttpGet]
        public IActionResult Work()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Work(WorkExperience workExperience)
        //{

        //    _jobService.Create(job);
        //    _jobService.Save();


        //    return View(workExperience);

        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
