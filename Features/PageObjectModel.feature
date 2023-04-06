Feature: PageObjectModel

Login page in eShopOnWeb

@Login
Scenario: LoginPage
	Given Enter Login Page
	When Enter login Userid and Pasword
	And Navigate to home
	And  Navigate to details
	Then Varify payment
