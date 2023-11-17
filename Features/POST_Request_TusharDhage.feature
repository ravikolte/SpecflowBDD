   Feature: POST Request TusharDhage
   Post - Create a user and validate the response with the input provided
   
    Scenario: Create a user and validate the response
        Given the user sends a post request with end point as "/api/users"
        Then the user should get a success response
      #  Then I print the created user details
