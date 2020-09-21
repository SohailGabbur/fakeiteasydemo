Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 20
	When the two numbers are substrated
	Then the result should be 30

Scenario: Multiply three numbers
	Given the first number is 5
	And the second number is 2
	And the third number is 10
	When the two numbers are multiply
	Then the result should be 100

Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are divide
	Then the result should be 5