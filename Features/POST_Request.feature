Feature: REST API Testing POST
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify POST Request
        Given the user sends a post request with end point as "/api/users"
        Then the user should get a success response


