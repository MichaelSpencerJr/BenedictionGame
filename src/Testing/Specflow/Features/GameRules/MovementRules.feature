Feature: Movement Rules
	As a player, I should see that movement rules are applied correctly.  Movement in
	the first of a player's two turns locks the piece so it cannot be moved on that player's
	second of two turns, though it can be split and merged.  Movement cannot wrap around
	through the player's own wall or pass through a block.  Movement cannot capture a
	piece of your own color, though it can capture an opponent piece.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |


Scenario: Repeat Moves Not Allowed
	Given I have board NewGame
	When the red player moves the piece at e3 to e4
	Then the action succeeds
	When the red player moves the piece at e4 to e5
	Then the action fails


Scenario: Red Cannot Move Through Red Wall
	Given this test isn't written yet


Scenario: Blue Cannot Move Through Blue Wall
	Given this test isn't written yet


Scenario: Cannot Depart Edge Of Board
	Given this test isn't written yet


Scenario: Can Capture Enemy Piece
	Given this test isn't written yet


Scenario: Cannot Capture Own Piece
	Given this test isn't written yet


Scenario: Cannot Move Onto Block
	Given this test isn't written yet


Scenario: Cannot Move Over Block
	Given this test isn't written yet


Scenario: Move Through Wall Is Assumed If Possible
	# Moves are given as from-location to-target, not as a direction.
	# A 3-stack or larger could indicate a move which could be completed in two ways:
	# Through the wall, or not through the wall.  This test confirms the game will
	# assume, given both possibilities, that the player chose to move through the wall
	# and gain a blessing if possible.

	Given this test isn't written yet
