Feature: Book a Return Flight

Scenario: Book a return flight from a selected location
    Given I have the SkyScanner API endpoint
    When I send a POST request to book a return flight
    Then the response should have a status code of 200
    And the return flight should be booked successfully