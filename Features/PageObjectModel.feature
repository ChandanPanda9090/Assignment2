Feature: PageObjectModel

Login page in eShopOnWeb



@tag1
Scenario: LoginPage

	Given I lunch the application
	When click on login button  
	When  Enter the login details  'admin@microsoft.com' and 'Pass@word1'	
	And Navigate to home
	And Add item
	



#@Login
#Scenario: Invalid LoginPage
#	Given Enter Login Page
#	When Enter invalid Email id
#	When Enter invalid password
#	When click on login button	
#	Then Varify payment
