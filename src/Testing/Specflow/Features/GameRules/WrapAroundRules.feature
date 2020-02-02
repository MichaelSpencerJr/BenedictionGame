Feature: Wrap Around Rules
	As a player, I should be able to perform actions which wrap around the board if they
	depart the board through the opponent's wall.  If the moving piece is not cursed
	it should become blessed.  Normal restrictions on moving, splitting, and merging
	should otherwise apply.

# These scenarios should exercise any situations where wall wrap around mechanics
# interact with existing game action behaviors in interesting ways.

Scenario: Cursed Piece Wrapping Around Remains Cursed


Scenario: Normal Piece Wrapping Around Becomes Blessed


Scenario: Blessed Piece Wrapping Around Remains Blessed


Scenario: Cursed Piece Wrapping Around Onto Home Becomes King


Scenario: Normal Piece Wrapping Around Onto Home Becomes King


Scenario: Blessed Piece Wrapping Around Onto Home Becomes King


Scenario: King Wrapping Around Onto Regular Space Wins Game


Scenario: King Wrapping Around Onto Home Wins Game
	# Just to confirm no home-space-specific logic stops an otherwise valid win


Scenario: Cursed Piece Wrapping Around and Merging Requires Blessed Target


Scenario: Regular Piece Wrapping Around and Merging Can Form Any Stack Size


Scenario: Blessed Piece Wrapping Around and Merging Can Form Any Stack Size


Scenario: Cursed Piece Wrapping Around and Splitting Remains Cursed


Scenario: Regular Piece Wrapping Around and Splitting Leaves Bless-Curse Pair


Scenario: Blessed Piece Wrapping Around and Splitting Leaves Bless-Curse Pair


Scenario: Cursed Piece Wrapping Around and Split Merging Requires Blessed Target


Scenario: Regular Piece Wrapping Around and Split Merging Can Form Any Stack Size


Scenario: Blessed Piece Wrapping Around and Split Merging Can Form Any Stack Size


Scenario: King Wrapping Around And Merging Onto Piece Remains Blessed and Wins Game


Scenario: King Stack Wrapping Around and Split Merging Onto Piece Remains Blessed and Wins Game




