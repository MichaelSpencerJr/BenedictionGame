@every-change
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

@scenario-image-only
Scenario: Block Maximum
	Given I have an empty E2 E8 board
	When the following moves are performed:
	| RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
	| Be9        | Bb6        | Bd7         | Bf7         |
	| Bh6        | Ba4        | Bc5         | Be6         |
	| Bg5        | Bi4        | Bb3         | Bd4         |
	| Bf4        | Bh3        | Ba1         | Bc2         |
	| Be3        | Bg2        | Bi1         | Bd1         |
	| Bf1        |            |             |             |
	Then the board has blocks matching: A14B36C25D147E369F147G25H36I14
		   
Scenario: Cannot Block Home Space
	Given I have an empty E2 E8 board
	When the red player blocks e2
	Then the action fails
	When the red player blocks e8
	Then the action fails

Scenario: Cannot Block Adjacent Another Block
	Given I have an empty E2 E8 board
	When the red player blocks e3
	Then the action succeeds
	When the red player blocks e4
	Then the action fails
	And the board has blocks matching: E3


Scenario: Cannot Block Occupied Space
	Given I have board NewGame
	When the red player blockades e3
	Then the action fails

Scenario Outline: Wrap-Around Block
	Given I have an empty E2 E8 board
	When the red player blocks <First>
	Then the action succeeds
	When the red player blocks <Second>
	Then the action fails
	And the board has blocks matching: <First>

	Examples:
	| First | Second |
	| H6    | A2     |
	| A2    | H6     |