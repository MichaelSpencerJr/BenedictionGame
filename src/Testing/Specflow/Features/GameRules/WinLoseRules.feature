Feature: Win Lose Rules
	As a player, I should see win and loss conditions applied correctly.  I should win
	when a king piece of mine becomes blessed, though not when a blessed piece of mine
	becomes a king.  I should lose if one of my king pieces is captured.  I should lose
	if I am unable to make a move.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Red King Passing Blue Wall Causes Red Win
	Given I load this board:
	| Board                     |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12I5k          |
	| B:D78E78k9F78             |
	When the red player moves the piece at i5 to a1
	Then the action succeeds
	And the game is over and red has won


Scenario: Blue King Passing Red Wall Causes Blue Win
	Given I load this board:  
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:D12F2k+3+H2+		   |
	|B:A2k+D5+E9F78		   |
	|X:B2D4F4                  |
	When the red player moves the piece at a2 to a5
	Then the action succeeds
	And the game is over and blue has won


Scenario: Red Capturing Any Blue King Causes Red Win
	Given I load this board
	|Board			   |
	|Benediction v1: R=E2 B E8 |
	|R:D123k+F3+H2+		   |
	|B:B3kC3kD5+E9F78	   |
	|X:B2D4F4		   |
	When the red player moves the piece at d3 to c3
	Then the action succeeds
	And the game is over and red has won


Scenario: Blue Capturing Any Red King Causes Blue Win
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:D123k+F3+H2+		   |
	|B:B3kC3kD5+E9F78	   |
	|X:B2D4F4		   |
	When the blue player moves the piece at c3 to d3
	Then the action succeeds
	And the game is over and blue has won

Scenario: Red Forming Chain With King Causes Red Win
	Given I load this board
	|Board			   |
	|Benediction v1: R=E2 B E8 |
	|R:D123k+E4c5cF5cG5cH5+    |
	|B:B3k4k5+D78+E79F8+       |
	|X:B2C7D4F46		   |
	When the red player splits one piece from h5 to h6
	Then the action succeeds 
	And the game is over and red has won

Scenario: Blue Forming Chain With King Causes Blue Win
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B=E8 |
	|R:D123k+E4c5cF5cG2c5cH2c  |
	|B:A1c2cB3k4k5C6D8+E9F8+   |
	|X:B2C7D4F246H3I4	   |
	When the blue player places a piece at d7
	Then the action succeeds 
	And the game is over and red has won

Scenario: Red Joining King To Existing Chain Causes Red Win
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:F2k+I1b2b3b+4c5c	   |
	|B:A1c2c4+5+E8k		   |
	When the red player moves the piece from f2 to h2 
	Then the action succeeds 
	And the game is over and red has won

Scenario: Blue Joining King To Existing Chain Causes Red Win
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:E3k+I1b2b3b+4c5c	   |
	|B:A1c2c3b4b5b+D7k+	   |
	|X:E46G36H4		   |
	When the blue player moves the piece from d7 to b5 
	Then the action succeeds 
	And the game is over and blue has won


Scenario: Red Moving Blessed Piece Onto Red Home Does Not Cause Win
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:C2b+D123E13F12k	   |
	|B:C5+D7E7+8kF8+	   |
	|X:B6D6F5H3		   |
	When the red player moves the piece from c2 to e2
	Then the action succeeds 
	And there should be a two-stack king on e2 without any blessing

Scenario: Red Moving Blessed Piece Onto Blue Home Does Not Cause Win
	Given I load this board
	|Board			   |
	|Benediction v1: R=E2 B E8 |
	|R:F2b7b+G2k+H3bI4c5c      |
	|B:A2c3bB3c5+D2b+F8k+      |
	|X:A5E46G36H4		   |
	When the red player moves a piece from f7 to e8
	Then the action succeeds
	And there should be a red king on e8 without any blessing


Scenario: Blue Moving Blessed Piece Onto Red Home Does Not Cause Win
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:F2b7b+G2k+H3bI4c5c      |
	|B:A2c3bB3c5+D2b+F8k+      |
	|X:A5E46G36H4		   |
	When the blue player moves a piece from d2 to e2 
	Then the action succeeds 
	And there should be a blue king on e2 without any blessing
	
Scenario: Blue Moving Blessed Piece Onto Blue Home Does Not Cause Win
	Given I load this board 
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:E3k+G1b+2bI2b4c5c       |
	|B:A1c2c3b4bD7b+F8k+       |
	|X:A5E46G36H4		   |
	When the blue player moves the piece from d7 to e8
	Then the action succeeds
	And there should be a blue king on e8 without any blessing

Scenario: Red With No Legal Moves Causes Blue Win
	Given I load this board
	|Board			   |
	|Benediction v1: R-E2 B E8 |
	|R:A1k			   |
	|B:D2+E1k2k3c8k9F2c7	   |
	|X:B246D168E4F18G35H16I24  |
	When the red player moves the piece from a1 to a2
	Then the action succeeds
	And the game is over and blue has won


Scenario: Blue With No Legal Moves Causes Red Win
	Given I load this board
	|Board			   |
	|Benediction v1: R E2 B-E8 |
	|R:D7cE12k78k9cF17c	   |
	|B:B3k			   |
	|X:A135C16D358F358G16H2I35 |
	When the blue player moves the piece from b3 to a2
	Then the action succeeds
	And the game is over and red has won
