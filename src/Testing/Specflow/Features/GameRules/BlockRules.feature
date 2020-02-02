Feature: Block Rules
	As a player, I should be able to place a block anywhere that is not a player home space,
	does not contain a piece, and is not adjacent to another block.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Block Happy Path
	Given I have board NewGame
	When the red player blockades A1
	Then the action succeeds
	And the board has blocks matching: A1

Scenario: Block Maximum
	Given I have an empty E2 E8 board
	When the following moves are performed:
	| RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
	| Bd2        | Bf2        | Be1         | Be9         |
	| Bd7        | Bf7        | Bb6         | Bc5         |
	| Ba4        | Bg5        | Bh6         | Bi4         |
	| Bg3        | Bh1        | Bi2         | Bc3         |
	| Bb1        | Ba2        | Be6         | Be4         |
	Then the board has blocks matching: A24B16C35D27E1469F27G35H16I24
		   
Scenario: Cannot Block Home Space
	Given this test isn't written yet


Scenario: Cannot Block Adjacent Another Block
	Given this test isn't written yet


Scenario: Cannot Block Occupied Space
 	Given this test isn't written yet
