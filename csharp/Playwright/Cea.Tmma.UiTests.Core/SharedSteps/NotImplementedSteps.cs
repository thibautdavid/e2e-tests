using TechTalk.SpecFlow;

namespace Cea.Tmma.UiTests.Core.SharedSteps
{
    [Binding]

    public class NotImplementedSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public NotImplementedSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("Ce test doit etre rédigé")]
        [Given("L'écriture de ce test doit etre terminée")]
        [Given("En attente de l'implémentation de la fonctionnalité")]
        [Given("En attente de la correction de l'anomalie")]
        public void GivenNotReadyToTest()
        {
            _scenarioContext.Pending();
        }
    }
}
