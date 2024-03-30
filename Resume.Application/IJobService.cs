using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.Models;

namespace Resume.Service
{
    public interface IJobService
    {
        Job GetJobById(int id);
    }
}
