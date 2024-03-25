using _0_Framework;
using Resume.Core.Models;
using Resume1.AppContext;
using Resume1.Models;

namespace Resume.Repository.Repository
{
    public class PersonRepository :RepositoryBase<int, Person>,  IPersonRepository
    {
        private readonly ResumeContext _resumeContext;

        public PersonRepository(ResumeContext resumeContext):base(resumeContext)
        {
            _resumeContext = resumeContext;
        }
    }
}
