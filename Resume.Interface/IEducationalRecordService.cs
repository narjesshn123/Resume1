using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resume.Interface
{
    public interface IEducationalRecordService
    {
        void Create(EducationalRecord entity);
        void Save();
    }
}
