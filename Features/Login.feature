Feature: Login into the application

@login
Scenario: Login validation using valid credentials
	Given Given I am on the login page
	And I enter username "Admin"
	Then I enter password "admin123"
	And click on login button