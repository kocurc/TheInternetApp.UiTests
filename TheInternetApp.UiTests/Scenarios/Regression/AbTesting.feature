Feature: AbTesting

Background: 
Given I have opened Ab Testing page

@regression
Scenario: Default header
	Then Main header is 'A/B Test Control'

@regression
Scenario: Default paragraph
	Then Main paragraph is equal to main AbTesting paragraph from resources file