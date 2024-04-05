using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Resume.Interface;
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
        private readonly ILanguageService _languageService;
        private readonly IWorkExperience _workExperience;
        private readonly ISkillService _skillService; 
        private readonly IEducationalRecordService _educationalRecordService;


        //private readonly 

        public HomeController(IPersonService personService, IJobService jobService, ILanguageService languageService)
        {
            _personService = personService;
            _jobService = jobService; 
            _languageService = languageService; 
        }
        
        public IActionResult Index(Person person)
        {
            var existPerson = _personService.GetPersonById(person.Id);
            if (existPerson != null)
            {
                existPerson.Name = person.Name;
                existPerson.PhoneNumber = person.PhoneNumber;
                existPerson.Email = person.Email;
                existPerson.Family = person.Family;
                _personService.UpdatePerson(existPerson);
            }
            else
            {
                _personService.Create(person); 
            }
            
            _personService.Save();


            return View(person);
        }
        [HttpGet]
        public IActionResult Base(int id)
        {
            var person = _personService.GetPersonById(id);  
            return View(person);
        }
        [HttpPost]
        public IActionResult Base(Person person)
        {
           
                if (ModelState.IsValid)
                {
                    if (person.Id <= 0) // Assuming 0 or less ID indicates a new Person
                    {
                        _personService.Create(person);
                    }
                    else
                    {
                        _personService.UpdatePerson(person);
                    }
                    _personService.Save();

                    return RedirectToAction("Index", "Home");

                }
            return View(person);

        }
        [HttpGet]
        public IActionResult Job()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Job(Job job)
        //{

        //    _jobService.Create(job);
        //    _jobService.Save();


        //    return View(job);

        //}
        [HttpGet]
        public IActionResult Education()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Education(EducationalRecord educational)
        //{

        //    _educationalRecordService.Create(educational);
        //    _educationalRecordService.Save();


        //    return View(educational);

        //}
        [HttpGet]
        public IActionResult Language()
        {
            var languag = new List<Languages>
    {
        new Languages() { Id = 1, Name = "فارسی" },
        new Languages(){ Id = 2, Name = "انگلیسی"},
        new Languages(){ Id = 3, Name = "فرانسه"},
        new Languages(){ Id = 4, Name = "ایتالیایی"},
        new Languages(){ Id = 5, Name = "آلمانی "},
        new Languages(){ Id = 6, Name = "اسپانیایی"}
    };
            return View(languag);
        }
        //[HttpPost]
        //public IActionResult Language(Languages language)
        //{

        //    _languageService.Create(language);
        //    _languageService.Save();
        //    var languag = new List<Languages>();



        //    return View(languag);

        //}
        [HttpGet]
        public IActionResult Skill()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Skill(Skills skills)
        //{
        //    _skillService.Create(skills);
        //    _skillService.Create(skills);
        //    //_jobService.Save();


        //    return View(skills);

        //}
        [HttpGet]
        public IActionResult Work()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Work(WorkExperience workExperience)
        //{

        //    _workExperience.Create(workExperience);
        //    _workExperience.Save();


        //    return View(workExperience);

        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
