﻿Feature: Provision Gap - Who is the Employer page - Error Messages
	This feature is used to confirm the error messages on the Who is the Employer page. 

Background: 
	Given I have navigated to the IDAMS login page
	And I have logged in as an "Admin User"
	And I navigate to Who is the employer page Provision Gap with unknown Number of students

@regression
Scenario: ProvisionGap_Who is the employer - Press continue without entering any data
	When I enter no Employer business name and Continue
	Then the Who is the employer page will show an error stating "You must find and choose an employer"
	