// import expect for assertion
const { expect } = require("@playwright/test");

exports.TodoPage = class TodoPage {
  /**
   * @param {import('@playwright/test').Page} page
   */
  constructor(page) {
    this.page = page;
    this.url = "https://demo.playwright.dev/todomvc";
    this.todoInput = page.locator(".new-todo");
    this.header = page.getByRole("heading", { name: "todos" });
  }

  async goto() {
    await this.page.goto(this.url);
    this.failFast();
  }

  failFast() {
    expect(this.header).toBeVisible();
  }

  async addTodoItem(item) {
    const newTodo = page.getByPlaceholder("What needs to be done?");

    // Create 1st todo.
    await newTodo.fill(item);
    await newTodo.press("Enter");
  }

  async assertTodoListContains(item) {
    await expect(this.page.getByTestId("todo-title"),"plouf").toHaveText([item+"3"]);
  }
};
