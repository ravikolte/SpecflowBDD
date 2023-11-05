@UI
Feature: OrangeHRM

A short summary of the feature
Background: 
Given I navigate to OrangeHRM 
And I enter username "Admin"
Then I enter password "admin123"
And click on login button

@tag1
Scenario: HRM Employee Test_1
	
Given I click on PIM Tab
When I click on Add Emloyee tab
And I fill the Employee details
	| Firstname | Lastname |
	| Employee  | User     |
When I click on save button
Then I should see the new employee "Employee User" is created
When I click on Employee_list tab
Then I delete the created employee

@tag1
Scenario: HRM Admin Test_2
	
Given I click on Admin Tab
When I click on AddAdmin Button
And I fill the Admin details
	| EmployeeName | Username | Password | ConfirmPassword |
	| Vinayak      | admin    | admin123 | admin123        |
When I click on save button
#Then I should see the new employee "Admin" is created

@tag1
Scenario: HRM Leave Test_3
	
Given I click on Leave Tab
And I click on LeaveList menu
When I select Leave Status
And I click on Search button
Then I check the result

@tag1
Scenario: HRM Job Test_4
	
Given I click on Admin Tab
When I select JobTitle
When I click on AddJob button
And I fill the job details
	| JobTitle |
	| ABD      |
When I click on save button
Then I should see the new job "ABD" is created
And I delete the created job


@tag1
Scenario: HRM PIM Employee Test_5
	
Given I click on PIM Tab
When I click on Add Emloyee tab
And I fill the Employee details
	| Firstname | Lastname |
	| Vinayak   | User     |
When I click on save button
Given I click on PIM Tab
And I search the Employee details with "Vinayak"
When I click on Search button
Then I should see the new employee Name as "Vinayak" is created
And I delete the created employee
