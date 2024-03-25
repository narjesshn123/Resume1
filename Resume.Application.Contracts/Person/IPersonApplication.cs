using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Contracts.Person;          
    public interface IPersonApplication
    {
    OperationResult Create(CreatePerson commmand);
    OperationResult Edit(EditPerson command);   
    //Person GetPerson(int id);    
    }
