Feature: REST API Testing DELETE
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify DELETE Request
        Given the user sends a delete request with end point as "/api/users/2"
        Then the validate the response code for delete request


