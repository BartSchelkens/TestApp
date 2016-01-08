namespace Constructiv.BE.CS.DmfA.DomainLayer.Domain
{
    public class Person
    {
        
        public int ID { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public int Leeftijd { get; set; }

        public int GewerkteDagen { get; set; }
        
        public bool VoldoetAanToekenningsvoorwaarden()
        {
            bool resultaat = false;

            resultaat = (Leeftijd < 52 && GewerkteDagen >= 200) || (Leeftijd == 52 && GewerkteDagen >= 175) ;

            return resultaat;
        }
    }
    
}