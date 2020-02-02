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
	Given this test isn't written yet


Scenario: Blessed Piece Wrapping Around Remains Blessed
	Given this test isn't written yet


Scenario: Cursed Piece Wrapping Around Onto Home Becomes King
	Given this test isn't written yet


Scenario: Normal Piece Wrapping Around Onto Home Becomes King
	Given this test isn't written yet


Scenario: Blessed Piece Wrapping Around Onto Home Becomes King
	Given this test isn't written yet


Scenario: King Wrapping Around Onto Regular Space Wins Game
	Given this test isn't written yet


Scenario: King Wrapping Around Onto Home Wins Game
	# Just to confirm no home-space-specific logic stops an otherwise valid win
	Given this test isn't written yet


Scenario: Cursed Piece Wrapping Around and Merging Requires Blessed Target
	Given this test isn't written yet


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




