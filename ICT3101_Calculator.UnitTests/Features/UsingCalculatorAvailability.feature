Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
	When I have entered "100" and "5" into the calculator and press MTBF
	Then the MTBF result should be "105"

@Availability
Scenario: Calculating Availability
	When I have entered "100" and "5" into the calculator and press Availability
	Then the availability result should be "0.952"

@Availability
Scenario: Calculating Availability with empty MTTF
	When I have entered "0" and "5" into the calculator and press Availability
	Then the availability result should be zero