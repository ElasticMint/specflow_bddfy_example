Feature: Subtract
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the difference between two numbers


Scenario Outline: Subtract two numbers
	Given values <value1> and <value2>
	When I subtract the second value from the first value
	Then the result should be <result>

Examples: 
| value1 | value2 | result |
| 1      | 1      | 0      |
| 3.2    | 2.3    | 0.9    |
| 5.5    | 6.6    | -1.1   |
