Feature: Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check if the user is able to Add Description
	Given I Added Description
	Then that desccription should appear in profile page

@mytag
Scenario: Check if the user is able to Edit Description
	Given I Edited Description
	Then that desccription should appear in the profile page

	
@mytag
Scenario: Check if the user is able to Change Password
	Given I Changed Password
	Then User should be able to Login with new Password


