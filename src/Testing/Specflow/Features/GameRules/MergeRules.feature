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
	Given this test isn't written yet


Scenario: Merge Normal and Normal
	Given this test isn't written yet


Scenario: Merge Above Size Two Requires Blessing
	Given this test isn't written yet


Scenario: Merge Normal and Blessed
	Given this test isn't written yet


Scenario: Merge Cursed and Blessed
	Given this test isn't written yet


Scenario: Cannot Merge Cursed and Normal
	Given this test isn't written yet


Scenario: Cannot Merge Cursed and Cursed
	Given this test isn't written yet


Scenario: Merge Normal and King
	Given this test isn't written yet


Scenario: Merge Normal and King Above Stack Size Two Requires Blessing
	Given this test isn't written yet


Scenario: Merge Blessed and King
	Given this test isn't written yet


Scenario: Cannot Merge Cursed and King
	Given this test isn't written yet


Scenario: Cannot Merge King and King
	Given this test isn't written yet


Scenario: Cannot Merge Above Stack Size Fifteen
	Given this test isn't written yet

