using Constructiv.BE.CS.DmfA.ApplicationLayer.Models;

namespace Constructiv.BE.CS.DmfA.PresentationLayerTest.API
{
    public class PersonModelBuilderForTest
    {

        public static PersonModel.PersonModelBuilder DefaultPerson(int id)
        {
            return new PersonModel.PersonModelBuilder().Id(id).Name("name").Type("type");
        }
         
    }
}