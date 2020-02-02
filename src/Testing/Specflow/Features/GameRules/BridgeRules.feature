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
	Given I load this board:
	| Board                                   |
	| Benediction v1: R-E2 B E8               |
	| R:A14B245C246D468E2k468kF2467G246H24I23 |
	| B:E7k                                   |
	When the red player drops a new piece at d2
	Then the action succeeds
	And the game is over and red has won
	And the board has red pieces matching: A1b4bB2b4b5bC2b4b6bD2b4b6b8bE2kb4b6b8kbF2b4b6b7bG2b4b6bH2b4bI2b3b


Scenario: Bridge With Wrong Color Critical Piece
	Given I load this board:
	| Board                     |
	| Benediction v1: R E2 B-E8 |
	| R:D12E12k3F12G2H2356      |
	| B:E8kG4                   |
	When the blue player moves the piece at g4 to h4
	Then the action succeeds
	And the board has blue pieces matching: E8kH4
	And the board has red pieces matching: D12E12k3F12G2H2356


Scenario: Split Into Bridge Avoids All Curses If Split Pieces Adjacent
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12G25+H2356    |
	| B:E8k                     |
	When the red player splits 1 piece from g5 to h4
	Then the action succeeds
	And the board has red pieces matching: D1b2bE1b2kb3bF1b2bG2b5bH2b3b4b5b6b


Scenario: Split Into Bridge Avoids Target Curse If Target Piece Adjacent
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F126++G2H2356   |
	| B:E8k                     |
	When the red player splits 2 pieces from f6 to h4
	Then the action succeeds
	And the board has red pieces matching: D1b2bE1b2kb3bF1b2b6cG2bH2b3b4b+5b6b


Scenario: Bridge Cannot Bless Cursed Pieces
	Given I load this board:
	| Board                         |
	| Benediction v1: R-E2 B E8     |
	| R:D12E12k3F6++G1c+2cH2c3c5c6c |
	| B:E8k                         |
	When the red player splits 2 pieces from f6 to h4
	Then the action succeeds
	And the board has red pieces matching: D12E12k3F6cG1c+2cH2c3c4b+5c6c


Scenario: Home Drop Completing Bridge Wins Game
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:A1kE1345F5G5H5I5        |
	| B:D78E78k9F78             |
	When the red player drops a new piece at e2
	Then the action succeeds
	And the board has red pieces matching: A1kE1b2kb3b4b5bF5bG5bH5bI5b
	And the game is over and red has won


