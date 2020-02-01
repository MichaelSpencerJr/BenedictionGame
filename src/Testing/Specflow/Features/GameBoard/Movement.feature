Feature: Movement
	In order to keep game board mechanics reliable
	As a game player I should be able to move pieces correctly on the board
	And I should be able to wrap around from the opposing color's wall.

	# Everything in the "Background" section is run before every test in this file.
	# This will be used for common setup tasks, like creating a library of interesting board positions to start from.

	# Lists of pieces are column by column, first a column letter (which is not repeated) and then a digit for each row in that column
	# which has a piece of that kind in it.  A135 means a piece in A1, A3, and A5.  Modifiers are added after a digit if it's a stack,
	# a king, blessed, cursed, etc.  
	#   +  adds a piece to a stack.
	#   k  indicates the piece or stack is a king
	#   b  indicates the piece is blessed.  (Do not use capital B, that means column B.)
	#   c  indicates the piece is cursed.  (Do not use capital C, that means column C.)
	# So: A1+3+k5b means A1 is a two-stack, A3 is a two-stack of kings, and A5 is a single blessed piece.

Background:
	# This just makes the current game board empty with homes at E2 and E8.
	Given I have an empty E2 E8 board

	# Here is a single test, starting with "Scenario".

Scenario: Single Move North
	Given I add this red piece: E5
	And the current turn is RedAction1
	When the red player moves the piece at E5 to E6
	Then the action succeeds
	And the board has red pieces matching: E6
	And the current turn is RedAction2

	# This is the end of the single test.


	##################################################################

	

	# This is a test with wildcards you can change.  You can create a table at the end called "Examples" and
	# add whatever columns you want.  Then refer to those column values with the name of the column in <> characters in the test.

Scenario Outline: Moving North Without Wrapping Around
	Given I add this red piece: <InitialPosition>
	And the current turn is RedAction1
	When the red player moves the piece at <InitialPosition> to <FinalPosition>
	Then the action succeeds
	And the board has red pieces matching: <FinalPosition>
	And the current turn is RedAction2
	
	Examples:
	| InitialPosition | FinalPosition |
	| E5              | E6            |
	| E4              | E5            |



	# Here's a test that deliberately causes a failure

Scenario: Moving Too Far
	Given I add this red piece: E3
	And the current turn is RedAction1
	When the red player moves the piece at E3 to E5
	Then the action fails with: Stack Size 1 Piece At E3 Cannot Reach E5 (but can reach: E4, E2)
	# you don't have to fill in precise error messages -- just say "the action fails" and I'll update it with the actual error.
	And the board has red pieces matching: E3
	And the current turn is RedAction1