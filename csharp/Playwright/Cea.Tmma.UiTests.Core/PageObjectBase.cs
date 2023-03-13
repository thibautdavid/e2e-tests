using Microsoft.Playwright;

namespace Cea.Tmma.UiTests.Core
{
    public abstract class PageObjectBase
    {
        public abstract string PagePath { get; }

        protected readonly IPage _page;

        protected PageObjectBase(IPage page) => _page = page;

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(PagePath);
        }
    }
}
