@every-change
Feature: Merge Rules
	As a player, I should see that merge rules are applied correctly.  Cursed pieces cannot
	merge with other non-blessed pieces.  Merges must not exceed stack size 2 unless one
	piece involved in the merge is blessed.  Merges remove blessings and curses.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Merge Happy Path
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	Then the action succeeds

Scenario: Merge Maximum
	Given I load this board
	| Board                       |
	| Benediction v1: R-E2 B E8   |
	| R:D12E12k3++++++F12b+++++++ |
	| B:D78E78k9F78               |
	When the red player merges the piece at f2 onto e3
	Then the action succeeds
	And the board has red pieces matching: D12E12k3++++++++++++++F1


Scenario: Merge Normal and Normal
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	Then the action succeeds


Scenario: Merge Above Size Two Requires Blessing
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	Then the action succeeds
	When the red player merges the piece at f2 into f1
	Then the action fails
	Given I add these red pieces: F2+b
	When the red player merges the piece at f2 into f1
	Then the action succeeds
	And the board has red pieces matching: D12E12kF1++


Scenario: Merge Normal and Blessed
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12b            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into f1
	Then the action succeeds
	And the board has red pieces matching: D12E12k3F1+


Scenario: Merge Cursed and Blessed
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F1c2b           |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into f1
	Then the action succeeds
	And the board has red pieces matching: D12E12k3F1+


Scenario: Cannot Merge Cursed and Normal
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F1c2            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into f1
	Then the action fails


Scenario: Cannot Merge Cursed and Cursed
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F1c2c           |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into f1
	Then the action fails


Scenario: Merge Normal and King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into e2
	Then the action succeeds
	And there should be a red two-stack king on e2


Scenario: Merge Normal and King Above Stack Size Two Requires Blessing
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12+            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into e2
	Then the action fails
	Given I add this red piece: F2b+
	When the red player merges the piece at f2 into e2
	Then the action succeeds
	And there should be a red three-stack king on e2


Scenario: Merge Blessed and King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12b+           |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into e2
	Then the action succeeds
	And there should be a red three-stack king on e2


Scenario: Cannot Merge Cursed and King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12c            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into e2
	Then the action fails


Scenario: Cannot Merge King and King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12k            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f2 into e2
	Then the action fails


Scenario: Cannot Merge Above Stack Size Fifteen
	Given I load this board
	| Board                                                       |
	| Benediction v1: R-E2 B E8                                   |
	| R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
	| B:D78E78k9F78                                               |
	When the red player merges the piece at f2 into e3
	Then the action fails
	When the red player merges the piece at d2 into e2
	Then the action fails
	When the red player merges the piece at d2 into e3
	Then the action fails
	When the red player merges the piece at d2 into d1
	Then the action fails
	When the red player merges the piece at d1 into e1
	Then the action fails


