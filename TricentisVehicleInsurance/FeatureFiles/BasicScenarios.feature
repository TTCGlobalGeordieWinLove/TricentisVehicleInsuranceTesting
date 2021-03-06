﻿Feature: BasicScenarios
	Testing opening of the webpage

@mytag
Scenario: Open Insurance Quote Form
	Given User opens browser to Insurance Webpage
		And User clicks Automobile insurance link
	Then The first page of the quote form is displayed

Scenario Outline: User Enters Vehicle Data
	Given User opens browser to Insurance Webpage
		And User clicks Automobile insurance link
	When User enters Make "<Make>"
		And User enters Engine Performance "<Performance>"
		And User enters Date of Manufacture "<Date>"
		And User enters Number of Seats "<Seats>"
		And User enters Fuel Type "<Fuel>"
		And user enters List Price "<Price>"
		And user enters License Plate Number "<LicensePlate>"
		And user enters Mileage "<Mileage>"
	Then No fields are marked as invalid
Examples: 
	| Make | Performance | Date       | Seats | Fuel | Price | LicensePlate | Mileage |
	| Audi | 120         | 01/01/2010 | 2     | Gas  | 30000 | W2312GF      | 20000   |
	| BMW  | 120         | 01/01/2010 | 2     | Gas  | 30000 | W2312GF      | 20000   |

Scenario Outline: User Enters valid and invalid mileage
	Given User opens browser to Insurance Webpage
		And User clicks Automobile insurance link
	When user enters Mileage "<Mileage>"
	Then An error "<Should>" be displayed
Examples:
	| Mileage | Should |
	| 3000    | false  |
	| 50      | true   |
	| 200000  | true   |