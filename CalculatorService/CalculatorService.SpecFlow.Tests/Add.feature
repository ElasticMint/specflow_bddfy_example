Feature: Add
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario Outline: Add two numbers
	Given values <value1> and <value2>
	When I add the values
	Then the result should be <result>

Examples: 
| value1 | value2 | result |
| 1      | 1      | 2      |
| 1.2    | 2.3    | 3.5    |
