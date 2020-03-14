Feature: CRUDScenario
	Checks the CRUD scenario of computer database site

@Firefox
Scenario Outline: 1 Validate that User can add a new computer name in the database
	Given User access the computer database site
	When User clicks the Add a new computer button
	And fill all the fields in form <Computername>, <IntroducedDate>, <DiscontDate>, <Company>
	Then User should see that the <Computername> list has been <modified>
	Examples:
	| Computername | IntroducedDate | DiscontDate | Company | modified |
	| AAA-793-AC@  | 2020-03-11     | 2021-03-11  | IBM       | add      |

@Firefox
Scenario Outline: 2 Validate that the user can view the searched computer name
	Given User access the computer database site
	When User searches for an existing <Computername>
	Then User should be able to view the <Computername>
	Examples: 
	| Computername  |
	| AAA-793-AC@   |

@Firefox
Scenario Outline: 3 Validate that the user can update the details of an existing computer name
	Given User access the computer database site
	When User searches for an existing <Computername>
	And User updated the <Computername>, <IntroducedDate>, <DiscontDate>, <Company> value
	Then User should see that the <Computername> list has been <modified>
	Examples: 
	| Computername | IntroducedDate | DiscontDate | Company | modified |
	| AAA-793-AC@  | 2020-03-11     | 2021-03-11  | Canon       | update   |

@Firefox
Scenario Outline: 4 Validate that the user can delete a record
	Given User access the computer database site
	When User searches for an existing <Computername>
	And User delete an <Computername> record
	Then User should see that the <Computername> list has been <modified>

	Examples:
	| Computername| modified |
	| AAA-793-AC@ | delete   |

@Firefox
Scenario Outline: 5 Validate that user will not be able to add a record if date format is incorrect
	Given User access the computer database site
	When User clicks the Add a new computer button
	And fill all the fields in form <Computername>, <IntroducedDate>, <DiscontDate>, <Company>
	Then User will not be able to add the record
	Examples:
	| Computername | IntroducedDate | DiscontDate | Company |
	| AAA-123      | 2025-23-11     | 2026-00-11  |  RCA    |