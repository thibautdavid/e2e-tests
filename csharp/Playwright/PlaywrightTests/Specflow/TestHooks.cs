using BoDi;
using Microsoft.Playwright;
using PlaywrightTests.Specflow.PageObjects;
using TechTalk.SpecFlow;

namespace PlaywrightTests.Specflow
{
    [Binding]
    internal class TestHooks 
    {
        [BeforeScenario]
        public async Task BeforeScenario(IObjectContainer container)
        {
            var playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });

            var context = await browser.NewContextAsync(null).ConfigureAwait(false);
            var page = await context.NewPageAsync().ConfigureAwait(false);

            var navigator = new Navigator(page);
            container.RegisterInstanceAs(playwright);
            container.RegisterInstanceAs(browser);
            container.RegisterInstanceAs(navigator);
        }

        [AfterScenario]
        public async Task AfterScenario(IObjectContainer container)
        {
            var browser = container.Resolve<IBrowser>();
            await browser.CloseAsync();
            var playwright = container.Resolve<IPlaywright>();
            playwright.Dispose();
        }
    }
    internal class Navigator
    {
        public Navigator(IPage page) {
            Page = page;
        }

        public IPage Page;
        public async Task Goto(PageObjectBase pageObject)
        {
            await pageObject.NavigateAsync();
        }
    }
}
