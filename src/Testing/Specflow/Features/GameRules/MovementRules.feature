Feature: Movement Rules
	As a player, I should see that movement rules are applied correctly.  Movement in
	the first of a player's two turns locks the piece so it cannot be moved on that player's
	second of two turns, though it can be split and merged.  Movement cannot wrap around
	through the player's own wall or pass through a block.  Movement cannot capture a
	piece of your own color, though it can capture an opponent piece.


Scenario: Repeat Moves Not Allowed


Scenario: Red Cannot Move Through Red Wall


Scenario: Blue Cannot Move Through Blue Wall


Scenario: Cannot Depart Edge Of Board


Scenario: Can Capture Enemy Piece


Scenario: Cannot Capture Own Piece


Scenario: Cannot Move Onto Block


Scenario: Cannot Move Over Block


Scenario: Move Through Wall Is Assumed If Possible
	# Moves are given as from-location to-target, not as a direction.
	# A 3-stack or larger could indicate a move which could be completed in two ways:
	# Through the wall, or not through the wall.  This test confirms the game will
	# assume, given both possibilities, that the player chose to move through the wall
	# and gain a blessing if possible.