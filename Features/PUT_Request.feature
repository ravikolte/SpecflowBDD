Feature: REST API Testing PUT
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify PUT Request
        Given the user sends a put request with end point as "/api/users/2"
        Then the data should be updated using put request


