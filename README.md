# BenedictionGame
Windows client for the board game Benediction by Alek Erickson

Current version is Build 14. 

To play a game, download the current version and extract the contents. The starting position is the default screen.
To make a move, click on a piece and then click on the destination point. To confirm, press enter.
To toggle possible actions that utilize same starting and ending points, right click on the destination point before confirming. 
For placing new men and blockades, click on an empty point. If that point is in your zone, a new man is the default selection. 

# BENEDICTION

Benediction: A combinatorial abstract strategy game for two players.
Equipment: 5-hex board, two colors of checkers (12-24 per side, flippable to denote kings), and go stones.
Object: Capture one enemy king, or bless one friendly king.

# RULES

Starting Point defines the zone. Mark empty starting points with a white stone. The starting point cannot be blockaded. If a man lands on the starting point, they lose all blessings/curses and become a king.
Zone includes starting point and all adjacent points. Fill your zone with men.

Men: A checker or stack of checkers. Default men have stack size of 1. Men move in any direction in a straight line, distance up to stack size. Jump occupied points. Capture by replacement. Captured men return to owner for future drops.
How to stack: New men are created by merging and splitting stacks. Default men can create stacks up to 2. To create stacks greater than 2, at least one of them must be blessed. 
Blessed men: A man with a blessing (marked by a white stone) can merge one time with any friendly man.
Cursed men: A man with a curse (marked by a black stone) cannot merge with any man (except a blessed man), and can not be blessed. Curses are made by splitting. 
Kings: Men on starting points, or that merge with a king, are kings. Kings cannot merge with kings. Kings cannot be cursed.

Enemy walls are portals to the other side of board, via forward or diagonal moves (see example). 
Walls have the power to bless men. 
If a man moves past enemy walls, bless him. If you connect your wall to the enemy wall with a bridge of men, bless all men in the bridge.
Curses: Cursed men cannot be blessed and can only merge with blessed men. Mark with black stones.

Alternate turns, each 2 actions. Actions: Move, Drop, Block, Merge, Split.
1. Move = Move man to an empty point (or capture). He cannot move again this turn, but he can merge or split.
2. Merge = Move man or sub-stack onto a reachable friendly man. Remove blessing/curse.
3. Split = Move sub-stack to empty point (or capture). Curse them. Bless if moving past enemy walls.
4. Drop = Drop a new man on an empty point in your zone. He can't move this turn, but he can merge.
5. Block = Put black stone on an empty point non-adjacent to a block (adjacency includes enemy walls). Men can’t jump / move onto blocks. 
