Feature: Home
	Business scenarios for The Internet app home page

Background: 
	Given I have opened home page

@regression
Scenario: Home page title
	Then Home page title is 'The Internet'

@regression
Scenario: Home page welcome header
	Then Welcome header is 'Welcome to the-internet'

@regression
Scenario: Home page links header
	Then Links header is 'Available Examples'

@regression
Scenario: Opening A/B Testing link
	When I click on 'A/B Testing' link
	Then 'abtest' page has been opened