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
	Given I have board NewGame
	When the red player moves the piece at e1 to e9 
	Then the action fails
	When the red player moves the piece at e1 to i1
	Then the action fails
	When the red player moves the piece at e1 to a1
	Then the action fails
	When the red player moves the piece at f1 to f8
	Then the action fails
	When the red player moves the piece at f1 to a2
	Then the action fails
	When the red player moves the piece at d1 to i2 
	Then the action fails
	When the red player moves the piece at d1 to d8
	Then the action fails

Scenario: Blue Cannot Move Through Blue Wall
	Given I have board NewGame
	When the blue player moves the piece at e9 to e1
	Then the action fails
	When the blue player moves the piece at e9 to e5
	Then the action fails
	When the blue player moves the piece at e9 to a5
	Then the action fails
	When the blue player moves the piece at f8 to f1
	Then the action fails
	When the blue player moves the piece at f8 to a4
	Then the action fails
	When the blue player moves the piece at d8 to d1
	Then the action fails
	When the blue player moves the piece at d8 to i4
	Then the action fails

Scenario: Cannot Depart Edge Of Board
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12E12k3H2+		   |
	|B:B5+E78k9F78 		   |
	When the red player moves the piece at h2 two points to the northeast
	Then the action fails


Scenario: Can Capture Enemy Piece
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12E12k3F24+		   |
	|B:D5+7E78k9F78		   |
	When the red player moves the piece at f4 two points to the northwest
	Then there should be a red two-stack on d5
	And there should not be any blue pieces on d5


Scenario: Cannot Capture Own Piece
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12E12k3F24+		   |
	|B:D5+7E78k9F78		   |
	When the red player moves the piece at f4 two points to the south
	Then the action fails

Scenario: Cannot Move Onto Block
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12E12k3F24+		   |
	|B:D5+7E78k9F78		   |
	|X:E5G3			   |
	When the red player moves the piece at f4 to e5 
	Then the action fails
	Given the current turn is BlueAction1
	When the blue player moves the piece at d5 to e5
	Then the action fails

Scenario: Cannot Move Over Block
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12E12k3F24+		   |
	|B:D5+7E78k9F78		   |
	|X:E5G3			   |
	When the red player moves the piece at f4 two points to the northwest 
	Then the action fails
	
Scenario: Move Through Wall Is Assumed If Possible
	# Moves are given as from-location to-target, not as a direction.
	# A 3-stack or larger could indicate a move which could be completed in two ways:
	# Through the wall, or not through the wall.  This test confirms the game will
	# assume, given both possibilities, that the player chose to move through the wall
	# and gain a blessing if possible.

	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B=E8 |
	|R:D12E12k3H4+++	   |
	|B:B3+++D8E8k9F78	   |
	|X:E5F6G3		   |
	When the blue player moves the piece at b3 to b5
	Then there should be a blue four-stack with a blessing on b5
	
