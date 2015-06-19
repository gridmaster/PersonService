using System.Collections.Generic;
using System.ServiceModel;
using PersonService.Models;
using PersonService.Models.Requests;

namespace PersonService
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        string GetPerson(int id);

        [OperationContract]
        Person InsertPerson(Person[] person);
  
        [OperationContract]
        Person UpdatePerson(int id, Person person);

        [OperationContract]
        void DeletePerson(int id);
    }
}
