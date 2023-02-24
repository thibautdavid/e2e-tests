const {Given, When, Then} = require('@cucumber/cucumber')
const { expect } = require("@playwright/test");

const { TodoPage } = require('../pageObjects/todoPage.js');

Given('a user has navigated to the homepage', async function () {
    const todoPage = new TodoPage(page);
    await todoPage.goto();
  });

  When('the user adds {string} to the todo list using the webUI', async function (item) {
    const todoPage = new TodoPage(page);
    await todoPage.addTodoItem(item);
  });

  Then('card {string} should be displayed on the webUI', async function (item) {
    const todoPage = new TodoPage(page);
    await todoPage.assertTodoListContains(item);
  });