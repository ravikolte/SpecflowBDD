Feature: REST API Testing GET
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify GET Request
        Given the user sends a get request with end point as "/api/users?page=2"
        Then the response status code should be 200s


