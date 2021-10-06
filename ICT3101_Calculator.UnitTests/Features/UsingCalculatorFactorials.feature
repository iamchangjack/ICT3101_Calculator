Feature: UsingCalculatorFactorials
	Simple calculator for finding factorial of a number

@mytag
Scenario: Factorialize a number
	When I have entered "4" in the calculator and press factorial
	Then the factorial result should be "24"

Scenario: Factorialize a zero
	When I have entered "0" in the calculator and press factorial
	Then the factorial result should be one
