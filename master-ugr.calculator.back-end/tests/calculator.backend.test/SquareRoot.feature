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
	| 2      | 1.41421356237     |
	| 4      | 2     |
	| 9      | 3     |
	| 10     | 3.16227766017     |
	| 16     | 4     |