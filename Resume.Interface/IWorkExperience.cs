using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resume.Interface

{
    public interface IWorkExperience
    {
       
        void Create(WorkExperience entity);
        void Save();
    }
}
