Feature: ToekenninsvoorwaardenLegitimiatieKaart
	As a possible rechthebbende 
	when under 52 years old and having worked 200 days
	I have to receive a LegitimatieKaart

Scenario Outline: Check Toekenningsvoorwaarden
	Given I am <age> years old
	And I have worked <workedDays> days
	When I check the Toekenningsvoorwaarden
	Then the result should be <result>

  Examples:
    |  age  | workedDays | result |
	|  51   |  200       |  true  |
    |  51   |  199       |  false |
    |  52   |  175       |  true  |
    |  52   |  174       |  false |
    |  52   |  170       |  false |
