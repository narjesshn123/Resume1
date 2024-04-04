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
    public class SkillService : ISkillService
    {
        private readonly IGenericRepository<Skills> _genericRepository;

        public SkillService(IGenericRepository<Skills> repository)
        {
            _genericRepository = repository;
        }
        public void Create(Skills entity)
        {
            _genericRepository.Insert(entity);

        }

        public void Save()
        {
            _genericRepository.SaveChanges();
 
        }
    }
}
