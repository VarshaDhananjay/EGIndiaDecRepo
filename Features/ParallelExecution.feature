Feature: ParallelExecution


Implement parallel execution on different browser
@tag1
Scenario: Verify parallel execution of the tests on chrome browser
	Given user is on the application page of chrome browser

Scenario: Verify parallel execution of the tests on FF browser
	Given user is on the application page of firefox browser

Scenario: Verify parallel execution of the tests on edge browser
	Given user is on the application page of edge browser
	
