using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.AppContext;
using Resume1.Models;

namespace Resume.Repository.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(ResumeContext context) : base(context)
        {
        }
    }
}
