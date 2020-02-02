Feature: Bridge Rules
	As a player, I should see bridge mechanics applied correctly.  Any contiguous
	collection of pieces of the same color touching both walls should have a
	blessing reapplied to every uncursed piece in the collection every turn.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Bridge Happy Path
	Given I load this board:
    | Board                     |
    | Benediction v1: R-E2 B E8 |
    | R:C2D13E12k4F124G4H4I45   |
    | B:A12B3C4D578E68k9F68G6   |
	When the red player moves the piece at d1 to c1
	Then the board has red pieces matching: C1b2bD3bE12k4bF124bG4bH4bI4b5b

Scenario: Bridge Maximum
	Given this test isn't written yet


Scenario: Bridge With Wrong Color Critical Piece
	Given this test isn't written yet


Scenario: Split Into Bridge Avoids All Curses If Split Pieces Adjacent
	Given this test isn't written yet


Scenario: Split Into Bridge Avoids Target Curse If Target Piece Adjacent
	Given this test isn't written yet


Scenario: Split Into Bridge Avoids Source Curse If Source Piece Adjacent
	Given this test isn't written yet


Scenario: Bridge Cannot Bless Cursed Pieces
	Given this test isn't written yet


Scenario: Home Drop Completing Bridge Wins Game
	Given this test isn't written yet


