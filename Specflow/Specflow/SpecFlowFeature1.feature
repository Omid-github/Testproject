Feature: Login

  Scenario: Login successful
    
    Given the <username> and <password> are provided
    When I click on submit or enter
    Then login should be sucessfull 
	And  I navigate to the home page



	
	
	
Examples:

	| username     | password    | 
	| controlpanel | portal@1234 | 