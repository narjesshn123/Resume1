using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Interface {


    public interface ILanguageService
    {
        public List<Languages> GetAllLanguage();
        void Create(Languages entity);
        void Save();

    }
    }

