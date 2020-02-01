Feature: BlessingRules
	Blessing mechanics should be applied correctly.


Background:
	Given I define board RedWrapAround as:
	| RedWrapAround             |
	| Benediction v1: R-E2 B E8 |
	| R:A4+B4++C7D126+E12k3F12  |
	| B:E5k                     |
	And I define board BlueWrapAround as:
	| BlueWrapAround            |
	| Benediction v1: R E2 B-E8 |
	| R:E5k                     |
	| B:C1+D7E78kF7G13+H1c6     |
	| X:A4C6F8G7                |

Scenario: Split Merge Split Across
	Given I have board BlueWrapAround
	When the blue player moves the piece at H1 to H6
	Then the action fails with: Destination H6 Is Your Own Piece and Cannot Be Moved Onto By Blue
	When the blue player moves the piece at H1 to A4
	Then the action fails with: Destination A4 Contains a Block, Which Cannot Be Moved Onto