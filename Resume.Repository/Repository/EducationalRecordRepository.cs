using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.AppContext;

namespace Resume.Repository.Repository
{
    public class EducationalRecordRepository : GenericRepository<EducationalRecordRepository>, IEducationalRecordRepository
    {
        public EducationalRecordRepository(ResumeContext context) : base(context)
        {
        }
    }
}
