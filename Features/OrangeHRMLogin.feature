Feature:Test OrangeHRMLogin functionality
//Background:
	Given user is in the login page(common steo can be put in the background)
@sanity
Scenario: Verify login for Orange HRM Website
	Given User is on the login page
	When User enters the correct credentials
	When User clicks on Login button
	Then User is navigated to homepage


Examples: 
	| user  | pass     |
	| Admin | admin123 |

@regression
Scenario: Verify Inavlid login for Orange HRM Website
	Given User is on the login page
	When User enters the incorrect credentials
	When User clicks on Login button
	Then User is displayed with error message

Examples: 
	| username  | password     |
	| ssjjsj	| vaahaha	   | 

@regression
Scenario Outline: Verify login with test parameters
	Given User enters the "<username>" and "<password>"
	When User clicks on login button
	When User is navigated to homepage
	Then User selects the city and country information
	|city   |country |
	|Delhi  |India   |
	|Boston |USA     |
Examples: 
	| username  | password |
	| tom	    | harry	   | 
	| jerry	    | mathew   | 