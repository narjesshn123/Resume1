using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core.Models;
using Resume1.Models;

namespace Resume.Service
{
    public class JobService : IJobService
    {

        private readonly IGenericRepository<Job> _genericRepository;

        public JobService(IGenericRepository<Job> repository)
        {
            _genericRepository = repository;
        }

        public Job GetJobById(int id)
        {
            return _genericRepository.GetAll(p => p.Id == id).SingleOrDefault();
        }
    }
}
