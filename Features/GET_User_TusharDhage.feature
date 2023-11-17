Feature: GET User Tushar Dhage
Get - the list of users and print their email addresses
Get - single user and print all the details

  Scenario: Retrieve list of users and print email addresses
    Given the user sends a get request with end point as "/api/users?page=2"
    Then the response status code should be 200s
    Then I print the email addresses
  
   Scenario: Get single user and print all details
    Given the user sends a get request with end point as "/api/users?page=2"
    Then the response status code should be 200s
    And I print the user details