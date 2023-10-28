Feature: Test table specflow


@nonui
Scenario: Test data fill
    Given Fill the data
	| Ravi    | rk@cybtest.com |
	| Tushar  | td@cybtest.com |
	| Datta   | dp@cybtest.com |

@nonui
Scenario: Basic date time example for Step Argument Transformation
    Given print 2 days from current date
	Then  printt 3 days from current datee
   

