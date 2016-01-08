using System.Collections.Generic;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Models;
using Constructiv.BE.CS.DmfA.DataAccessLayer.Repository;

namespace Constructiv.BE.CS.DmfA.ApplicationLayer.Manager
{
    public interface IPersonManager
    {
        IEnumerable<PersonModel> GetAll();

        IEnumerable<PersonModel> GetPersonsByType(string type);

        PersonModel GetPersonById(int id);
    }
}