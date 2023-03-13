using Microsoft.Playwright;

namespace Cea.Tmma.UiTests.Core
{
    public class Navigator
    {
        public Navigator(IPage page)
        {
            Page = page;
        }

        public IPage Page;
        public async Task Goto(PageObjectBase pageObject)
        {
            await pageObject.NavigateAsync();
        }
    }
}
