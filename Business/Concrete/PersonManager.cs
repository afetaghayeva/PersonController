using Business.Abstract;
using Business.Validation;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PersonManager:IPersonService
    {
        private readonly IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> FindAll()
        {
            return _personDal.FindAll();
        }

        public Person FindById(int id)
        {
            return _personDal.Find(p => p.Id == id);
        }

        public List<Person> FindByName(string name)
        {
            return _personDal.FindAll(p => p.PersonName.ToLower().Contains(name.ToLower()));
        }

        public void Save(Person person)
        {
            ValidationTool.FluentValidate(new PersonValidator(),person);
            _personDal.Save(person);
        }

        public void Update(Person person)
        {
            ValidationTool.FluentValidate(new PersonValidator(), person);
            _personDal.Update(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }
    }
}
