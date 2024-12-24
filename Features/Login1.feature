Feature: Login1

A short summary of the feature

@sanity
Scenario:	Verify the login function
	Given User opens the website
	When User enters "<name>" , "<email>" , "<password>" , "<gender>" , "<dob>"
	And User clicks on submit button
	Then User detail form is submited

Examples: 
| name | email         | password | gender | dob         |
| ram  | ram@gmail.com | abc      | Male   | 15-12-2025  |
| sia  | sia@gmail.com | xyz      | Female | 20-12-2025  |

