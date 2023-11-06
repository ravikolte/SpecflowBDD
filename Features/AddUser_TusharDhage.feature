Feature: Add User Feature
    Verify that user can able to Add a user present inside the User management dropdown

    Background: Login into the application
        Given Given I am on the login page
        And I enter username "Admin"
        Then I enter password "admin123"
        And click on login button

    @login
    Scenario: Add employee inside user management tab
        When the user clicks on the Admin tab/option
        Then the Admin page is displayed
        When the user clicks on the option to create a new user
        Then the user is taken to the user creation page
        Then the user add username "Username" password "Password" and then confirm password "Confirm Password"
            | Field            | Value       |
            | Username         | TusharDhage |
            | Password         | admin123    |
            | Confirm Password | admin123    |
        Then clicks on the Save option
        Then a success popup is displayed
        When the page is refreshed
        Then a new user "TusharDhage" should be listed under the System Users page

    @login
    Scenario: Add employee present inside PIM tab
        When the user clicks on the PIM tab/option
        Then the user clicks on the add employee button
        Given the user is on the Add Employee page
        When the user fills firstname "FirstName" middlename "MiddleName" and lastname "LastName" under Add Employee
            | Field      | Value  |
            | FirstName  | Tushar |
            | MiddleName | A      |
            | LastName   | Dhage  |
        Then enables the Create login details option
        Then the user fills username "Username" password "Password" and then confirm password "Confirm Password"
            | Field            | Value       |
            | Username         | TusharDhage |
            | Password         | admin123    |
            | Confirm Password | admin123    |
        Then clicks the Save button
        Then a success popup is displayed
        When the page is refreshed
        Then a new employee "Tushar Dhage" should be created and listed in the Employee List page

    @Login
    Scenario: Search for an Employee and Navigate to Myinfo
        When the user clicks on the PIM tab/option
        Then I click on Employee List option
        Then Search employee should be created and listed in the Employee List page
        When the required details will be displayed under Employee List page
        When the page is refreshed
        Then it will route to Myinfo page

    @Login
    Scenario: User Creates a New Job Title
        When the user clicks on the Admin tab/option
        Then select the Job Title option from the Job dropdown
        Then fill jobTitle "JobTitle" jobDiscription "JD" and jobNote "Note" details on the Job Title page
            | Field    | Value                                                       |
            | JobTitle | QA Automation                                               |
            | JD       | We Test the application and find defects in the applciation |
            | Note     | QA Automation- Tushar Dhage                                 |
        Then clicks the Save button
        Then a success popup is displayed
        Then the newly created job title will be visible on the Job Title page after the page is refreshed.

# @Login
# Scenario: User Approves/Rejects Leave in Leave Tab
# Given click on the Leave tab in the left navigation
# When fill in all the required details on the Leave List page
# When click the Search button
# Then all the filtered records will be displayed
# Then the user can choose to Approve, Reject, or Cancel the leave request
# Then a Success pop-up will be displayed
# Then the necessary record will be removed from the Leave List page.














