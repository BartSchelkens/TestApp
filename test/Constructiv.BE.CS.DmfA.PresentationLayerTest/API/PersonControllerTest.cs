using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rhino.Mocks;
using Xunit;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Manager;
using Constructiv.BE.CS.DmfA.ApplicationLayer.Models;
using Constructiv.BE.CS.DmfA.PresentationLayer.API;
using Microsoft.Extensions.Logging;

namespace Constructiv.BE.CS.DmfA.PresentationLayerTest.API
{
    
    public class PersonControllerTest
    {
        private readonly PersonsController _personController;
        private readonly IPersonManager _personManagerMock;
        private readonly ILogger<PersonsController> _loggerMock;

        private readonly PersonModel _person;

        public PersonControllerTest()
        {
            _person = PersonModelBuilderForTest.DefaultPerson(1).Build();
            _personManagerMock = MockRepository.GenerateMock<IPersonManager>();
            _loggerMock = MockRepository.GenerateMock<ILogger<PersonsController>>();
            _personController = new PersonsController(_personManagerMock, _loggerMock);
        }

        [Fact]
        public void TestGet_GetsPersonModelsFromManager()
        {
            _personManagerMock.Expect(manager => manager.GetAll()).Return(new List<PersonModel>() {_person});

            var output = _personController.Get();

            Assert.Contains(_person, output);
        }

        [Fact]
        public void TestGetById_GetsPersonModelForThatIdFromManager()
        {
            _personManagerMock.Expect(manager => manager.GetPersonById(1)).Return(_person);

            var output = _personController.Get(1);

            Assert.Equal(_person, output);
        }

    }
}

