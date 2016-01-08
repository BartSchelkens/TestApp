using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.DomainLayer.Domain;

namespace Constructiv.BE.CS.DmfA.DataAccessLayer.Repository
{
    public class PersonRepository
    {
        public DatabaseContext DbContext { get; }

        public PersonRepository(DatabaseContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IEnumerable<Person> GetAll()
        {
            return DbContext.Persons.ToList();
        }

        public IEnumerable<Person> GetPersonsByType(string type)
        {
            return DbContext.Persons.Where(o => o.Type.ToLower().Equals(type.ToLower())).ToList();
        }

        public Person GetPersonById(int id)
        {
            return DbContext.Persons.FirstOrDefault(o => o.ID == id);
        }

    }
}
