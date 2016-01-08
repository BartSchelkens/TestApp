using Constructiv.BE.CS.DmfA.DomainLayer.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Constructiv.BE.CS.DmfA.DomainLayerTest
{
    [Binding]
    public class ToekenninsvoorwaardenLegitimiatieKaartSteps
    {

        Person persoon = new Person();
        bool resultaat;

        [Given(@"I am (.*) years old")]
        public void GivenIAmYearsOld(int leeftijd)
        {
            persoon.Leeftijd = leeftijd;
        }
        
        [Given(@"I have worked (.*) days")]
        public void GivenIHaveWorkedDays(int gewerkteDagen)
        {
            persoon.GewerkteDagen = gewerkteDagen;
        }
        
        [When(@"I check the Toekenningsvoorwaarden")]
        public void WhenICheckTheToekenningsvoorwaarden()
        {
            resultaat = persoon.VoldoetAanToekenningsvoorwaarden();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(bool verwachtResultaat)
        {
            Assert.AreEqual(verwachtResultaat, resultaat);
        }
    }
}
