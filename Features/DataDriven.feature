Feature: Scenario Outline Data Driven Test Case 

@nonui
Scenario Outline: Add two numbers data-driven test cases using Scenario Outline
	Given the first number is <firstnumber>
	And the second number is <secondnumber>
	When the two numbers are added
	Then result should be <result>
Examples: 
    | firstnumber | secondnumber | r.esult |
    | 10          | 20           | 30      |
    | 20          | 30           | 50      |
    | 40          | 50           | 90      |
    | 1           | 1            | 2       |