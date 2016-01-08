using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Manager;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Models;
using Constructiv.BE.CS.DmfA.DomainLayer.Domain;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructiv.BE.CS.DmfA.PresentationLayer.API
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonManager _personManager;
        private readonly ILogger<PersonsController> _logger;

        public PersonsController(IPersonManager personManager, ILogger<PersonsController> logger) 
        {
            this._personManager = personManager;
            this._logger = logger;
        }

        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
            _logger.LogInformation("Getting all persons");
            return _personManager.GetAll();   
        }

        [HttpGet("{id}")]
        public PersonModel Get(int id)
        {
            _logger.LogInformation("Getting person with id {0}", id);
            return _personManager.GetPersonById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /*
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
