Feature: Login Functionality

  Scenario: Successful login with correct credentials
    Given User is on the login page
    When User enters correct username and password
    And User clicks on the login button
    Then User should be logged in successfully

  Scenario: Unsuccessful login with incorrect credentials
    Given User is on the login page
    When User enters incorrect username or password
    And User clicks on the login button
    Then User should see an error message

  Scenario: Trying to login without entering password
    Given User is on the login page
    When User enters username but does not enter password
    And User clicks on the login button
    Then User should see a password required error message

  Scenario: Trying to login without entering username
    Given User is on the login page
    When User does not enter username but enters password
    And User clicks on the login button
    Then User should see a username required error message

  Scenario: Trying to login without entering any credentials
    Given User is on the login page
    When User does not enter any credentials
    And User clicks on the login button
    Then User should see both username and password required error messages