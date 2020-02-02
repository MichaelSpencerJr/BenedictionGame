Feature: Win Lose Rules
	As a player, I should see win and loss conditions applied correctly.  I should win
	when a king piece of mine becomes blessed, though not when a blessed piece of mine
	becomes a king.  I should lose if one of my king pieces is captured.  I should lose
	if I am unable to make a move.

Scenario: Red King Passing Blue Wall Causes Red Win


Scenario: Blue King Passing Red Wall Causes Blue Win


Scenario: Red Capturing Any Blue King Causes Red Win


Scenario: Blue Capturing Any Red King Causes Blue Win


Scenario: Red Forming Chain With King Causes Red Win


Scenario: Blue Forming Chain With King Causes Blue Win


Scenario: Red Joining King To Existing Chain Causes Red Win


Scenario: Blue Joining King To Existing Chain Causes Red Win


Scenario: Red Moving Blessed Piece Onto Red Home Does Not Cause Win


Scenario: Red Moving Blessed Piece Onto Blue Home Does Not Cause Win


Scenario: Blue Moving Blessed Piece Onto Red Home Does Not Cause Win


Scenario: Blue Moving Blessed Piece Onto Blue Home Does Not Cause Win


Scenario: Red With No Legal Moves Causes Blue Win


Scenario: Blue With No Legal Moves Causes Red Win

