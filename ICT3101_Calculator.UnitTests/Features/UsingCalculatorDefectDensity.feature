Feature: UsingCalculatorDefectDensity
	Calculating defect density

@DefectDensity
Scenario: Calculating Defect Density
	When I have entered "100" and "50" into the calculator and press Defect Density
	Then the Defect Densitiy should be "2"