using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.Models;


namespace Resume.Interface

{
    public interface IWorkExperience
    {

        void Create(WorkExperience entity);  
        void Save();
    }
}
