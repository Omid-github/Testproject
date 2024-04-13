Feature: Login
          login Scenarios for Sadad portal 


@LoginSuccessfuly
Scenario: Successful Login

    Given The user enters valid credentials as following: 
	  |username		    | password		|
	  |controlpanel	    | portal@1234	|
	 
	When  The user clicks on Enter 
	Then  The user should be Navigated to the homepage

	   


@invalidCredentials
Scenario: Unsuccessful Login with invalid credentials

    When The user enters invalid username <username> And password <password> 
	 |username		| password		|
	 |test      	| portal@1234   |
	 |controlpanel  | 1234          |
    Then  The user should not be successfully logged in
	
  
  
@EmptyCredentials
 Scenario: Unsuccessful Login with empty credentials

    Given A user enters no credentials
	When  A user clicks on Enter
	Then  A User should not be successfully logged in
	And   A User should see an error 

