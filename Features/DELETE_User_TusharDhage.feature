Feature: Delete User Tushar Dhage
Delete a user and validate the response code

  Scenario: User wants to delete a user
    Given the user wants to delete a user with end point as "/api/users/2"
    Then the user should get a success response with status code 204
