Feature: Alek Samples
	In order to confirm rules are processed correctly,
	I should be able to walk through some sample games and confirm their moves are all handled correctly.

Background:
	Given I define board NewGame as:
	| New Game Board            |
	| Benediction v1: R-E2 B E8 |
	| R:D12E12k3F12             |
	| B:D78E78k9F78             |

Scenario: Alek Sample Game 1
	Given I have board NewGame
	When the following moves are performed:
		| RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
		| e3e4       | @e3        | f8+f7       | @f8         |
		| d1+d2      | @d1        | d7d6        | @d7         |
		| f1+f2      | @f1        | f7f5        | @f7         |
		| f2f4       | f4-1-f5    | d7+d6       | d6b4        |
		| d2f3       | @f2        | b4b2        | Bc2         |
		| f3h3       | f1+f2      | b2i5        | e9+f8       |
		| h3h5       | h5-1-i5    | @e9         | @d7         |
		| f4g4       | f2f4       | f8h6        | h6-1-i5     |
		| e3+e4      | h5i5       | h6i5        | @f8         |
		| f4d5       | e4e5       | e8+e9       | Bc7         |
		| e1+e2      | e2e4       | f7+e7       | e7e5        |
		| e4e5       | d5e6       | Be7         | @f7         |
		| e5c5       | Ba5        | d8+d7       | @d8         |
		| e6c6       | c6-1-d7    | d8d7        | @d8         |
		| c5b4       | c6d7       |             |             |
	Then the following locations match:
		| Location | Contents | Size | Type   |
		| A5       | Block    |      |        |
		| C7       | Block    |      |        |
		| C2       | Block    |      |        |
		| E7       | Block    |      |        |
		| D1       | Red      | 1    | Normal |
		| B4       | Red      | 2    | King   |
		| D7       | Red      | 1    | Cursed |
		| F5       | Red      | 1    | Cursed |
		| G4       | Red      | 1    | Cursed |
		| D8       | Blue     | 1    | Normal |
		| E9       | Blue     | 2    | King   |
		| F7       | Blue     | 1    | Normal |
		| F8       | Blue     | 1    | Normal |
		| I5       | Blue     | 1    | Cursed |