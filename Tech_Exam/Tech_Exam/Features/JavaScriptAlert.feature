Feature: JSAlerts
	Checks the java script alerts

@GoogleChrome
Scenario Outline: Validate that user can click on the JS Alert
	Given User access the JavaScript alert site
	When User clicks the JS <alert>
	And User checks the <alert> message
	And User clicks the Ok button in the alert
	Then User should see a successful message for <alert> and <value> is displayed

	Examples:
	| alert   | value |
	| JSAlert | none  |

@GoogleChrome
Scenario Outline: Validate that user can click on the JS Confirm
	Given User access the JavaScript alert site
	When User clicks the JS <alert>
	And User checks the <alert> message
	And User clicks the Ok button in the alert
	Then User should see a successful message for <alert> and <value> is displayed

	Examples:
	| alert     | value |
	| JSConfirm | Ok    |

@GoogleChrome
Scenario Outline: Validate that user can click on the JS Prompt
	Given User access the JavaScript alert site
	When User clicks the JS <alert>
	And User checks the <alert> message 
	And User sends <value> to the alert box
	And User clicks the Ok button in the alert
	Then User should see a successful message for <alert> and <value> is displayed

	Examples:
	| alert    | value          |
	| JSPrompt | Confirm prompt |