@UAT @REGRESSION
Feature: Design a simple calculator
	I want to use a simple calculator
	So I can perform simple
	Mathematical operations

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press the add button
	Then the result should be 120 on the screen

Scenario: Add three numbers
	Given I have entered 10 into the calculator
	And I have entered 40 into the calculator
	And I have entered 20 into the calculator
	When I press the add button
	Then the result should be 70 on the screen

Scenario: Subtract two numbers
	Given I have entered 50 into the calculator
	And I press the subtract button
	And I have entered 20 into the calculator
	Then the result should be 30 on the screen