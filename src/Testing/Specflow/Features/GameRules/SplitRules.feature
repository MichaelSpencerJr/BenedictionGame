Feature: Split Rules
	As a player I should see that split rules are applied correctly.  The split-away part should
	be allowed to move the same number of spaces and the size of the split-away stack.  For split-moves
	and split-captures, both split-away and left-behind parts should be cursed - unless another mechanic
	causes a blessing to be applied.  For split-merges, neither part should be cursed.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Split-Move Happy Path
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	And the red player splits 1 piece from f2 onto f3
	Then the action succeeds
	And the board has red pieces matching: D12E12kF12c3c


Scenario: Split-Capture Happy Path
	Given I load this board:
	| Board                     |
	| Benediction v1: R=E2 B E8 |
	| R:D12E12k6+F1             |
	| B:D78E78k9F5+             |
	When the red player splits 1 piece from e6 onto e7
	Then the action succeeds
	And the board has red pieces matching: D12E12k6c7cF1


Scenario: Split-Merge Happy Path
	Given I have board NewGame
	When the red player merges the piece at e3 into f2
	And the red player splits 1 piece from f2 onto f1
	Then the action succeeds
	And the board has red pieces matching: D12E12kF1+2


Scenario: Split Must Reject Invalid Sizes
	Given this test isn't written yet


Scenario: Split Distance Cannot Exceed Size
	Given this test isn't written yet


Scenario: Split-Move Curses Both Pieces
	Given this test isn't written yet


Scenario: Split-Move Cannot Move Onto Block
	Given this test isn't written yet


Scenario: Split-Move Cannot Move Over Block
	Given this test isn't written yet


Scenario: Split-Capture Cannot Move Over Block
	Given this test isn't written yet


Scenario: Split-Merge Leaves Correctly Sized Stacks
	Given this test isn't written yet


Scenario: Cannot Split-Merge Onto Cursed Piece
	Given this test isn't written yet


Scenario: Cannot Split-Merge Over Block
	Given this test isn't written yet


Scenario: Cannot Split-Merge Onto Regular Piece Over Stack Size Two
	Given this test isn't written yet


Scenario: Cannot Split-Merge Onto King Over Stack Size Two
	Given this test isn't written yet


Scenario: Blessed Stack Loses Blessing Upon Split-Merge
	Given this test isn't written yet


Scenario: Cannot Split-Merge Blessed Stack Onto Regular Piece Over Stack Size Two
	Given this test isn't written yet


Scenario: Cannot Split-Merge Blessed Stack Onto King Over Stack Size Two
	Given this test isn't written yet


Scenario: Split-Merge Blessed Stack Onto Blessed Piece Over Stack Size Two
	Given this test isn't written yet
