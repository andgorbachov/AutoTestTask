Feature: Order costs Calculations
	This feature file contains scenarios for Order costs Calculations functionality

Scenario Outline: 001 - Check Order costs calculation logic
	This scenario should check Order costs calculation logic

	Given A group of <people> people orders <starters> starters, <mains> mains and <drinks> drinks before 19-00 <before19>
	When The order is sent to the endpoint
	Then The <result> total is calculated correctly

Examples: 
        | people | starters | mains | drinks | before19 | result |
        | 4      | 4        | 4     | 4      | true     | 55.4   |
        | 4      | 4        | 4     | 4      | false    | 58.4   | 



Scenario Outline: 002 - Check Order costs calculation logic
	This scenario should check Order costs calculation logic

	Given A group of <people> people orders <starters> starters, <mains> mains and <drinks> drinks before 19-00 <before19>
	When A group of <people2> people orders <starters2> starters, <mains2> mains and <drinks2> drinks and before 19-00 <before192>
	And The order is sent to the endpoint
	Then The <result> total is calculated correctly

Examples: 
        | people | starters | mains | drinks | before19 | people2 | starters2 | mains2 | drinks2 | before192 | result |
        | 2      | 1        | 2     | 2      | true     | 2       | 0         | 2      | 2       | false     | 43.7   | 



Scenario Outline: 003 - Check Order costs calculation logic
	This scenario should check Order costs calculation logic

	Given A group of <people> people orders <starters> starters, <mains> mains and <drinks> drinks before 19-00 <before19>
	When A group of <people2> people orders <starters2> starters, <mains2> mains and <drinks2> drinks and before 19-00 <before192>
	And The order is sent to the endpoint
	Then The <result> total is calculated correctly

Examples: 
        | people | starters | mains | drinks | before19 | people2 | starters2 | mains2 | drinks2 | before192 | result |
        | 4      | 4        | 4     | 4      | true     | -1      | -1        | -1     | -1      | true      | 41.55  | 
        | 4      | 4        | 4     | 4      | false    | -1      | -1        | -1     | -1      | false     | 43.8   | 
