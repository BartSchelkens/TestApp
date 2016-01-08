using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class ToekenninsvoorwaardenLegitimiatieKaartSteps
    {
        [Given(@"I am under (.*) years old")]
        public void GivenIAmUnderYearsOld(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have worked (.*) days")]
        public void GivenIHaveWorkedDays(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I check the Toekenningsvoorwaarden")]
        public void WhenICheckTheToekenningsvoorwaarden()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should receive a LegitimatieKaart")]
        public void ThenIShouldReceiveALegitimatieKaart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
