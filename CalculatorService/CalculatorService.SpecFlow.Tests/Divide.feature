Feature: Divide
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the quotient of two numbers

Scenario Outline: Divide two numbers
	Given values <value1> and <value2>
	When I divide the first value by the second value
	Then the result should be <result>

Examples: 
| value1 | value2 | result |
| 1      | 1      | 1      |
| 5      | 2      | 2.5    |
