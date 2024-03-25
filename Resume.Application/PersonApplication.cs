using System.Collections.Generic;
using Resume.Application.Contracts.Person;
using Resume.Core.Models;
using Resume1.Models;

namespace Resume.Application;
public class PersonApplication : IPersonApplication
{
    private readonly IPersonRepository _personRepository;   
    public PersonApplication(IPersonRepository personRepository)
    {
        _personRepository = personRepository;   
    }
    public OperationResult Create(CreatePerson commmand)
    {
       var operation = new OperationResult();
        if (_personRepository.Exists(commmand.Name))
            return operation.Failed("رکورد تکراری است. "); 
        
        var person = new Person(commmand.Name, commmand.Family, commmand.Email, commmand.Geger, commmand.DateOfBirth, commmand.PhoneNumber);
        _personRepository.Create(person);
        _personRepository.SaveChanges();
        return operation.Success(); 
    }

    public OperationResult Edit(EditPerson commmand)
    {
        var operation = new OperationResult();
      var persons =  _personRepository.Get(commmand.Id);
        if (persons == null)
            operation.Failed("رکورد یافت نشد . "); 
        
        persons.Edit(commmand.Name, commmand.Family, commmand.Email, commmand.PhoneNumber, 
          commmand.Geger, commmand.DateOfBirth);
        _personRepository.SaveChanges(); return operation.Success();
    }
}

