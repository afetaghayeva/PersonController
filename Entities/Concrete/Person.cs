using Entities.Abstract;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
    }
}
