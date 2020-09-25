Feature: FormTesting
	In order to share news with the BBC
	As a guest
	I want to type a story and fill the personal data form

Background: 
	Given the website is opened on the main page
	* I click on the News tab
	* I close emerged Sign-in popup
	* I click on the Coronavirus tab
	* I click on Your Coronavirus Story tab

@critical_path
Scenario Outline: Verify that user can't submit a story to BBC without filling the Name field
	Given I click on Have Your Say tab
	When I fill the form and checkboxes
	| Key                    | Value                  |
	| 'Tell us your story. ' | <Tell us your story.>  |
	| 'Name'                 | <Name>                 |
	| 'Email address'        | <Email address>        |
	| 'Contact number '      | <Contact number>       |
	| 'Location '            | <Location >            |
	| Checkbox_1             | <Checkbox_1>           |
	| Checkbox_2             | <Checkbox_2>           |
	| Checkbox_3             | <Checkbox_3>           |
	And I press Submit button
	Then error occures
	
Examples: 
	| Tell us your story. | Name  | Email address   | Contact number | Location | Checkbox_1 | Checkbox_2 | Checkbox_3 |
	| Test                |       | vasya@gmail.com | 0987654321     | Kyiv     | press      | press      | press      |
	|                     | Vasya | vasya@gmail.com | 0987654321     | Kyiv     | press      | press      | press      |
	| Test                |       | vasya@gmail.com | 0987654321     | Kyiv     | press      | press      |            |
	
	