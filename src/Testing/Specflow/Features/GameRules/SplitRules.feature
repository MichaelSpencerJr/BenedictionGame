@every-change
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
	Given I define board LargeStacks as:
	| New Game Board                                              |
	| Benediction v1: R-E2 B E8                                   |
	| R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
	| B:D78E78k9F78                                               |


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
	Given I have board LargeStacks
	When the red player splits 0 pieces from d2 onto d3
	Then the action fails
	When the red player splits 15 pieces from d2 onto d3
	Then the action fails
	When the red player splits -47 pieces from d2 onto d3
	Then the action fails
	When the red player splits 8675309 pieces from d2 onto d3
	Then the action fails
	When the red player splits 16 pieces from d2 onto d3
	Then the action fails


Scenario: Split Distance Cannot Exceed Size
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D1b+2b+++E1+2k3b+F12b++ |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from e3 onto e5
	Then the action fails
	When the red player splits 2 pieces from f2 onto f5
	Then the action fails
	When the red player splits 1 piece from d2 onto d4
	Then the action fails
	When the red player splits 2 pieces from d2 onto d5
	Then the action fails
	When the red player splits 3 pieces from d2 onto d6
	Then the action fails


Scenario: Split-Move Curses Both Pieces
	Given I have board NewGame
	When the red player merges the piece at f1 into f2
	Then the action succeeds
	When the red player splits 1 piece from f2 onto f3
	Then the action succeeds
	And the board has red pieces matching: D12E12k3F2c3c


Scenario: Split-Move Cannot Move Onto Block
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12+            |
	| B:D78E78k9F78             |
	| X:F3                      |
	When the red player splits 1 piece from f2 onto f3
	Then the action fails


Scenario: Split-Move Cannot Move Over Block
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12+++          |
	| B:D78E78k9F78             |
	| X:F3                      |
	When the red player splits 2 pieces from f2 onto f4
	Then the action fails


Scenario: Split-Capture Cannot Move Over Block
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12+++          |
	| B:D78E78k9F478            |
	| X:F3                      |
	When the red player splits 2 pieces from f2 onto f4
	Then the action fails


Scenario: Split-Merge Leaves Correctly Sized Stacks
	Given I have board LargeStacks
	When the red player splits 6 pieces from f2 onto e3
	Then the action succeeds
	And there should be a red fourteen-stack on e3
	And there should be a red two-stack on f2
	When the red player splits 1 piece from d2 onto d1
	Then the action succeeds
	And there should be a red fourteen-stack on d2
	And there should be a red fifteen-stack on d1


Scenario: Cannot Split-Merge Onto Cursed Piece
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3cF12            |
	| B:D78E78k9F78             |
	When the red player merges the piece at f1 into f2
	Then the action succeeds
	When the red player splits 1 piece from f2 onto e3
	Then the action fails


Scenario: Cannot Split-Merge Over Block
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5bF12         |
	| B:D78E78k9F78             |
	| X:E4                      |
	When the red player splits 2 pieces from e3 onto e5
	Then the action fails


Scenario: Cannot Split-Merge Onto Regular Piece Over Stack Size Two
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5F12          |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from e3 onto e5
	Then the action fails


Scenario: Cannot Split-Merge Onto King Over Stack Size Two
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5kF12         |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from e3 onto e5
	Then the action fails


Scenario: Blessed Stack Loses Blessing Upon Split-Merge
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3b+4F12          |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from e3 onto e4
	Then the action succeeds
	And there should be a red two-stack on e4
	And there should be a red one-stack on e3


Scenario: Cannot Split-Merge Blessed Stack Onto Regular Piece Over Stack Size Two
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5F12          |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from e3 onto e5
	Then the action fails


Scenario: Cannot Split-Merge Blessed Stack Onto King Over Stack Size Two
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5kF12         |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from e3 onto e5
	Then the action fails


Scenario: Split-Merge Blessed Stack Onto Blessed Piece Over Stack Size Two
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3++5bF12         |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from e3 onto e5
	Then the action succeeds
	And there should be a red three-stack on e5
	And there should be a red one-stack on e3

Scenario Outline: Split-Merge Rule Test - Over Wall
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B C6 |
	| R:A5bD8bE1c2k8cF8I5       |
	| B:C6k                     |
	And I add these red pieces: E9<Source>A5<Target>
	When the red player splits 1 piece from e9 onto a5
	Then the action <Outcome>
	And there should be a red <TargetResult> on a5
	And there should be a red <SourceResult> on e9
	Examples:
	| Source | Target | Outcome  | SourceResult     | TargetResult                     |
	| +      |        | succeeds | one-stack        | two-stack                        |
	| +      | b      | succeeds | one-stack        | two-stack                        |
	| +      | c      | succeeds | one-stack        | two-stack                        |
	| +      | k      | succeeds | one-stack        | two-stack king                   |
	| +      | +      | succeeds | one-stack        | three-stack                      |
	| +      | b+     | succeeds | one-stack        | three-stack                      |
	| +      | c+     | succeeds | one-stack        | three-stack                      |
	| +      | k+     | succeeds | one-stack        | three-stack king                 |
	| b+     |        | succeeds | one-stack        | two-stack                        |
	| b+     | b      | succeeds | one-stack        | two-stack                        |
	| b+     | c      | succeeds | one-stack        | two-stack                        |
	| b+     | k      | succeeds | one-stack        | two-stack king                   |
	| b+     | +      | succeeds | one-stack        | three-stack                      |
	| b+     | b+     | succeeds | one-stack        | three-stack                      |
	| b+     | c+     | succeeds | one-stack        | three-stack                      |
	| b+     | k+     | succeeds | one-stack        | three-stack king                 |
	| c+     |        | fails    | cursed two-stack | one-stack                        |
	| c+     | b      | succeeds | one-stack        | two-stack                        |
	| c+     | c      | fails    | cursed two-stack | cursed one-stack                 |
	| c+     | k      | fails    | cursed two-stack | one-stack king                   |
	| c+     | +      | fails    | cursed two-stack | two-stack                        |
	| c+     | b+     | succeeds | one-stack        | three-stack                      |
	| c+     | c+     | fails    | cursed two-stack | cursed two-stack                 |
	| c+     | k+     | fails    | cursed two-stack | two-stack king                   |
	| k+     |        | succeeds | one-stack king   | two-stack king with a blessing   |
	| k+     | b      | succeeds | one-stack king   | two-stack king with a blessing   |
	| k+     | c      | succeeds | one-stack king   | two-stack king with a blessing   |
	| k+     | k      | fails    | two-stack king   | one-stack king                   |
	| k+     | +      | succeeds | one-stack king   | three-stack king with a blessing |
	| k+     | b+     | succeeds | one-stack king   | three-stack king with a blessing |
	| k+     | c+     | succeeds | one-stack king   | three-stack king with a blessing |
	| k+     | k+     | fails    | two-stack king   | two-stack king                   |


Scenario Outline: Split-Merge Rule Test - Adjacent
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B C6 |
	| R:A5bD8bE1c2k8cF8I5       |
	| B:C6k                     |
	And I add these red pieces: A1<Source>A2<Target>
	When the red player splits 1 piece from a1 onto a2
	Then the action <Outcome>
	And there should be a red <TargetResult> on a2
	And there should be a red <SourceResult> on a1
	Examples:
	| Source | Target | Outcome  | SourceResult     | TargetResult     |
	| +      |        | succeeds | one-stack        | two-stack        |
	| +      | b      | succeeds | one-stack        | two-stack        |
	| +      | c      | fails    | two-stack        | cursed one-stack |
	| +      | k      | succeeds | one-stack        | two-stack king   |
	| +      | +      | fails    | two-stack        | two-stack        |
	| +      | b+     | succeeds | one-stack        | three-stack      |
	| +      | c+     | fails    | two-stack        | cursed two-stack |
	| +      | k+     | fails    | two-stack        | two-stack king   |
	| b+     |        | succeeds | one-stack        | two-stack        |
	| b+     | b      | succeeds | one-stack        | two-stack        |
	| b+     | c      | succeeds | one-stack        | two-stack        |
	| b+     | k      | succeeds | one-stack        | two-stack king   |
	| b+     | +      | succeeds | one-stack        | three-stack      |
	| b+     | b+     | succeeds | one-stack        | three-stack      |
	| b+     | c+     | succeeds | one-stack        | three-stack      |
	| b+     | k+     | succeeds | one-stack        | three-stack king |
	| c+     |        | fails    | cursed two-stack | one-stack        |
	| c+     | b      | succeeds | one-stack        | two-stack        |
	| c+     | c      | fails    | cursed two-stack | cursed one-stack |
	| c+     | k      | fails    | cursed two-stack | one-stack king   |
	| c+     | +      | fails    | cursed two-stack | two-stack        |
	| c+     | b+     | succeeds | one-stack        | three-stack      |
	| c+     | c+     | fails    | cursed two-stack | cursed two-stack |
	| c+     | k+     | fails    | cursed two-stack | two-stack king   |
	| k+     |        | succeeds | one-stack king   | two-stack king   |
	| k+     | b      | succeeds | one-stack king   | two-stack king   |
	| k+     | c      | fails    | two-stack king   | cursed one-stack |
	| k+     | k      | fails    | two-stack king   | one-stack king   |
	| k+     | +      | fails    | two-stack king   | two-stack        |
	| k+     | b+     | succeeds | one-stack king   | three-stack king |
	| k+     | c+     | fails    | two-stack king   | cursed two-stack |
	| k+     | k+     | fails    | two-stack king   | two-stack king   |