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
    public class LanguageService : ILanguageService
    {
        private readonly IGenericRepository<Languages> _genericRepository;

        public LanguageService(IGenericRepository<Languages> repository)
        {
            _genericRepository = repository;
        }

        public void Create(Languages entity)
        {
            _genericRepository.Insert(entity);

        }

        public List<Languages> GetAllLanguage()
        {
            return _genericRepository.GetAll(null).ToList();  
        }

        public void Save()
        {
            _genericRepository.SaveChanges();

        }
    }
}
