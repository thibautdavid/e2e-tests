# language: fr

Fonctionnalité: todo
 As a user
 I want to add an item to the todo list
 So that I can organize tasks

 Scénario: Add item to the todo list
   Etant donnée a user has navigated to the homepage
   # this is a comment
   Quand the user adds "test" to the todo list using the webUI
   Alors card "test" should be displayed on the webUI