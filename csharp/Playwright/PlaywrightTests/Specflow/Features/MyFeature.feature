Feature: MyFeature

A short summary of the feature

@tag1
Scenario: Show todo home page
	Given an anonymous user got to home page
	When the user adds "test" to the todo list using the webUI
	Then card "test" should be displayed on the webUI
