Feature: ManagrRequests
	In order to ManageRequests
	I want tonavigate to received Requests and Sent Requests page

@mytag
Scenario: Check if the user is able to manage Received Requests Page
	Given I have Clicked Manage Requests tab
	And I have clicked Received Requests
	Then the user should be able to navigate to Received Requests page 


@mytag
Scenario: Check if the user is able to manage Sent Requests Page
	Given I have Clicked the Manage Requests tab
	And I have clicked Sent Requests link
	Then the user should be able to navigate to the Received Requests page 
