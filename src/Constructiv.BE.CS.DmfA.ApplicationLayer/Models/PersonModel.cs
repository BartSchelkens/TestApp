using Constructiv.BE.CS.DmfA.InfrastructureLayer;

namespace Constructiv.BE.CS.DmfA.ApplicationLayer.Models
{
    public class PersonModel
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }


        public class PersonModelBuilder : AbstractBuilder<PersonModel>
        {

            public override PersonModel CreateInstance()
            {
                return new PersonModel();
            }

            public PersonModelBuilder Id(int id)
            {
                Instance.ID = id;
                return this;
            }

            public PersonModelBuilder Name(string name)
            {
                Instance.Name = name;
                return this;
            }

            public PersonModelBuilder Type(string type)
            {
                Instance.Type = type;
                return this;
            }
        }
    }
}