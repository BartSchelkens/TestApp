

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.DataAccessLayer.Repository;
using Constructiv.BE.CS.DmfA.DomainLayer.Domain;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Constructiv.BE.CS.DmfA.DataAccessLayer
{
    public static class SampleData
    {

        public static async Task InitializeDatabaseAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<DatabaseContext>();

                //TODO EnsureCreatedAsync seems to return false although the database and person table exist (manually created)
                //if (await db.Database.EnsureCreatedAsync())
                //{
                    await InsertTestData(serviceProvider);
                //}
            }
        }

        private static async Task InsertTestData(IServiceProvider serviceProvider)
        {
            var albums = GetPeople();
            await AddOrUpdateAsync(serviceProvider, a => a.ID, albums);

        }

        private static Person[] GetPeople()
        {
            return new Person[]
            {
                new Person {ID = 1, Name = "Name1", Type = "type1"},
                new Person {ID = 2, Name = "Name2", Type = "type2"},
                new Person {ID = 3, Name = "Name3", Type = "type3"},
                new Person {ID = 4, Name = "Name4", Type = "type4"},
                new Person {ID = 5, Name = "Name5", Type = "type5"},
                new Person {ID = 6, Name = "Name6", Type = "type6"},
                new Person {ID = 7, Name = "Name7", Type = "type7"},
                new Person {ID=8, Name="Bart Schelkens", Type= "The Boss"}
            };
        }

        private static async Task AddOrUpdateAsync<TEntity>(
            IServiceProvider serviceProvider,
            Func<TEntity, object> propertyToMatch, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            // Query in a separate context so that we can attach existing entities as modified
            List<TEntity> existingData;
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<DatabaseContext>();
                existingData = db.Set<TEntity>().ToList();
            }

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<DatabaseContext>();
                foreach (var item in entities)
                {
                    db.Entry(item).State = existingData.Any(g => propertyToMatch(g).Equals(propertyToMatch(item)))
                        ? EntityState.Modified
                        : EntityState.Added;
                }

                await db.SaveChangesAsync();
            }
        }
    }
}