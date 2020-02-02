Feature: Split Rules
	As a player I should see that split rules are applied correctly.  The split-away part should
	be allowed to move the same number of spaces and the size of the split-away stack.  For split-moves
	and split-captures, both split-away and left-behind parts should be cursed - unless another mechanic
	causes a blessing to be applied.  For split-merges, neither part should be cursed.

Scenario: Split-Move Happy Path


Scenario: Split-Capture Happy Path


Scenario: Split-Merge Happy Path


Scenario: Split Must Reject Invalid Sizes


Scenario: Split Distance Cannot Exceed Size


Scenario: Split-Move Curses Both Pieces


Scenario: Split-Move Cannot Move Onto Block


Scenario: Split-Move Cannot Move Over Block


Scenario: Split-Capture Cannot Move Over Block


Scenario: Split-Merge Leaves Correctly Sized Stacks


Scenario: Cannot Split-Merge Onto Cursed Piece


Scenario: Cannot Split-Merge Over Block


Scenario: Cannot Split-Merge Onto Regular Piece Over Stack Size Two


Scenario: Cannot Split-Merge Onto King Over Stack Size Two


Scenario: Blessed Stack Loses Blessing Upon Split-Merge


Scenario: Cannot Split-Merge Blessed Stack Onto Regular Piece Over Stack Size Two


Scenario: Cannot Split-Merge Blessed Stack Onto King Over Stack Size Two


Scenario: Split-Merge Blessed Stack Onto Blessed Piece Over Stack Size Two
