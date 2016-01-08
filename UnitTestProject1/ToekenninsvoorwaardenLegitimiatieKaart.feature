Feature: ToekenninsvoorwaardenLegitimiatieKaart
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	As a possible rechthebbende 
	when under 52 years old and having worked 200 days
	I have to receive a LegitimatieKaart

@mytag
Scenario: Check Toekenningsvoorwaarden
	Given I am under 52 years old
	And I have worked 200 days
	When I check the Toekenningsvoorwaarden
	Then I should receive a LegitimatieKaart
