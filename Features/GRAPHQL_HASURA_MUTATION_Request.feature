Feature: GRAPHQL Testing MUTATION HASURA
    In order to verify the functionality of a REST API
    As a tester
    I want to make API requests and validate responses

    Scenario: Verify Mutation Request using GRAPHQLHASURA
        Given the user hits the graphql url for post request using hasura
        Then print the response and verify the response status code for graphql mutation


