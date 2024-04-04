using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core;

namespace Resume.Interface

{
    public interface IJobService
    {
        Job GetJobById(int id);
        void Create(Job entity);
        void Save();
         

    }
}
