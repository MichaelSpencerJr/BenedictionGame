Feature: Drop Rules
	As a player, I should only be able to drop new pieces in my own zone.
	I should not be able to drop onto an existing piece or onto a block.
	If I drop a piece onto my home space, the dropped piece should become a king.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Drop Happy Path
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	Then the action succeeds
	When the red player drops a new piece at e3
	Then the action succeeds


Scenario: Cannot Drop Outside Zone
	Given I have board NewGame
	When the red player drops a new piece at e5
	Then the action fails


Scenario: Cannot Drop Onto Block
	Given I load this board:
    | Board                     |
    | Benediction v1: R-E2 B E8 |
	| R:D12E12kF12              |
	| B:D78E78k9F78             |
    | X:E3                      |
	When the red player drops a new piece at e3
	Then the action fails

Scenario: Cannot Drop Onto Occupied Space
	Given I have board NewGame
	When the red player drops a new piece at e3
	Then the action fails


Scenario: Home Drop Becomes King
	Given I load this board:
    | Board                     |
    | Benediction v1: R-E2 B E8 |
    | R:D12E13kF12             |
	| B:D78E78k9F78             |
	When the red player drops a new piece at e2
	Then the action succeeds
	And the board has red pieces matching: D12E12k3kF12


