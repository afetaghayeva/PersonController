using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> FindAll();
        Person FindById(int id);
        List<Person> FindByName(string name);
        void Save(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
