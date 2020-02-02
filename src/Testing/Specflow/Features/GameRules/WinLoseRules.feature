Feature: Win Lose Rules
	As a player, I should see win and loss conditions applied correctly.  I should win
	when a king piece of mine becomes blessed, though not when a blessed piece of mine
	becomes a king.  I should lose if one of my king pieces is captured.  I should lose
	if I am unable to make a move.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Red King Passing Blue Wall Causes Red Win
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12I5k          |
	| B:D78E78k9F78             |
	When the red player moves the piece at i5 to a1
	Then the action succeeds
	And the game is over and red has won


Scenario: Blue King Passing Red Wall Causes Blue Win
	Given this test isn't written yet


Scenario: Red Capturing Any Blue King Causes Red Win
	Given this test isn't written yet


Scenario: Blue Capturing Any Red King Causes Blue Win
	Given this test isn't written yet


Scenario: Red Forming Chain With King Causes Red Win
	Given this test isn't written yet


Scenario: Blue Forming Chain With King Causes Blue Win
	Given this test isn't written yet


Scenario: Red Joining King To Existing Chain Causes Red Win
	Given this test isn't written yet


Scenario: Blue Joining King To Existing Chain Causes Red Win
	Given this test isn't written yet


Scenario: Red Moving Blessed Piece Onto Red Home Does Not Cause Win
	Given this test isn't written yet


Scenario: Red Moving Blessed Piece Onto Blue Home Does Not Cause Win
	Given this test isn't written yet


Scenario: Blue Moving Blessed Piece Onto Red Home Does Not Cause Win
	Given this test isn't written yet


Scenario: Blue Moving Blessed Piece Onto Blue Home Does Not Cause Win
	Given this test isn't written yet


Scenario: Red With No Legal Moves Causes Blue Win
	Given this test isn't written yet


Scenario: Blue With No Legal Moves Causes Red Win
	Given this test isn't written yet

