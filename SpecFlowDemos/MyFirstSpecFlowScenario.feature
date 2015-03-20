Feature: MyFirstSpecFlowScenario
	SpecFlow Samples

Scenario Outline: Add two positive numbers
	Given I have entered <number 1> into the calculator
	And I have entered <number 2> into the calculator
	When I press add
	Then the result should be <result> on the screen

Examples:
	| number 1 | number 2 | result |
	|   10      |     20     | 30       |
	|     20     |  20        |    40    |
	|   20       |    30      |     50   |
	|    1000      |     10     |      1010  |