using OefeningPersonsMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OefeningPersonsMVC.Services
{
    public interface IPersonData
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        void Add(Person newPerson);
        void Delete(Person newPerson);
        void Update(Person newPerson);
    }
    public class InMemoryPersonData : IPersonData
    {
        private static List<Person> _person;
        static InMemoryPersonData()
        {
            _person = new List<Person>
            {
                new Person {Id = 1, FirstName = "Dimitri", LastName = "Sturm", Address = null, Gender = Gender.Male},
                new Person {Id = 2, FirstName = "Kris", LastName = "De Ridder", Address = null, Gender = Gender.Female},
                new Person {Id = 3, FirstName = "Dimitri", LastName = "Sturm", Address = "Kapellen", Gender = Gender.Male}

            };
        }

        public Person Get(int id)
        {
            return _person.FirstOrDefault(x => x.Id == id);

        }


        public IEnumerable<Person> GetAll()
        {
            return _person;
        }

        public void Add(Person newPerson)
        {
            newPerson.Id = _person.Max(x => x.Id) + 1;
            _person.Add(newPerson);

        }

        public void Delete(Person newPerson)
        {
            _person.Remove(newPerson);
        }

        public void Update(Person newPerson)
        {
            var oldPerson = Get((int)newPerson.Id);
            oldPerson.FirstName = newPerson.FirstName;
            oldPerson.LastName = newPerson.LastName;
            oldPerson.Address = newPerson.Address;
            oldPerson.Gender = newPerson.Gender;

        }
    }
}
