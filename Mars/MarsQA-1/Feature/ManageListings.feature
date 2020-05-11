Feature: ManageListings
	In order to manage listings
	I want to edit, edit the service listings

@mytag
Scenario: Check if the user is able to edit Manage listings
	Given I have clicked manage listings Edit button
	And I filled all the details in ShareSkills page
	When I press Save 
	Then the user should be able to save and navigated to the Manage listings page 

@mytag
Scenario: Check if the user is unable to Delete Manage listings by clicking NO button
	Given I have clicked manage listings Delete button
	When I press No button 
	Then the user should be navigated to the Manage listings page without deleting 

@mytag
Scenario: Check if the user is able to Delete Manage listings by clicking Yes button
	Given I have clicked the manage listings Delete button
	When I press Yes button 
	Then the user should be able to delete the Service list

