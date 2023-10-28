Feature: REST API Testing PATCH
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify PATCH Request
        Given the user sends a patch request with end point as "/api/users/2"
        Then the data should be updated using patch request


