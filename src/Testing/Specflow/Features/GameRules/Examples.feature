@no-images
Feature: Examples
	As a test author,
	I want to be able to see examples of test steps I can use
	suitable for copying and pasting into my own new tests.

Background:
	# These lines starting with hash / pound marks are comments and are ignored.

	# Above all else: I'm a friend, not a compiler.  If you check something in that doesn't work,
	# don't worry -- I'll fix it up.  The work you do creating boards and scenarios won't be
	# wasted because of some trivial test syntax issue.

	# Each test is its own separate scenario, and everything is reset between tests.
	# So if you want some starting board state to be used and reused for multiple tests,
	# you'll need to add it to setup for each test.

	# So in a general sense, each test has these parts:
	# Scenario: Unique Name For What This Is Testing
	#     Given . . . some kind of setup work that gets us ready for the behavior we want to test
	#     When . . . I do the interesting thing that this scenario is trying to test
	#     Then . . . I check what happened in the "When" part and make sure it did the right thing.

	# You can also have multiple When and Then statements, so the general flow can be like:
	# When I do this illegal move that shouldn't work
	# Then I get an error
	# When I do this other illegal move that also shouldn't work
	# Then I get an error
	# When I finally do a legal move
	# Then the move succeeds

	# You might see "And" instead of Given/When/Then.  And just copies the last starting word you used.
	# If you did "Given" . . . "And" . . . then the "And" is also a Given.
	# If you did "When" I do this "And" I do that . . . then the "And" is also a When.

	# The background section is for setup steps which should happen before EVERY test in this file.
	# Usually we'll use it to declare a bunch of named boards for convenient loading in multiple tests.

	# To declare a named board, use this:
	Given I define board WeirdSituation1 as:
	| Any header here - the name doesn't matter |
	| Benediction v1: R E2 B-E8                 |
	| R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
	| B:D6k+7k+8E7+8k+9k+F78k+H5+               |
	| X:B5C2D4E6F3H6I1                          |
	# The name doesn't matter, but it needs to have those pipe characters on either side.

	# Mainly we'll write tests using just single scenarios.  Every scenario starts with Scenario: and a unique name.
	# (Yes the name has to be unique -- if you copy / paste a test to do a different variation, make the names unique with A and B or something)


Scenario: Load a Previously Created Board
	# Then to start the test we'll load the board we created above.
	Given I have board WeirdSituation1
	# And now the board is loaded and we can start trying moves.


	# You can also describe a board by starting from an empty board and adding pieces.


Scenario: Start From an Empty Board
	Given I have an empty E2 E8 board
	# where E2 and E8 are the two homes, and you can change them around if you want.

	# You can then add pieces to the empty board using the same condensed notation that boards saved to text use.
	# The last keyword I used was Given so this And means Given
	And I add this red piece: E3k+

	And I add these blue pieces: D45+E56k7F5++++6+b+++7+++++



	# You can also just load a board using saved board text from the game


Scenario: Load a Saved Board
	Given I load this board:
	# again it has to have a header row (Board, in this case) but the contents don't matter.
	| Board                       |
	| Benediction v1: R E2 B-E8   |
	| R:D1+2+E1k+2k+3k+F1k2G1k+2+ |
	| B:D6k+7k+8E7+8k+9k+F78k+H5+ |
	| X:B5C2D4E6F3H6I1            |


	############################################################


	# Once you have your board loaded, you can perform moves for your test scenario.
	# There are several ways to add these.

	# There are individual When steps for each of the five move types:
	

Scenario: Perform Some Moves
	Given I load this board:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

	# Movement:
	When the red player moves the piece at e3 to e4

	# Dropping new pieces:
	When the red player drops a new piece at e3

	# Placing a block:
	When the blue player blockades c2

	# Merging two pieces
	When the blue player merges the piece at f7 into e7
	When the red player merges the piece at e4 into e3

	# Splitting two pieces
	When the red player splits 1 piece from e3 onto d2


	# You can also use the short notation from the forum:


Scenario: Perform Some Moves - Short Notation
	Given I load this board:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

	# Movement:
	When red does e3e4

	# Dropping new pieces:
	When red does @e3

	# Placing a block:
	When blue does Bc2

	# Merging two pieces
	When blue does f7+e7
	When red does e4+e3

	# Splitting two pieces
	When red does e3-1-d2


	# You can even just put a ton of moves into a big table,
	# though you'll need to use the exact table header given here:


Scenario: Perform Some Moves - Table Notation
	Given I load this board:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

	When the following moves are performed:
	| RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
	| f1+f2      | f2-1-g2    | e8+e9       | Bi3         |
	| e3+d2      | Bb5        | f7+f8       | f8f7        |
	| d2c1       | e1f1       | Ba2         | f7-1-g7     |
	| e2e3       | d1e1       | Bf8         | f7g6        |
	| Bg1        | Bb1        | Bd4         | d7+e7       |
	| f1+e1      | f2e2       | @d7         | d7+d8       |
	| @f2        | f2+e2      | @d7         | @e8         |
	| @f2        | e3+f2      | e8+d7       | @e8         |
	| @d1        | @e3        | @f7         | f7+e8       |
	| @f1        | @d2        | @f7         | Bd6         |


	
	#########################################################

	# In a way, the point of a test is to fail if the computer doesn't do the right thing.
	# "Then" steps are where you check if the right behavior has indeed happened.
	
	# The two most basic, merely testing for success or failure, are:
	# Then the action succeeds
	# Then the action fails

	# For example, if we try to place a block on our king:


Scenario: Cannot Block Own King
	Given I have an empty E2 E8 board
	When red does Be2
	Then the action fails

	# Since I had previously introduced bugs where splitting a piece produced incorrect
	# piece sizes, you can also check that all of the red pieces or all of the blue pieces
	# match a given load-game-style definition.  For example:


Scenario: Merge Split Merge Doesn't Create Pieces
	Given I load this board:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

	When the red player merges the piece at f2 onto e3
	And the red player splits 1 piece from e3 onto d2
	Then the board has red pieces matching: D12+E12k3F1


	#########################################################

	# Last bit of advice: if you need to exhaustively confirm that, for the same board state,
	# a BUNCH of different moves are all collectively legal or illegal, you can use Scenario Outline.
	# This is a bit advanced and you don't have to do it, but you can create an Examples section
	# and it'll substitute columns from the Examples table into <Named> <Parameters> you put in the test.


Scenario Outline: None of These Are Valid Block Locations
	Given I load this board:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |
	When the red player blockades <BlockHere>
	Then the action fails

	Examples:
	| BlockHere |
	| d1        |
	| d2        |
	| e1        |
	| e2        |
	| e3        |
	| f1        |
	| f2        |
	| d7        |
	| d8        |
	| e7        |
	| e8        |
	| e9        |
	| f7        |
	| f8        |

	# Just like that we made 14 tests.  It'll rerun the Scenario Outline 14 times, once for each row in Examples.