using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.DomainLayer.Domain;
using Microsoft.Data.Entity;

namespace Constructiv.BE.CS.DmfA.DataAccessLayer.Repository
{
    public class DatabaseContext : DbContext
    {
            public DbSet<Person> Persons{ get; set; }

        
    }
}
