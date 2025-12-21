Feature: SquareRoot
	As Victor (the customer)
	I want to know the square root of a number
	So I can calculate the side of a square land


Scenario Outline: Calculate square root of a number
	When number <number> is calculated
	Then the value should be <result>
	Examples: 
	| number | result  |
	| 1      | 1	   |
	| 9      | 3     |