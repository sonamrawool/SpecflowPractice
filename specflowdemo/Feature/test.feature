@All
Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Sanity @Regression
Scenario Outline: Login
	Given I am on the login page
	And I have entered <Username> and <Password>
	When I click on the Login button
	Then it should open the page
	Examples:
	| Username | Password |
	| Tester | test |
	| Tester | test |

@Regression
Scenario: View Order
	Given I login
	When I am on the website
	Then i can view orders


