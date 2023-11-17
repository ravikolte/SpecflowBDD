Feature: Patch Update User Tushar Dhage
Patch - Update the user and validate the changes with the response

  Scenario: User wants to patch update a user
    Given the user wants to patch update a user with end point as "/api/users/2"
    Then the user should get a success response with patched user details
