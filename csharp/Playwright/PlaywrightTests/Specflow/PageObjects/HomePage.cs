using Microsoft.Playwright;

namespace PlaywrightTests.Specflow.PageObjects
{
    internal class HomePage : PageObjectBase
    {
        public HomePage(IPage page) : base(page) { }

        public override string PagePath => "https://demo.playwright.dev/todomvc";

        internal async Task AddTodoItem(string item)
        {
            var newTodo = _page.GetByPlaceholder("What needs to be done?");

            // Create 1st todo.
            await newTodo.FillAsync(item);
            await newTodo.PressAsync("Enter");
        }

        internal async Task AssertTodoListContains(string item)
        {
            await Assertions.Expect(_page.GetByTestId("todo-title")).ToContainTextAsync(item);
        }
        
        internal async Task AssertTodoListContains2(string item)
        {
            await Assertions.Expect(_page.GetByTestId("todo-title")).ToContainTextAsync(item);
        }
    }
}
