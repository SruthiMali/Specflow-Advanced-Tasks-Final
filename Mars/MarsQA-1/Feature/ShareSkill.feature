Feature: ShareSkill
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check if the user is able to add a service in ShareSkills page 
	Given I Clicked on Shareskills button 
	And I have entered all the details
	When I press Save button 
	Then User should be navigated to Manage Requests Page
