using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.AppContext;

namespace Resume.Repository.Repository
{
    public class WorkExperience : GenericRepository<WorkExperience>, IWorkExperience
    {
        public WorkExperience(ResumeContext context) : base(context)
        {
        }
    }
}
