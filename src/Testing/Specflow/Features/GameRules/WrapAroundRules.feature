@every-change
Feature: Wrap Around Rules
	As a player, I should be able to perform actions which wrap around the board if they
	depart the board through the opponent's wall.  If the moving piece is not cursed
	it should become blessed.  Normal restrictions on moving, splitting, and merging
	should otherwise apply.

# These scenarios should exercise any situations where wall wrap around mechanics
# interact with existing game action behaviors in interesting ways.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Cursed Piece Wrapping Around Remains Cursed
	Given I have board NewGame
	And I add this red piece: I5c
	When the red player moves the piece at i5 to a1
	Then the action succeeds
	And the board has red pieces matching: A1cD12E12k3F12


Scenario: Normal Piece Wrapping Around Becomes Blessed
	Given I have board NewGame
	And I add this red piece: I5
	When the red player moves the piece at i5 to a1
	Then the action succeeds
	And the board has red pieces matching: A1bD12E12k3F12


Scenario: Blessed Piece Wrapping Around Remains Blessed
	Given I have board NewGame
	And I add this red piece: I5b
	When the red player moves the piece at i5 to a1
	Then the action succeeds
	And the board has red pieces matching: A1bD12E12k3F12


Scenario: Cursed Piece Wrapping Around Onto Home Becomes King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D1+3E3k+7c9c+           |
	| B:B4C3+6c7cD68G5k         |
	When the red player moves the piece at e9 to e2
	Then the action succeeds 
	And the board has red pieces matching: D1+3E2k+3k+7c


Scenario: Normal Piece Wrapping Around Onto Home Becomes King
	Given I load this board
	| Board                     |
	| Benediction v1: R E2 B-E8 |
	| R:E2k+3k+47cG4+           |
	| B:B4C6c7cD678E1+H4k       |
	| X:G3                      |
	When the blue player moves the piece at e1 to e8
	Then the action succeeds
	And the board has blue pieces matching B4C6c7cD678E8k+H4k
	
Scenario: Blessed Piece Wrapping Around Onto Home Becomes King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:C1+D2kE5+9b+            |
	| B:B6+C3+4k+               |
	| X:A35B2D4                 |
	When the red player moves the piece at e9 to e2 
	Then the action succeeds 
	And the board has red pieces matching C1+D2kE2k+5+
	
Scenario: Blessed Piece Wrapping Around Merging Onto Home Becomes King
	Given I load this board
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:C1+E2k5+9b+             |
	| B:B6+C3+4k+               |
	| X:A35B2D4                 |
	When the red player merges the piece at e9 onto e2 
	Then the action succeeds 
	And the board has red pieces matching C1+E2k++5+

Scenario: King Wrapping Around Onto Regular Space Wins Game
	Given I load this board
	| Board                     |
	| Benediction v1: R E2 B-E8 |
	| R:E7+H5k++                |
	| B:B6+C1k2k3+              |
	| X:A35B2D4                 |
	When the blue player moves the piece on c1 to c7
	Then the action succeeds 
	And the game is over and blue has won


Scenario: King Wrapping Around Onto Home Wins Game
	# Just to confirm no home-space-specific logic stops an otherwise valid win
	Given I load this board
	| Board                     |
	| Benediction v1: R=E2 B E8 |
	| R:E7+8k++                 |
	| B:B3+6+C1k2k              |
	| X:A35B2D46                |
	When the red player moves the piece on e8 to e2
	Then the action succeeds
	And the game is over and red has won
	

Scenario: Cursed Piece Wrapping Around and Merging Requires Blessed Target
	Given I load this board
	| Board                     |
	| Benediction v1: R=E2 B E8 |
	| R:A4b+D128k++E137cF128c   |
	| B:A1k2cB1k3cC2c3cD7F7     |
	| X:A35B2D46F4H246          |
	When the red player merges the piece on f8 to f1
	Then the action fails
	When the red player merges the piece on f8 to a4
	Then the action succeeds
	And the board has red pieces matching A4++D128k++E137cF12


Scenario: Regular Piece Wrapping Around and Merging Can Form Any Stack Size
	Given I load this board:
	| Board                      |
	| Benediction v1: R-E2 B E8  |
	| R:A2c++D12E12k3F12G1+7H6++ |
	| B:D78E78k9F78              |
	When the red player merges the piece at g7 onto g1
	Then the action succeeds
	And there should be a red three-stack on g1
	When the red player merges the piece at h6 onto a2
	Then the action succeeds
	And there should be a red six-stack on a2


Scenario: Blessed Piece Wrapping Around and Merging Can Form Any Stack Size
	Given I load this board:
	| Board                        |
	| Benediction v1: R-E2 B E8    |
	| R:A2c++D12E12k3F12G1+7bH6b++ |
	| B:D78E78k9F78                |
	When the red player merges the piece at g7 onto g1
	Then the action succeeds
	And there should be a red three-stack on g1
	When the red player merges the piece at h6 onto a2
	Then the action succeeds
	And there should be a red six-stack on a2


Scenario: Cursed Piece Wrapping Around and Splitting Remains Cursed
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12G7c+++       |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from g7 onto g1
	Then the action succeeds
	And there should be a red cursed two-stack on g7
	And there should be a red cursed two-stack on g1


Scenario: Regular Piece Wrapping Around and Splitting Leaves Bless-Curse Pair
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12G7+++        |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from g7 onto g1
	Then the action succeeds
	And there should be a red cursed two-stack on g7
	And there should be a red blessed two-stack on g1


Scenario: Blessed Piece Wrapping Around and Splitting Leaves Bless-Curse Pair
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12G7b+++       |
	| B:D78E78k9F78             |
	When the red player splits 2 pieces from g7 onto g1
	Then the action succeeds
	And there should be a red cursed two-stack on g7
	And there should be a red blessed two-stack on g1


Scenario: Blessed Piece Wrapping Around and Splitting Completing Bridge Leaves Bless-Bless Pair
	Given I load this board:
	| Board                       |
	| Benediction v1: R-E2 B E8   |
	| R:A5+B5C5D125E12k35F124G3H2 |
	| B:D78E78k9F78               |
	When the red player splits 1 piece from a5 onto i1
	Then the action succeeds
	And there should be a red blessed one-stack on a5
	And there should be a red blessed one-stack on b5
	And there should be a red blessed one-stack on c5
	And there should be a red blessed one-stack on d5
	And there should be a red blessed one-stack on e5
	And there should be a red blessed one-stack on f4
	And there should be a red blessed one-stack on g3
	And there should be a red blessed one-stack on h2
	And there should be a red blessed one-stack on i1


Scenario: Cursed Piece Wrapping Around and Split Merging Requires Blessed Target
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12G17c+++      |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from g7 onto g1
	Then the action fails


Scenario: Regular Piece Wrapping Around and Split Merging Can Form Any Stack Size
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:A1+D12E12k3F12I5+       |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from i5 onto a1
	Then the action succeeds
	And there should be a red one-stack on i5
	And there should be a red three-stack on a1


Scenario: Blessed Piece Wrapping Around and Split Merging Can Form Any Stack Size
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:A1+D12E12k3F12I5b+      |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from i5 onto a1
	Then the action succeeds
	And there should be a red one-stack on i5
	And there should be a red three-stack on a1


Scenario: King Wrapping Around And Merging Onto Piece Remains Blessed and Wins Game
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:A1+D12E12k3F12I5k+      |
	| B:D78E78k9F78             |
	When the red player merges the piece from i5 onto a1
	Then the action succeeds
	And there should be a red four-stack king with a blessing on a1
	And the game is over and red has won


Scenario: King Stack Wrapping Around and Split Merging Onto Piece Remains Blessed and Wins Game
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:A1+D12E12k3F12I5k+      |
	| B:D78E78k9F78             |
	When the red player splits 1 piece from i5 onto a1
	Then the action succeeds
	And there should be a red one-stack king on i5
	And there should be a red three-stack king with a blessing on a1
	And the game is over and red has won




