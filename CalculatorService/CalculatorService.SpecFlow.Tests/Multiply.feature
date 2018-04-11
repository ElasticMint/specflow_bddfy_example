Feature: Multiply
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the product of two numbers


Scenario Outline: Multiple two numbers
	Given values <value1> and <value2>
	When I multiply the values
	Then the result should be <result>

Examples: 
| value1 | value2 | result |
| 1      | 1      | 1      |
| 3.2    | 2.3    | 7.36   |
| 5.5    | -2     | -11    |
