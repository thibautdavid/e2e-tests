using PlaywrightTests.Specflow.PageObjects;
using TechTalk.SpecFlow;

namespace PlaywrightTests.Specflow.StepsDefinitions
{
    [Binding]
    internal class HomePageStepsDefiinition
    {
        private readonly HomePage _homePage;
        private readonly Navigator _navigator;

        public HomePageStepsDefiinition(ScenarioContext scenarioContext)
        {
            _navigator = scenarioContext.ScenarioContainer.Resolve<Navigator>();
            _homePage = new HomePage(_navigator.Page);
        }

        [Given(@"an anonymous user got to home page")]
        public async Task GivenAnAnonymousUser()
        {
            await _homePage.NavigateAsync();
        }

        [When(@"the user adds ""([^""]*)"" to the todo list using the webUI")]
        public async Task WhenGoToTodoItemsHomePage(string item)
        {
            await _homePage.AddTodoItem(item);
        }

        [Then(@"card ""([^""]*)"" should be displayed on the webUI")]
        public async Task ThenCardShouldBeDisplayedOnTheWebUI(string item)
        {
            await _homePage.AssertTodoListContains(item);
        }
    }
}
