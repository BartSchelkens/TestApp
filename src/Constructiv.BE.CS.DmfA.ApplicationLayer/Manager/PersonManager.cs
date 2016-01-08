using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Models;
using Constructiv.BE.CS.DmfA.DataAccessLayer.Repository;
using Constructiv.BE.CS.DmfA.DomainLayer.Domain;
using Microsoft.AspNet.Mvc;

namespace Constructiv.BE.CS.DmfA.ApplicationLayer.Manager
{
    public class PersonManager : IPersonManager
    {

        public PersonRepository PersonRepository { get; set; }

        public PersonManager(PersonRepository personRepository)
        {
            this.PersonRepository = personRepository;
        }

        
        public IEnumerable<PersonModel> GetAll()
        {
            return ToModels(PersonRepository.GetAll());
        }

        public IEnumerable<PersonModel> GetPersonsByType(string type)
        {
            return ToModels(PersonRepository.GetPersonsByType(type));
        }

        public PersonModel GetPersonById(int id)
        {
            return ToModel(PersonRepository.GetPersonById(id));
        }

        private PersonModel ToModel(Person person)
        {
            if (person == null) return null;
            return new PersonModel.PersonModelBuilder().Id(person.ID).Name(person.Name).Type(person.Type).Build();
        }

        private IEnumerable<PersonModel> ToModels(IEnumerable<Person> persons)
        {
            return persons.Select(ToModel).ToList();
        }
    }
}