using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core.Models;
using Resume.Interface;
using Resume1.Models;

namespace Resume.Service
{
    public class WorkExperienceService : IWorkExperience
    {
        private readonly IGenericRepository<WorkExperience> _genericRepository;

        public WorkExperienceService(IGenericRepository<WorkExperience> repository)
        {
            _genericRepository = repository;
        }
        public void Create(WorkExperience entity)
        {
            _genericRepository.Insert(entity);

        }

        public void Save()
        {
            _genericRepository.SaveChanges();       
        }
    }
}
