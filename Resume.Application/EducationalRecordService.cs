using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core.Models;
using Resume1.Models;

namespace Resume.Service
{
    public class EducationalRecordService : IEducationalRecordService
    {
        private readonly IGenericRepository<EducationalRecord> _genericRepository;

        public EducationalRecordService(IGenericRepository<EducationalRecord> repository)
        {
            _genericRepository = repository;
        }
      

        public void Create(EducationalRecord entity)
        {
            _genericRepository.Insert(entity);

        }

        public void Save()
        {
            _genericRepository.SaveChanges();

        }
    }
}
