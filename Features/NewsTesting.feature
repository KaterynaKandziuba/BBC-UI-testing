Feature: NewsTesting
	As a guest
	I want to see articles on the BBC website in correspondence with a timeline
	In order to read the actual news

@critical_pathS
Scenario: Verify that the name of the headline article corresponds to the required
	Given the website is opened on the main page
	When I click on the News tab
	And I close emerged Sign-in popup
	Then I check headline article against "Portland suspect shot dead by police during arrest"

Scenario: Verify that secondary article titles presented on the page in accordance with the declared in the database
	Given the website is opened on the main page
	When I click on the News tab
	And I close emerged Sign-in popup
	Then I check secondary article titles against Titles
	| Titles                                                      |
	| Cardinal forced out in rare Vatican resignation             |
	| Two hurt in stabbing near Charlie Hebdo office              |
	| White US professor says she lied about being black          |
	| David Blaine takes flight holding helium baloons            |

Scenario: Verify that the name of the first article in the regional news search list corresponds to the required
	Given the website is opened on the main page
	When I click on the News tab
	And I close emerged Sign-in popup
	And I store the text of the Category link of the headline article to enterin the Search bar
	Then I check the name of the first article in the list against "Americans, go home: Tension at Canada-US border"

