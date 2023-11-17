Feature: PUT Request TusharDhage
Put - Update the user and validate the changes with the response

    Scenario: User wants to update a user
    Given the user wants to update a user with end point as "/api/users/2"
    Then the user should get a success response with updated user details