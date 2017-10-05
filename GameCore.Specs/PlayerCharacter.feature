Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly representeds

Background: 
	Given I'm a new player

Scenario Outline: Health reduction
	When I take <damage> damage
	Then My health should now be <expectedHealth>

Examples: 
		| damage | expectedHealth |
		| 0      | 100            |
		| 40     | 60             |
		| 50     | 50             |

#Scenario: Taking no damage when hit doesn't affect healths
#	Given I'm a new player
#	When I take 0 damage
#	Then My health should now be 100
#	
#Scenario: Starting healthy is reduced when hit
#	Given I'm a new player
#	When I take 40 damage
#	Then My health should now be 60
#	
Scenario: Taking too much damage results in player death
	When I take 100 damage
	Then I should be dead


Scenario: Alf race characters get additional 20 damage resistance
	And I have a damage resistance of 10
	And I'm an Elf
	When I take 40 damage
	Then My health should now be 90

Scenario: Alf race characters get additional 20 damage resistance using data table
	Given I'm a new player
		And I have the following attributes
		| attribute  | value |
		| Race       | Elf   |
		| Resistance | 10    |
		When I take 40 damage
		Then My health should now be 90
