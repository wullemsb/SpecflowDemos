Feature: SpecflowDemos
	Show some SpecFlow features

Scenario: Using tables
	Given I have the following persons
	| FirstName | LastName |
	| Bart      | Wullems  |
	| Gill      | Cleeren  |
	When I search for Gill
	Then the following person should be returned
	| FirstName | LastName |
	| Gill      | Cleeren  |
