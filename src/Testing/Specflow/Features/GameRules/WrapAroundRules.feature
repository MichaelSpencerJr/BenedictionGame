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
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D1+3E3k+7c9c+	   |
	|B:B4C3+6c7cD68G5k	   |
	When the red player moves the piece at e9 to e2
	Then the action succeeds 
	And the board has red pieces matching: D1+3E2k+3k+7c


Scenario: Normal Piece Wrapping Around Onto Home Becomes King
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:E2k+3k+47cG4+	   |
	|B:B4C6c7cD678E1+H4k	   |
	|X:G3			   |
	When the blue player moves the piece at e1 to e8
	Then the action succeeds
	And the board has blue pieces matching B4C6c7cD678E8k+H4k
	
Scenario: Blessed Piece Wrapping Around Onto Home Becomes King
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:C1+D2kE5+9b+		   |
	|B:B6+C3+4k+		   |
	|X:A35B2D4		   |
	When the red player moves the piece at e9 to e2 
	Then the action succeeds 
	And the board has red pieces matching C1+D2kE2k+5+
	
Scenario: Blessed Piece Wrapping Around Merging Onto Home Becomes King
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:C1+E2k5+9b+		   |
	|B:B6+C3+4k+		   |
	|X:A35B2D4		   |
	When the red player merges the piece at e9 onto e2 
	Then the action succeeds 
	And the board has red pieces matching C1+E2k++5+

Scenario: King Wrapping Around Onto Regular Space Wins Game
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:E7+H5k++		   |
	|B:B6+C1k2k3+		   |
	|X:A35B2D4		   |
	When the blue player moves the piece on c1 to c7
	Then the action succeeds 
	And the game is over and blue has won


Scenario: King Wrapping Around Onto Home Wins Game
	# Just to confirm no home-space-specific logic stops an otherwise valid win
	Given I load this board
	|Board			   |
	|Benediction v1: R=E2 B E8 |
	|R:E7+8k++		   |
	|B:B3+6+C1k2k		   |
	|X:A35B2D46		   |
	When the red player moves the piece on e8 to e2
	Then the action succeeds
	And the game is over and red has won
	

Scenario: Cursed Piece Wrapping Around and Merging Requires Blessed Target
	Given I load this board
	|Board			   |
	|Benediction v1: R=E2 B E8 |
	|R:A4b+D128k++E137cF128c   |
	|B:A1k2cB1k3cC2c3cD7F7     |
	|X:A35B2D46F4H246	   |
	When the red player merges the piece on f8 to f1
	Then the action fails
	When the red player merges the piece on f8 to a4
	Then the action succeeds
	And the board has red pieces matching A4++D128k++E137cF12

Scenario: Regular Piece Wrapping Around and Merging Can Form Any Stack Size
	Given this test isn't written yet


Scenario: Blessed Piece Wrapping Around and Merging Can Form Any Stack Size
	Given this test isn't written yet


Scenario: Cursed Piece Wrapping Around and Splitting Remains Cursed
	Given this test isn't written yet


Scenario: Regular Piece Wrapping Around and Splitting Leaves Bless-Curse Pair
	Given this test isn't written yet


Scenario: Blessed Piece Wrapping Around and Splitting Leaves Bless-Curse Pair
	Given this test isn't written yet


Scenario: Cursed Piece Wrapping Around and Split Merging Requires Blessed Target
	Given this test isn't written yet


Scenario: Regular Piece Wrapping Around and Split Merging Can Form Any Stack Size
	Given this test isn't written yet


Scenario: Blessed Piece Wrapping Around and Split Merging Can Form Any Stack Size
	Given this test isn't written yet


Scenario: King Wrapping Around And Merging Onto Piece Remains Blessed and Wins Game
	Given this test isn't written yet


Scenario: King Stack Wrapping Around and Split Merging Onto Piece Remains Blessed and Wins Game
	Given this test isn't written yet




