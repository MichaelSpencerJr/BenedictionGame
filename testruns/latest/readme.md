## Runtime Environment 

   OS Version: Microsoft Windows NT 10.0.17134.0

  CLR Version: 4.0.30319.42000

NUnit Version: 3.10.0.0

## Test Files 

    F:\src\BenedictionGame\src\Testing\Specflow\bin\Debug\Testing.Specflow.dll

## Tests Which Passed

### 1) Passed : Testing.Specflow.Features.ExampleGames.AlekSamplesFeature.AlekSampleGame1



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the following moves are performed:
  | RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
  | - | - | - | - |
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
    Accepted: e3e4
    Accepted: @e3
    Accepted: f8+f7
    Accepted: @f8
    Accepted: d1+d2
    Accepted: @d1
    Accepted: d7d6
    Accepted: @d7
    Accepted: f1+f2
    Accepted: @f1
    Accepted: f7f5
    Accepted: @f7
    Accepted: f2f4
    Accepted: f4-1-f5
    Accepted: d7+d6
    Accepted: d6b4
    Accepted: d2f3
    Accepted: @f2
    Accepted: b4b2
    Accepted: Bc2
    Accepted: f3h3
    Accepted: f1+f2
    Accepted: b2i5
    Accepted: e9+f8
    Accepted: h3h5
    Accepted: h5-1-i5
    Accepted: @e9
    Accepted: @d7
    Accepted: f4g4
    Accepted: f2f4
    Accepted: f8h6
    Accepted: h6-1-i5
    Accepted: e3+e4
    Accepted: h5i5
    Accepted: h6i5
    Accepted: @f8
    Accepted: f4d5
    Accepted: e4e5
    Accepted: e8+e9
    Accepted: Bc7
    Accepted: e1+e2
    Accepted: e2e4
    Accepted: f7+e7
    Accepted: e7e5
    Accepted: e4e5
    Accepted: d5e6
    Accepted: Be7
    Accepted: @f7
    Accepted: e5c5
    Accepted: Ba5
    Accepted: d8+d7
    Accepted: @d8
    Accepted: e6c6
    Accepted: c6-1-d7
    Accepted: d8d7
    Accepted: @d8
    Accepted: c5b4
    Accepted: c6d7

 -&gt; done: ActionSteps.WhenTheFollowingMoves(&lt;table&gt;) (0.1s)
#### Then the following locations match:
  | Location | Contents | Size | Type   |
  | - | - | - | - |
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
    A5 OK
    C7 OK
    C2 OK
    E7 OK
    D1 OK
    B4 OK
    D7 OK
    F5 OK
    G4 OK
    D8 OK
    E9 OK
    F7 OK
    F8 OK
    I5 OK

 -&gt; done: ValidationSteps.ThenTheFollowingLocationsMatch(&lt;table&gt;) (0.0s)
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/fa0292c9-9df4-c4b7-986e-45d432ea12e9.png?raw=true)



### 2) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player blockades A1
    Accepted: Ba1

 -&gt; done: ActionSteps.WhenIBlockade(Red, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has blocks matching: A1
    Successfully validated 1 block.

 -&gt; done: ValidationSteps.ThenTheBoardHasBlocksMatching("A1") (0.0s)


### 3) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockMaximum



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### When the following moves are performed:
  | RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
  | - | - | - | - |
  | Be9        | Bb6        | Bd7         | Bf7         |
  | Bh6        | Ba4        | Bc5         | Be6         |
  | Bg5        | Bi4        | Bb3         | Bd4         |
  | Bf4        | Bh3        | Ba1         | Bc2         |
  | Be3        | Bg2        | Bi1         | Bd1         |
  | Bf1        |            |             |             |
    Accepted: Be9
    Accepted: Bb6
    Accepted: Bd7
    Accepted: Bf7
    Accepted: Bh6
    Accepted: Ba4
    Accepted: Bc5
    Accepted: Be6
    Accepted: Bg5
    Accepted: Bi4
    Accepted: Bb3
    Accepted: Bd4
    Accepted: Bf4
    Accepted: Bh3
    Accepted: Ba1
    Accepted: Bc2
    Accepted: Be3
    Accepted: Bg2
    Accepted: Bi1
    Accepted: Bd1
    Accepted: Bf1

 -&gt; done: ActionSteps.WhenTheFollowingMoves(&lt;table&gt;) (0.0s)
#### Then the board has blocks matching: A14B36C25D147E369F147G25H36I14
    Successfully validated 21 blocks.

 -&gt; done: ValidationSteps.ThenTheBoardHasBlocksMatching("A14B36C25D147E369...") (0.0s)
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/20875bc2-1002-a4e0-45d9-f2eb9dcc1296.png?raw=true)



### 4) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockAdjacentAnotherBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### When the red player blocks e3
    Accepted: Be3

 -&gt; done: ActionSteps.WhenIBlockade(Red, E3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player blocks e4
    Rejected: Be4: Cannot Block Adjacent Existing Block E3

 -&gt; done: ActionSteps.WhenIBlockade(Red, E4) (0.0s)
#### Then the action fails
    Failed with: Cannot Block Adjacent Existing Block E3

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### And the board has blocks matching: E3
    Successfully validated 1 block.

 -&gt; done: ValidationSteps.ThenTheBoardHasBlocksMatching("E3") (0.0s)


### 5) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockHomeSpace



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### When the red player blocks e2
    Rejected: Be2: Cannot Block Red Home at Location E2

 -&gt; done: ActionSteps.WhenIBlockade(Red, E2) (0.0s)
#### Then the action fails
    Failed with: Cannot Block Red Home at Location E2

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player blocks e8
    Rejected: Be8: Cannot Block Blue Home at Location E8

 -&gt; done: ActionSteps.WhenIBlockade(Red, E8) (0.0s)
#### Then the action fails
    Failed with: Cannot Block Blue Home at Location E8

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 6) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockOccupiedSpace



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player blockades e3
    Rejected: Be3: Location E3 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E3) (0.0s)
#### Then the action fails
    Failed with: Location E3 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 7) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeCannotBlessCursedPieces



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                         |
  | - |
  | Benediction v1: R-E2 B E8     |
  | R:D12E12k3F6++G1c+2cH2c3c5c6c |
  | B:E8k                         |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/814cb5e2-fc1a-36e5-5d1a-8c14a9e50781.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from f6 to h4
    Accepted: f6-2-h4

 -&gt; done: ActionSteps.WhenISplit(Red, "2", F6, H4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3F6cG1c+2cH2c3c4b+5c6c
    Successfully validated 13 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3F6cG1c+2c...") (0.0s)


### 8) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:C2D13E12k4F124G4H4I45   |
  | B:A12B3C4D578E68k9F68G6   |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/78ef14af-3123-d5a7-50c7-8f649cc50dcb.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at d1 to c1
    Accepted: d1c1

 -&gt; done: ActionSteps.WhenIMove(Red, D1, C1) (0.0s)
#### Then the board has red pieces matching: C1b2bD3bE12k4bF124bG4bH4bI4b5b
    Successfully validated 13 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "C1b2bD3bE12k4bF12...") (0.0s)


### 9) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeMaximum



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                                   |
  | - |
  | Benediction v1: R-E2 B E8               |
  | R:A14B245C246D468E2k468kF2467G246H24I23 |
  | B:E7k                                   |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d95525f1-17d2-eac0-1f5d-6cdb34d27096.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player drops a new piece at d2
    Accepted: @d2

 -&gt; done: ActionSteps.WhenIDrop(Red, D2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)
#### And the board has red pieces matching: A1b4bB2b4b5bC2b4b6bD2b4b6b8bE2kb4b6b8kbF2b4b6b7bG2b4b6bH2b4bI2b3b
    Successfully validated 27 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1b4bB2b4b5bC2b4b...") (0.0s)


### 10) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeWithWrongColorCriticalPiece



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:D12E12k3F12G2H2356      |
  | B:E8kG4                   |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b3562125-3cee-c7e2-67c3-b4b411cfe6ec.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece at g4 to h4
    Accepted: g4h4

 -&gt; done: ActionSteps.WhenIMove(Blue, G4, H4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has blue pieces matching: E8kH4
    Successfully validated 2 Blue pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Blue, "E8kH4") (0.0s)
#### And the board has red pieces matching: D12E12k3F12G2H2356
    Successfully validated 12 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3F12G2H2356") (0.0s)


### 11) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.HomeDropCompletingBridgeWinsGame



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:A1kE1345F5G5H5I5        |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5dbd8ef0-9411-39f4-eb9b-ddc996f39edf.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player drops a new piece at e2
    Accepted: @e2

 -&gt; done: ActionSteps.WhenIDrop(Red, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1kE1b2kb3b4b5bF5bG5bH5bI5b
    Successfully validated 10 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1kE1b2kb3b4b5bF5...") (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 12) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.SplitIntoBridgeAvoidsAllCursesIfSplitPiecesAdjacent



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G25+H2356    |
  | B:E8k                     |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ff3696be-88c4-9dc3-f7b8-aed219f754b5.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from g5 to h4
    Accepted: g5-1-h4

 -&gt; done: ActionSteps.WhenISplit(Red, "1", G5, H4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D1b2bE1b2kb3bF1b2bG2b5bH2b3b4b5b6b
    Successfully validated 14 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D1b2bE1b2kb3bF1b2...") (0.0s)


### 13) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.SplitIntoBridgeAvoidsTargetCurseIfTargetPieceAdjacent



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F126++G2H2356   |
  | B:E8k                     |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/739759a2-cf38-4707-eaad-df778518d406.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from f6 to h4
    Accepted: f6-2-h4

 -&gt; done: ActionSteps.WhenISplit(Red, "2", F6, H4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D1b2bE1b2kb3bF1b2b6cG2bH2b3b4b+5b6b
    Successfully validated 14 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D1b2bE1b2kb3bF1b2...") (0.0s)


### 14) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOntoBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12kF12              |
  | B:D78E78k9F78             |
  | X:E3                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/05727d7d-a822-e663-e593-85887fdd5e22.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player drops a new piece at e3
    Rejected: @e3: Location E3 Not Empty

 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### Then the action fails
    Failed with: Location E3 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 15) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOntoOccupiedSpace



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player drops a new piece at e3
    Rejected: @e3: Location E3 Not Empty

 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### Then the action fails
    Failed with: Location E3 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 16) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOutsideZone



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player drops a new piece at e5
    Rejected: @e5: Drop Must Be Adjacent Your Home At E2

 -&gt; done: ActionSteps.WhenIDrop(Red, E5) (0.0s)
#### Then the action fails
    Failed with: Drop Must Be Adjacent Your Home At E2

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 17) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.DropHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player drops a new piece at e3
    Accepted: @e3

 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)


### 18) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.HomeDropBecomesKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E13kF12              |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e0431d0b-1adc-1d00-8381-6904a3edfbbc.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player drops a new piece at e2
    Accepted: @e2

 -&gt; done: ActionSteps.WhenIDrop(Red, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3kF12
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3kF12") (0.0s)


### 19) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.CannotBlockOwnKing



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### When red does Be2
    Rejected: Be2: Cannot Block Red Home at Location E2

 -&gt; done: ActionSteps.WhenDoes(Red, "Be2") (0.0s)
#### Then the action fails
    Failed with: Cannot Block Red Home at Location E2

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 20) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.LoadAPreviouslyCreatedBoard



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I have board WeirdSituation1
    Loaded board WeirdSituation1.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("WeirdSituation1") (0.0s)


### 21) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.LoadASavedBoard



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                       |
  | - |
  | Benediction v1: R E2 B-E8   |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+ |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+ |
  | X:B5C2D4E6F3H6I1            |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)


### 22) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.MergeSplitMergeDoesntCreatePieces



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 onto e3
    Accepted: f2+e3

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E3) (0.0s)
#### And the red player splits 1 piece from e3 onto d2
    Accepted: e3-1-d2

 -&gt; done: ActionSteps.WhenISplit(Red, "1", E3, D2) (0.0s)
#### Then the board has red pieces matching: D12+E12k3F1
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12+E12k3F1") (0.0s)


### 23) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d1",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d1
    Rejected: Bd1: Location D1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D1) (0.0s)
#### Then the action fails
    Failed with: Location D1 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 24) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d2",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d2
    Rejected: Bd2: Location D2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D2) (0.0s)
#### Then the action fails
    Failed with: Location D2 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 25) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e1",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e1
    Rejected: Be1: Location E1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E1) (0.0s)
#### Then the action fails
    Failed with: Location E1 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 26) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e2",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e2
    Rejected: Be2: Location E2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E2) (0.0s)
#### Then the action fails
    Failed with: Location E2 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 27) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e3",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e3
    Rejected: Be3: Location E3 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E3) (0.0s)
#### Then the action fails
    Failed with: Location E3 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 28) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f1",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f1
    Rejected: Bf1: Location F1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F1) (0.0s)
#### Then the action fails
    Failed with: Location F1 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 29) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f2",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f2
    Rejected: Bf2: Location F2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F2) (0.0s)
#### Then the action fails
    Failed with: Location F2 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 30) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d7",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d7
    Rejected: Bd7: Location D7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D7) (0.0s)
#### Then the action fails
    Failed with: Location D7 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 31) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d8",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d8
    Rejected: Bd8: Location D8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D8) (0.0s)
#### Then the action fails
    Failed with: Location D8 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 32) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e7",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e7
    Rejected: Be7: Location E7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E7) (0.0s)
#### Then the action fails
    Failed with: Location E7 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 33) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e8",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e8
    Rejected: Be8: Location E8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E8) (0.0s)
#### Then the action fails
    Failed with: Location E8 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 34) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e9",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e9
    Rejected: Be9: Location E9 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E9) (0.0s)
#### Then the action fails
    Failed with: Location E9 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 35) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f7",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f7
    Rejected: Bf7: Location F7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F7) (0.0s)
#### Then the action fails
    Failed with: Location F7 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 36) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f8",null)



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f8
    Rejected: Bf8: Location F8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F8) (0.0s)
#### Then the action fails
    Failed with: Location F8 Not Empty

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 37) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at e3 to e4
    Accepted: e3e4

 -&gt; done: ActionSteps.WhenIMove(Red, E3, E4) (0.0s)
#### When the red player drops a new piece at e3
    Accepted: @e3

 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### When the blue player blockades c2
    Accepted: Bc2

 -&gt; done: ActionSteps.WhenIBlockade(Blue, C2) (0.0s)
#### When the blue player merges the piece at f7 into e7
    Accepted: f7+e7

 -&gt; done: ActionSteps.WhenIMerge(Blue, F7, E7) (0.0s)
#### When the red player merges the piece at e4 into e3
    Accepted: e4+e3

 -&gt; done: ActionSteps.WhenIMerge(Red, E4, E3) (0.0s)
#### When the red player splits 1 piece from e3 onto d2
    Accepted: e3-1-d2

 -&gt; done: ActionSteps.WhenISplit(Red, "1", E3, D2) (0.0s)


### 38) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves_ShortNotation



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When red does e3e4
    Accepted: e3e4

 -&gt; done: ActionSteps.WhenDoes(Red, "e3e4") (0.0s)
#### When red does @e3
    Accepted: @e3

 -&gt; done: ActionSteps.WhenDoes(Red, "@e3") (0.0s)
#### When blue does Bc2
    Accepted: Bc2

 -&gt; done: ActionSteps.WhenDoes(Blue, "Bc2") (0.0s)
#### When blue does f7+e7
    Accepted: f7+e7

 -&gt; done: ActionSteps.WhenDoes(Blue, "f7+e7") (0.0s)
#### When red does e4+e3
    Accepted: e4+e3

 -&gt; done: ActionSteps.WhenDoes(Red, "e4+e3") (0.0s)
#### When red does e3-1-d2
    Accepted: e3-1-d2

 -&gt; done: ActionSteps.WhenDoes(Red, "e3-1-d2") (0.0s)


### 39) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves_TableNotation



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the following moves are performed:
  | RedAction1 | RedAction2 | BlueAction1 | BlueAction2 |
  | - | - | - | - |
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
    Accepted: f1+f2
    Accepted: f2-1-g2
    Accepted: e8+e9
    Accepted: Bi3
    Accepted: e3+d2
    Accepted: Bb5
    Accepted: f7+f8
    Accepted: f8f7
    Accepted: d2c1
    Accepted: e1f1
    Accepted: Ba2
    Accepted: f7-1-g7
    Accepted: e2e3
    Accepted: d1e1
    Accepted: Bf8
    Accepted: f7g6
    Accepted: Bg1
    Accepted: Bb1
    Accepted: Bd4
    Accepted: d7+e7
    Accepted: f1+e1
    Accepted: f2e2
    Accepted: @d7
    Accepted: d7+d8
    Accepted: @f2
    Accepted: f2+e2
    Accepted: @d7
    Accepted: @e8
    Accepted: @f2
    Accepted: e3+f2
    Accepted: e8+d7
    Accepted: @e8
    Accepted: @d1
    Accepted: @e3
    Accepted: @f7
    Accepted: f7+e8
    Accepted: @f1
    Accepted: @d2
    Accepted: @f7
    Accepted: Bd6

 -&gt; done: ActionSteps.WhenTheFollowingMoves(&lt;table&gt;) (0.0s)


### 40) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.StartFromAnEmptyBoard



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### And I add this red piece: E3k+

 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E3k+") (0.0s)
#### And I add these blue pieces: D45+E56k7F5++++6+b+++7+++++

 -&gt; done: SetupSteps.GivenIAddPieces(Blue, "D45+E56k7F5++++6+...") (0.0s)


### 41) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeAboveStackSizeFifteen



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                                                       |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b27181cc-4da3-da5d-d8d1-f617dc82b43a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e3
    Rejected: f2+e3: Merging Stacks Size 8 and 8 Exceeds 15 Max

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E3) (0.0s)
#### Then the action fails
    Failed with: Merging Stacks Size 8 and 8 Exceeds 15 Max

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player merges the piece at d2 into e2
    Rejected: d2+e2: Merging Stacks Size 15 and 1 Exceeds 15 Max

 -&gt; done: ActionSteps.WhenIMerge(Red, D2, E2) (0.0s)
#### Then the action fails
    Failed with: Merging Stacks Size 15 and 1 Exceeds 15 Max

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player merges the piece at d2 into e3
    Rejected: d2+e3: Merging Stacks Size 15 and 8 Exceeds 15 Max

 -&gt; done: ActionSteps.WhenIMerge(Red, D2, E3) (0.0s)
#### Then the action fails
    Failed with: Merging Stacks Size 15 and 8 Exceeds 15 Max

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player merges the piece at d2 into d1
    Rejected: d2+d1: Merging Stacks Size 15 and 14 Exceeds 15 Max

 -&gt; done: ActionSteps.WhenIMerge(Red, D2, D1) (0.0s)
#### Then the action fails
    Failed with: Merging Stacks Size 15 and 14 Exceeds 15 Max

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player merges the piece at d1 into e1
    Rejected: d1+e1: Merging Stacks Size 14 and 2 Exceeds 15 Max

 -&gt; done: ActionSteps.WhenIMerge(Red, D1, E1) (0.0s)
#### Then the action fails
    Failed with: Merging Stacks Size 14 and 2 Exceeds 15 Max

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 42) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndCursed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F1c2c           |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b53c4abd-3ff0-0046-c86c-c16cf82ad695.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into f1
    Rejected: f2+f1: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 43) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12c            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7702661f-3c93-feed-fda8-45ce88ada492.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e2
    Rejected: f2+e2: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 44) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndNormal



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F1c2            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9f8ddd85-d582-f495-2d03-eb7ea80e8865.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into f1
    Rejected: f2+f1: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 45) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeKingAndKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12k            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3c4d56ad-3a5b-a725-df1c-8a3b2b8fc8d3.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e2
    Rejected: f2+e2: Kings Cannot Merge With Kings

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action fails
    Failed with: Kings Cannot Merge With Kings

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 46) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeAboveSizeTwoRequiresBlessing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player merges the piece at f2 into f1
    Rejected: f2+f1: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### Given I add these red pieces: F2+b
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/53797757-f294-7693-6a53-d191f19b39cf.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "F2+b") (0.0s)
#### When the red player merges the piece at f2 into f1
    Accepted: f2+f1

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF1++
    Successfully validated 5 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF1++") (0.0s)


### 47) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeBlessedAndKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12b+           |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/806c4628-6872-0f9b-9ff1-5461ac27050a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e2
    Accepted: f2+e2

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red three-stack king on e2

 -&gt; done: ValidationSteps.ThenThereShouldBeKing(Red, "three", E2) (0.0s)


### 48) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeCursedAndBlessed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F1c2b           |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4a9df996-ea1d-7e72-f373-673118de7300.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into f1
    Accepted: f2+f1

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3F1+
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3F1+") (0.0s)


### 49) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)


### 50) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeMaximum



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                       |
  | - |
  | Benediction v1: R-E2 B E8   |
  | R:D12E12k3++++++F12b+++++++ |
  | B:D78E78k9F78               |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c0f25e85-cb2b-1fee-037a-4cfeaa26f6ca.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 onto e3
    Accepted: f2+e3

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3++++++++++++++F1
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3+++++++++...") (0.0s)


### 51) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndBlessed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12b            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d4f4fc68-d7e7-8034-7a3b-74193eb59e42.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into f1
    Accepted: f2+f1

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, F1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3F1+
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3F1+") (0.0s)


### 52) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e2
    Accepted: f2+e2

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red two-stack king on e2

 -&gt; done: ValidationSteps.ThenThereShouldBeKing(Red, "two", E2) (0.0s)


### 53) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndKingAboveStackSizeTwoRequiresBlessing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12+            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/958e301d-86b0-3c1f-6675-e2644b1c99c2.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 into e2
    Rejected: f2+e2: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### Given I add this red piece: F2b+
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/806c4628-6872-0f9b-9ff1-5461ac27050a.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "F2b+") (0.0s)
#### When the red player merges the piece at f2 into e2
    Accepted: f2+e2

 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red three-stack king on e2

 -&gt; done: ValidationSteps.ThenThereShouldBeKing(Red, "three", E2) (0.0s)


### 54) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndNormal



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)


### 55) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.BlueCannotMoveThroughBlueWall



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### And the current turn is BlueAction1
    Board flags set to: BlueAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(BlueAction1) (0.0s)
#### When the blue player moves the piece at e9 to e1
    Rejected: e9e1: Stack Size 1 Piece At E9 Cannot Reach E1 (but can reach: E8)

 -&gt; done: ActionSteps.WhenIMove(Blue, E9, E1) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E9 Cannot Reach E1 (but can reach: E8)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at e9 to e5
    Rejected: e9e5: Stack Size 1 Piece At E9 Cannot Reach E5 (but can reach: E8)

 -&gt; done: ActionSteps.WhenIMove(Blue, E9, E5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E9 Cannot Reach E5 (but can reach: E8)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at e9 to a5
    Rejected: e9a5: Stack Size 1 Piece At E9 Cannot Reach A5 (but can reach: D8)

 -&gt; done: ActionSteps.WhenIMove(Blue, E9, A5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E9 Cannot Reach A5 (but can reach: D8)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at f8 to f1
    Rejected: f8f1: Stack Size 1 Piece At F8 Cannot Reach F1 (but can reach: F7)

 -&gt; done: ActionSteps.WhenIMove(Blue, F8, F1) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At F8 Cannot Reach F1 (but can reach: F7)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at f8 to a4
    Rejected: f8a4: Stack Size 1 Piece At F8 Cannot Reach A4 (but can reach: E8)

 -&gt; done: ActionSteps.WhenIMove(Blue, F8, A4) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At F8 Cannot Reach A4 (but can reach: E8)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at d8 to d1
    Rejected: d8d1: Stack Size 1 Piece At D8 Cannot Reach D1 (but can reach: D7)

 -&gt; done: ActionSteps.WhenIMove(Blue, D8, D1) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At D8 Cannot Reach D1 (but can reach: D7)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the blue player moves the piece at d8 to i4
    Rejected: d8i4: Stack Size 1 Piece At D8 Cannot Reach I4 (but can reach: E8)

 -&gt; done: ActionSteps.WhenIMove(Blue, D8, I4) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At D8 Cannot Reach I4 (but can reach: E8)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 56) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CanCaptureEnemyPiece



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F24+            |
  | B:D5+7E78k9F78            |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d41338c3-5a07-b52e-0a73-bb854689c0ad.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at f4 two points to the northwest
    Accepted: f4d5

 -&gt; done: ActionSteps.WhenIMovePointsDirection(Red, F4, "two", "northwest") (0.0s)
#### Then there should be a red two-stack on d5

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "two", D5) (0.0s)
#### And there should not be any blue pieces on d5

 -&gt; done: ValidationSteps.ThenThereShouldNotBeAny(Blue, D5) (0.0s)


### 57) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotCaptureOwnPiece



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F24+            |
  | B:D5+7E78k9F78            |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d41338c3-5a07-b52e-0a73-bb854689c0ad.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at f4 two points to the south
    Rejected: f4f2: Destination F2 Is Your Own Piece and Cannot Be Moved Onto By Red

 -&gt; done: ActionSteps.WhenIMovePointsDirection(Red, F4, "two", "south") (0.0s)
#### Then the action fails
    Failed with: Destination F2 Is Your Own Piece and Cannot Be Moved Onto By Red

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 58) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotDepartEdgeOfBoard



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3H2+             |
  | B:B5+E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8fbbd754-a763-04be-d790-14795642a78a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at h2 two points to the northeast
    Unable to reach point 2 northeast from I2 (starting from H2)

 -&gt; done: ActionSteps.WhenIMovePointsDirection(Red, H2, "two", "northeast") (0.0s)
#### Then the action fails
    Failed with: Unable to reach point 2 northeast from I2 (starting from H2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 59) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotMoveOntoBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F24+            |
  | B:D5+7E78k9F78            |
  | X:E5G3                    |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b1dbf9f7-46b7-4600-43f7-89f3ead81c5e.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at f4 to e5
    Rejected: f4e5: Destination E5 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: ActionSteps.WhenIMove(Red, F4, E5) (0.0s)
#### Then the action fails
    Failed with: Destination E5 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### Given the current turn is BlueAction1
    Board flags set to: BlueAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(BlueAction1) (0.0s)
#### When the blue player moves the piece at d5 to e5
    Rejected: d5e5: Destination E5 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: ActionSteps.WhenIMove(Blue, D5, E5) (0.0s)
#### Then the action fails
    Failed with: Destination E5 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 60) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotMoveOverBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F24+            |
  | B:D5+7E78k9F78            |
  | X:E5G3                    |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b1dbf9f7-46b7-4600-43f7-89f3ead81c5e.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at f4 two points to the northwest
    Rejected: f4d5: Stack Size 2 Piece At F4 Cannot Reach D5 (but can reach: )

 -&gt; done: ActionSteps.WhenIMovePointsDirection(Red, F4, "two", "northwest") (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At F4 Cannot Reach D5 (but can reach: )

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 61) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.MoveThroughWallIsAssumedIfPossible



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B=E8 |
  | R:D12E12k3H4+++           |
  | B:B3+++D8E8k9F78          |
  | X:E5F6G3                  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ede23154-af5e-5f21-ec9e-aef50f0f5630.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece at b3 to b5
    Accepted: b3b5

 -&gt; done: ActionSteps.WhenIMove(Blue, B3, B5) (0.0s)
#### Then there should be a blue four-stack with a blessing on b5

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Blue, "four", B5) (0.0s)


### 62) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RedCannotMoveThroughRedWall



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player moves the piece at e1 to e9
    Rejected: e1e9: Stack Size 1 Piece At E1 Cannot Reach E9 (but can reach: E2)

 -&gt; done: ActionSteps.WhenIMove(Red, E1, E9) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E1 Cannot Reach E9 (but can reach: E2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at e1 to i1
    Rejected: e1i1: Stack Size 1 Piece At E1 Cannot Reach I1 (but can reach: F1)

 -&gt; done: ActionSteps.WhenIMove(Red, E1, I1) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E1 Cannot Reach I1 (but can reach: F1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at e1 to a1
    Rejected: e1a1: Stack Size 1 Piece At E1 Cannot Reach A1 (but can reach: D1)

 -&gt; done: ActionSteps.WhenIMove(Red, E1, A1) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E1 Cannot Reach A1 (but can reach: D1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at f1 to f8
    Rejected: f1f8: Stack Size 1 Piece At F1 Cannot Reach F8 (but can reach: F2)

 -&gt; done: ActionSteps.WhenIMove(Red, F1, F8) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At F1 Cannot Reach F8 (but can reach: F2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at f1 to a2
    Rejected: f1a2: Stack Size 1 Piece At F1 Cannot Reach A2 (but can reach: E2)

 -&gt; done: ActionSteps.WhenIMove(Red, F1, A2) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At F1 Cannot Reach A2 (but can reach: E2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at d1 to i2
    Rejected: d1i2: Stack Size 1 Piece At D1 Cannot Reach I2 (but can reach: E2)

 -&gt; done: ActionSteps.WhenIMove(Red, D1, I2) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At D1 Cannot Reach I2 (but can reach: E2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player moves the piece at d1 to d8
    Rejected: d1d8: Stack Size 1 Piece At D1 Cannot Reach D8 (but can reach: D2)

 -&gt; done: ActionSteps.WhenIMove(Red, D1, D8) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At D1 Cannot Reach D8 (but can reach: D2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 63) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RepeatMovesNotAllowed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player moves the piece at e3 to e4
    Accepted: e3e4

 -&gt; done: ActionSteps.WhenIMove(Red, E3, E4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player moves the piece at e4 to e5
    Rejected: e4e5: Piece at E4 Has Already Moved This Turn

 -&gt; done: ActionSteps.WhenIMove(Red, E4, E5) (0.0s)
#### Then the action fails
    Failed with: Piece at E4 Has Already Moved This Turn

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 64) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.BlessedStackLosesBlessingUponSplit_Merge



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3b+4F12          |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/90f1bf85-451b-8170-2c3d-7e90f7a0b854.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from e3 onto e4
    Accepted: e3-1-e4

 -&gt; done: ActionSteps.WhenISplit(Red, "1", E3, E4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red two-stack on e4

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "two", E4) (0.0s)
#### And there should be a red blessed one-stack on e3

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "one", E3) (0.0s)


### 65) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeBlessedStackOntoKingOverStackSizeTwo



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5kF12         |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e7694483-1fbe-7f94-5cc0-ffa5a5a36390.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Rejected: e3-2-e5: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 66) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeBlessedStackOntoRegularPieceOverStackSizeTwo



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5F12          |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/97f9baab-af54-0698-1fbb-9749bf638fb2.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Rejected: e3-2-e5: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 67) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoCursedPiece



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3cF12            |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/da04bbbe-3ff9-839a-1207-25b2625b9b93.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f1 into f2
    Accepted: f1+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, F1, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player splits 1 piece from f2 onto e3
    Rejected: f2-1-e3: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenISplit(Red, "1", F2, E3) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 68) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoKingOverStackSizeTwo



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5kF12         |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e7694483-1fbe-7f94-5cc0-ffa5a5a36390.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Rejected: e3-2-e5: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 69) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoRegularPieceOverStackSizeTwo



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5F12          |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/97f9baab-af54-0698-1fbb-9749bf638fb2.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Rejected: e3-2-e5: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Blessed Piece (From Passing Opponent Wall) Required On Either Piece to Merge Above Stack Size Two

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 70) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOverBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5bF12         |
  | B:D78E78k9F78             |
  | X:E4                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/958ad4d6-8e2f-9ad0-14c7-fbbb8fa53814.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Rejected: e3-2-e5: Stack Size 2 Piece At E3 Cannot Reach E5 (but can reach: E2, E1)

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At E3 Cannot Reach E5 (but can reach: E2, E1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 71) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureCannotMoveOverBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12+++          |
  | B:D78E78k9F478            |
  | X:F3                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0fdeee82-abf5-deb7-0300-f0e22b1e77e1.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from f2 onto f4
    Rejected: f2-2-f4: Stack Size 2 Piece At F2 Cannot Reach F4 (but can reach: F1)

 -&gt; done: ActionSteps.WhenISplit(Red, "2", F2, F4) (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At F2 Cannot Reach F4 (but can reach: F1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 72) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:D12E12k6+F1             |
  | B:D78E78k9F5+             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/083b4731-de09-b68b-edca-be011f3f1734.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from e6 onto e7
    Accepted: e6-1-e7

 -&gt; done: ActionSteps.WhenISplit(Red, "1", E6, E7) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k6c7cF1
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k6c7cF1") (0.0s)


### 73) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeBlessedStackOntoBlessedPieceOverStackSizeTwo



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3++5bF12         |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/cdf35cd1-194b-6b99-2212-15a192c33114.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from e3 onto e5
    Accepted: e3-2-e5

 -&gt; done: ActionSteps.WhenISplit(Red, "2", E3, E5) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red three-stack on e5

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "three", E5) (0.0s)
#### And there should be a red one-stack on e3

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "one", E3) (0.0s)


### 74) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### And the red player splits 1 piece from f2 onto f1
    Accepted: f2-1-f1

 -&gt; done: ActionSteps.WhenISplit(Red, "1", F2, F1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF1+2
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF1+2") (0.0s)


### 75) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeLeavesCorrectlySizedStacks



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I have board LargeStacks
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b27181cc-4da3-da5d-d8d1-f617dc82b43a.png?raw=true)

    Loaded board LargeStacks.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("LargeStacks") (0.0s)
#### When the red player splits 6 pieces from f2 onto e3
    Accepted: f2-6-e3

 -&gt; done: ActionSteps.WhenISplit(Red, "6", F2, E3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red fourteen-stack on e3

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "fourteen", E3) (0.0s)
#### And there should be a red blessed two-stack on f2

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "two", F2) (0.0s)
#### When the red player splits 1 piece from d2 onto d1
    Accepted: d2-1-d1

 -&gt; done: ActionSteps.WhenISplit(Red, "1", D2, D1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red blessed fourteen-stack on d2

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "fourteen", D2) (0.0s)
#### And there should be a red fifteen-stack on d1

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "fifteen", D1) (0.0s)


### 76) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCannotMoveOntoBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12+            |
  | B:D78E78k9F78             |
  | X:F3                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/711fb733-d785-fbc3-1893-0cc2a94a70b7.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from f2 onto f3
    Rejected: f2-1-f3: Stack Size 1 Piece At F2 Cannot Reach F3 (but can reach: F1)

 -&gt; done: ActionSteps.WhenISplit(Red, "1", F2, F3) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At F2 Cannot Reach F3 (but can reach: F1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 77) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCannotMoveOverBlock



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12+++          |
  | B:D78E78k9F78             |
  | X:F3                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9214908a-331a-3963-c909-f228add6e256.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from f2 onto f4
    Rejected: f2-2-f4: Stack Size 2 Piece At F2 Cannot Reach F4 (but can reach: F1)

 -&gt; done: ActionSteps.WhenISplit(Red, "2", F2, F4) (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At F2 Cannot Reach F4 (but can reach: F1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 78) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCursesBothPieces



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at f1 into f2
    Accepted: f1+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, F1, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player splits 1 piece from f2 onto f3
    Accepted: f2-1-f3

 -&gt; done: ActionSteps.WhenISplit(Red, "1", F2, F3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k3F2c3c
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k3F2c3c") (0.0s)


### 79) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveHappyPath



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### When the red player merges the piece at e3 into f2
    Accepted: e3+f2

 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### And the red player splits 1 piece from f2 onto f3
    Accepted: f2-1-f3

 -&gt; done: ActionSteps.WhenISplit(Red, "1", F2, F3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF12c3c
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF12c3c") (0.0s)


### 80) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.SplitDistanceCannotExceedSize



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D1b+2b+++E1+2k3b+F12b++ |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/243dfa3c-2851-2afd-5fc7-2439d05ea9b3.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from e3 onto e5
    Rejected: e3-1-e5: Stack Size 1 Piece At E3 Cannot Reach E5 (but can reach: E4, E2)

 -&gt; done: ActionSteps.WhenISplit(Red, "1", E3, E5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At E3 Cannot Reach E5 (but can reach: E4, E2)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 2 pieces from f2 onto f5
    Rejected: f2-2-f5: Stack Size 2 Piece At F2 Cannot Reach F5 (but can reach: F3, F4, F1)

 -&gt; done: ActionSteps.WhenISplit(Red, "2", F2, F5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At F2 Cannot Reach F5 (but can reach: F3, F4, F1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 1 piece from d2 onto d4
    Rejected: d2-1-d4: Stack Size 1 Piece At D2 Cannot Reach D4 (but can reach: D3, D1)

 -&gt; done: ActionSteps.WhenISplit(Red, "1", D2, D4) (0.0s)
#### Then the action fails
    Failed with: Stack Size 1 Piece At D2 Cannot Reach D4 (but can reach: D3, D1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 2 pieces from d2 onto d5
    Rejected: d2-2-d5: Stack Size 2 Piece At D2 Cannot Reach D5 (but can reach: D3, D4, D1)

 -&gt; done: ActionSteps.WhenISplit(Red, "2", D2, D5) (0.0s)
#### Then the action fails
    Failed with: Stack Size 2 Piece At D2 Cannot Reach D5 (but can reach: D3, D4, D1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 3 pieces from d2 onto d6
    Rejected: d2-3-d6: Stack Size 3 Piece At D2 Cannot Reach D6 (but can reach: D3, D4, D5, D1)

 -&gt; done: ActionSteps.WhenISplit(Red, "3", D2, D6) (0.0s)
#### Then the action fails
    Failed with: Stack Size 3 Piece At D2 Cannot Reach D6 (but can reach: D3, D4, D5, D1)

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 81) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.SplitMustRejectInvalidSizes



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I define board LargeStacks as:
  | New Game Board                                              |
  | - |
  | Benediction v1: R-E2 B E8                                   |
  | R:D1b+++++++++++++2b++++++++++++++E1+2k3b+++++++F12b+++++++ |
  | B:D78E78k9F78                                               |

 -&gt; done: SetupSteps.GivenIDefine("LargeStacks", &lt;table&gt;) (0.0s)
#### Given I have board LargeStacks
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b27181cc-4da3-da5d-d8d1-f617dc82b43a.png?raw=true)

    Loaded board LargeStacks.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("LargeStacks") (0.0s)
#### When the red player splits 0 pieces from d2 onto d3
    Rejected: d2-0-d3: Must Split At Least One Piece

 -&gt; done: ActionSteps.WhenISplit(Red, "0", D2, D3) (0.0s)
#### Then the action fails
    Failed with: Must Split At Least One Piece

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 15 pieces from d2 onto d3
    Rejected: d2-15-d3: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ActionSteps.WhenISplit(Red, "15", D2, D3) (0.0s)
#### Then the action fails
    Failed with: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits -47 pieces from d2 onto d3
    Rejected: d2--47-d3: Must Split At Least One Piece

 -&gt; done: ActionSteps.WhenISplit(Red, "-47", D2, D3) (0.0s)
#### Then the action fails
    Failed with: Must Split At Least One Piece

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 8675309 pieces from d2 onto d3
    Rejected: d2-8675309-d3: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ActionSteps.WhenISplit(Red, "8675309", D2, D3) (0.0s)
#### Then the action fails
    Failed with: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player splits 16 pieces from d2 onto d3
    Rejected: d2-16-d3: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ActionSteps.WhenISplit(Red, "16", D2, D3) (0.0s)
#### Then the action fails
    Failed with: Must Leave At Least One Piece Behind When Splitting

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 82) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueCapturingAnyRedKingCausesBlueWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:D123k+F3+H2+            |
  | B:B3kC3kD5+E9F78          |
  | X:B2D4F4                  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c8116771-c3f4-75f5-bf58-7b447e3a9a69.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece at c3 to d3
    Accepted: c3d3

 -&gt; done: ActionSteps.WhenIMove(Blue, C3, D3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 83) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueFormingChainWithKingCausesBlueWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B=E8 |
  | R:D123k+E4c5cF5cG2c5cH2c  |
  | B:A1c2cB3k4k5C6D8+E9F8+   |
  | X:B2C7D4F246H3I4          |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9ea9e8d6-a1d0-4495-c5dc-8d8b3c1e69d9.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player places a piece at d7
    Accepted: @d7

 -&gt; done: ActionSteps.WhenIDrop(Blue, D7) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 84) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueJoiningKingToExistingChainCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:E3k+I1b2b3b+4c5c        |
  | B:A1c2c3b4b5b+D7k+        |
  | X:E46G36H4                |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8b800dd1-ec24-16ac-735a-dc4f0f7ef122.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece from d7 to b5
    Accepted: d7b5

 -&gt; done: ActionSteps.WhenIMove(Blue, D7, B5) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 85) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueKingPassingRedWallCausesBlueWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:D12F2k+3+H2+            |
  | B:A2k+D5+E9F78            |
  | X:B2D4F4                  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3f5ddc1e-8e47-da49-a23e-f3ef026b2d9b.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece at a2 to a5
    Accepted: a2a5

 -&gt; done: ActionSteps.WhenIMove(Blue, A2, A5) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 86) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueMovingBlessedPieceOntoBlueHomeDoesNotCauseWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:E3k+G1b+2bI2b4c5c       |
  | B:A1c2c3b4bD7b+F8k+       |
  | X:A5E46G36H4              |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/63866e13-9e9f-89f1-3959-07b948680269.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece from d7 to e8
    Accepted: d7e8

 -&gt; done: ActionSteps.WhenIMove(Blue, D7, E8) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a blue king on e8 without any blessing

 -&gt; done: ValidationSteps.ThenThereShouldBeKingNoSize(Blue, E8) (0.0s)


### 87) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueMovingBlessedPieceOntoRedHomeDoesNotCauseWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:F2b7b+G2k+H3bI4c5c      |
  | B:A2c3bB3c5+D2b+F8k+      |
  | X:A5E46G36H4              |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/fa13918f-6e08-68ff-ab7d-e8544d4dc0ca.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves a piece from d2 to e2
    Accepted: d2e2

 -&gt; done: ActionSteps.WhenIMove(Blue, D2, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a blue king on e2 without any blessing

 -&gt; done: ValidationSteps.ThenThereShouldBeKingNoSize(Blue, E2) (0.0s)


### 88) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueWinWithNoLegalMovesCausesBlueWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:A2kD7cE12k78k9cF17c     |
  | B:B3k                     |
  | X:A135C16D358F358G16H2I35 |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f3a2c92e-812c-52dd-ff18-18565b86461e.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece from b3 to a2
    Accepted: b3a2

 -&gt; done: ActionSteps.WhenIMove(Blue, B3, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 89) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueWithNoLegalMovesCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:D7cE12k78k9cF17c        |
  | B:B3k                     |
  | X:A135C16D358F358G16H2I35 |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1e6f0f06-4f4e-8fcd-3feb-04836898d9b3.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece from b3 to a2
    Accepted: b3a2

 -&gt; done: ActionSteps.WhenIMove(Blue, B3, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 90) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedCapturingAnyBlueKingCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:D123k+F3+H2+            |
  | B:B3kC3kD5+E9F78          |
  | X:B2D4F4                  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a3d29f2e-1f9d-678c-d278-479789a56236.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at d3 to c3
    Accepted: d3c3

 -&gt; done: ActionSteps.WhenIMove(Red, D3, C3) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 91) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedFormingChainWithKingCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:D123k+E4c5cF5cG5cH5+    |
  | B:B3k4k5+D78+E79F8+       |
  | X:B2C7D4F46               |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/54f2d19a-b7dc-8c06-51c9-e1918c2d789c.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits one piece from h5 to h6
    Accepted: h5-1-h6

 -&gt; done: ActionSteps.WhenISplit(Red, "one", H5, H6) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 92) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedJoiningKingToExistingChainCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:F2k+I1b2b3b+4c5c        |
  | B:A1c2c4+5+E8k            |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/73e536a4-58dd-be12-6ab9-ca9fb255fb87.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece from f2 to h2
    Accepted: f2h2

 -&gt; done: ActionSteps.WhenIMove(Red, F2, H2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 93) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedKingPassingBlueWallCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12I5k          |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a35f5ddf-3147-68bb-07d0-8fb31d7ae121.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at i5 to a1
    Accepted: i5a1

 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 94) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedMovingBlessedPieceOntoBlueHomeDoesNotCauseWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:F2b7b+G2k+H3bI4c5c      |
  | B:A2c3bB3c5+D2b+F8k+      |
  | X:A5E46G36H4              |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a01356fd-0b57-499b-9115-447d239b9b15.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves a piece from f7 to e8
    Accepted: f7e8

 -&gt; done: ActionSteps.WhenIMove(Red, F7, E8) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red king on e8 without any blessing

 -&gt; done: ValidationSteps.ThenThereShouldBeKingNoSize(Red, E8) (0.0s)


### 95) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedMovingBlessedPieceOntoRedHomeDoesNotCauseWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:C2b+D123E13F12k         |
  | B:C5+D7E7+8kF8+           |
  | X:B6D6F5H3                |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/92ef29dd-3c2d-f1ce-9784-f077e3e82580.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece from c2 to e2
    Accepted: c2e2

 -&gt; done: ActionSteps.WhenIMove(Red, C2, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a two-stack king on e2 without any blessing

 -&gt; done: ValidationSteps.ThenThereShouldBeKingNoColor("two", E2) (0.0s)


### 96) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedWinWithNoLegalMovesCausesRedWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:A1k                     |
  | B:A2kD2+E1k2k3c8k9F2c7    |
  | X:B246D168E4F18G35H16I24  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/91ba6995-571f-b17a-cd80-5195f4410037.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece from a1 to a2
    Accepted: a1a2

 -&gt; done: ActionSteps.WhenIMove(Red, A1, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 97) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedWithNoLegalMovesCausesBlueWin



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:A1k                     |
  | B:D2+E1k2k3c8k9F2c7       |
  | X:B246D168E4F18G35H16I24  |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/46ba263a-50e8-1cad-30a6-9d5e65d65db0.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece from a1 to a2
    Accepted: a1a2

 -&gt; done: ActionSteps.WhenIMove(Red, A1, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 98) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndMergingCanFormAnyStackSize



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                        |
  | - |
  | Benediction v1: R-E2 B E8    |
  | R:A2c++D12E12k3F12G1+7bH6b++ |
  | B:D78E78k9F78                |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/84c371e4-c3dd-4528-e515-1caa429f5727.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at g7 onto g1
    Accepted: g7+g1

 -&gt; done: ActionSteps.WhenIMerge(Red, G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red three-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "three", G1) (0.0s)
#### When the red player merges the piece at h6 onto a2
    Accepted: h6+a2

 -&gt; done: ActionSteps.WhenIMerge(Red, H6, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red six-stack on a2

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "six", A2) (0.0s)


### 99) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndSplittingCompletingBridgeLeavesBless_BlessPair



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G7b+++       |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d626313b-869a-8237-edf8-f3609360a087.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from g7 onto g1
    Accepted: g7-2-g1

 -&gt; done: ActionSteps.WhenISplit(Red, "2", G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red cursed two-stack on g7

 -&gt; done: ValidationSteps.ThenThereShouldBeCursed(Red, "two", G7) (0.0s)
#### And there should be a red blessed two-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "two", G1) (0.0s)


### 100) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndSplittingLeavesBless_CursePair



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G7b+++       |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d626313b-869a-8237-edf8-f3609360a087.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from g7 onto g1
    Accepted: g7-2-g1

 -&gt; done: ActionSteps.WhenISplit(Red, "2", G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red cursed two-stack on g7

 -&gt; done: ValidationSteps.ThenThereShouldBeCursed(Red, "two", G7) (0.0s)
#### And there should be a red blessed two-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "two", G1) (0.0s)


### 101) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundMergingOntoHomeBecomesKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:C1+E2k5+9b+             |
  | B:B6+C3+4k+               |
  | X:A35B2D4                 |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/52f1d9c2-59cc-8f43-5f64-989b684fd5f3.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at e9 onto e2
    Accepted: e9+e2

 -&gt; done: ActionSteps.WhenIMerge(Red, E9, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching C1+E2k++5+
    Successfully validated 3 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "C1+E2k++5+") (0.0s)


### 102) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundOntoHomeBecomesKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:C1+D2kE5+9b+            |
  | B:B6+C3+4k+               |
  | X:A35B2D4                 |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/bee7a4ab-739a-25dd-cce0-af0f6bc8aa5c.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at e9 to e2
    Accepted: e9e2

 -&gt; done: ActionSteps.WhenIMove(Red, E9, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching C1+D2kE2k+5+
    Successfully validated 4 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "C1+D2kE2k+5+") (0.0s)


### 103) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundRemainsBlessed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### And I add this red piece: I5b
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4b58034c-f49e-02d9-afaa-c7b264068cc2.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "I5b") (0.0s)
#### When the red player moves the piece at i5 to a1
    Accepted: i5a1

 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1bD12E12k3F12
    Successfully validated 8 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1bD12E12k3F12") (0.0s)


### 104) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndMergingRequiresBlessedTarget



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:A4b+D128k++E137cF128c   |
  | B:A1k2cB1k3cC2c3cD7F7     |
  | X:A35B2D46F4H246          |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/baa7ac0a-3f11-78ac-f80a-a2dd502e2eb4.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece on f8 to f1
    Rejected: f8+f1: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenIMerge(Red, F8, F1) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)
#### When the red player merges the piece on f8 to a4
    Accepted: f8+a4

 -&gt; done: ActionSteps.WhenIMerge(Red, F8, A4) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching A4++D128k++E137cF12
    Successfully validated 9 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A4++D128k++E137cF12") (0.0s)


### 105) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndSplitMergingRequiresBlessedTarget



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G17c+++      |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0c66e7eb-b20e-e7ae-4355-9c8c70d7940a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from g7 onto g1
    Rejected: g7-1-g1: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ActionSteps.WhenISplit(Red, "1", G7, G1) (0.0s)
#### Then the action fails
    Failed with: Cursed Pieces Can Only Merge With Blessed Pieces

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 106) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndSplittingRemainsCursed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G7c+++       |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/14834f1a-0949-c832-9dfe-9169816ff274.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from g7 onto g1
    Accepted: g7-2-g1

 -&gt; done: ActionSteps.WhenISplit(Red, "2", G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red cursed two-stack on g7

 -&gt; done: ValidationSteps.ThenThereShouldBeCursed(Red, "two", G7) (0.0s)
#### And there should be a red cursed two-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBeCursed(Red, "two", G1) (0.0s)


### 107) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundOntoHomeBecomesKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D1+3E3k+7c9c+           |
  | B:B4C3+6c7cD68G5k         |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d973474a-a16c-9a07-4e99-2bb1e850a26d.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at e9 to e2
    Accepted: e9e2

 -&gt; done: ActionSteps.WhenIMove(Red, E9, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D1+3E2k+3k+7c
    Successfully validated 5 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D1+3E2k+3k+7c") (0.0s)


### 108) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundRemainsCursed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### And I add this red piece: I5c
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b58cce8c-0fb0-0879-1fcd-45fcc2b5395d.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "I5c") (0.0s)
#### When the red player moves the piece at i5 to a1
    Accepted: i5a1

 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1cD12E12k3F12
    Successfully validated 8 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1cD12E12k3F12") (0.0s)


### 109) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingWrappingAroundOntoHomeWinsGame



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R=E2 B E8 |
  | R:E7+8k++                 |
  | B:B3+6+C1k2k              |
  | X:A35B2D46                |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/539e5cea-5e4f-6fae-2925-ff3447268740.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece on e8 to e2
    Accepted: e8e2

 -&gt; done: ActionSteps.WhenIMove(Red, E8, E2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 110) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingWrappingAroundOntoRegularSpaceWinsGame



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:E7+H5k++                |
  | B:B6+C1k2k3+              |
  | X:A35B2D4                 |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/29ed879d-c90c-0446-8e3a-c0dc90933b77.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece on c1 to c7
    Accepted: c1c7

 -&gt; done: ActionSteps.WhenIMove(Blue, C1, C7) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and blue has won

 -&gt; done: ValidationSteps.GameOver(Blue) (0.0s)


### 111) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.NormalPieceWrappingAroundBecomesBlessed



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I have board NewGame
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

    Loaded board NewGame.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("NewGame") (0.0s)
#### And I add this red piece: I5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a1573ad0-761c-3260-c032-2f426d00808a.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "I5") (0.0s)
#### When the red player moves the piece at i5 to a1
    Accepted: i5a1

 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1bD12E12k3F12
    Successfully validated 8 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1bD12E12k3F12") (0.0s)


### 112) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.NormalPieceWrappingAroundOntoHomeBecomesKing



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board
  | Board                     |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:E2k+3k+47cG4+           |
  | B:B4C6c7cD678E1+H4k       |
  | X:G3                      |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a1f2b0ad-7167-6a41-119f-db58b3102384.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the blue player moves the piece at e1 to e8
    Accepted: e1e8

 -&gt; done: ActionSteps.WhenIMove(Blue, E1, E8) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has blue pieces matching B4C6c7cD678E8k+H4k
    Successfully validated 8 Blue pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Blue, "B4C6c7cD678E8k+H4k") (0.0s)


### 113) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndMergingCanFormAnyStackSize



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                      |
  | - |
  | Benediction v1: R-E2 B E8  |
  | R:A2c++D12E12k3F12G1+7H6++ |
  | B:D78E78k9F78              |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/efee6de3-9e9c-985e-0628-cdc038d37d8b.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at g7 onto g1
    Accepted: g7+g1

 -&gt; done: ActionSteps.WhenIMerge(Red, G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red three-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "three", G1) (0.0s)
#### When the red player merges the piece at h6 onto a2
    Accepted: h6+a2

 -&gt; done: ActionSteps.WhenIMerge(Red, H6, A2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red six-stack on a2

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "six", A2) (0.0s)


### 114) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndSplitMergingCanFormAnyStackSize



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:A1+D12E12k3F12I5+       |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8de9cecb-7517-e470-faee-b8ed424e74e4.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from i5 onto a1
    Accepted: i5-1-a1

 -&gt; done: ActionSteps.WhenISplit(Red, "1", I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red one-stack on i5

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "one", I5) (0.0s)
#### And there should be a red three-stack on a1

 -&gt; done: ValidationSteps.ThenThereShouldBe(Red, "three", A1) (0.0s)


### 115) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndSplittingLeavesBless_CursePair



#### Given I define board NewGame as:
  | New Game Board            |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12             |
  | B:D78E78k9F78             |

 -&gt; done: SetupSteps.GivenIDefine("NewGame", &lt;table&gt;) (0.0s)
#### Given I load this board:
  | Board                     |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:D12E12k3F12G7+++        |
  | B:D78E78k9F78             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ae297736-9a54-9011-f334-4c1856a8fd9e.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 2 pieces from g7 onto g1
    Accepted: g7-2-g1

 -&gt; done: ActionSteps.WhenISplit(Red, "2", G7, G1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And there should be a red cursed two-stack on g7

 -&gt; done: ValidationSteps.ThenThereShouldBeCursed(Red, "two", G7) (0.0s)
#### And there should be a red blessed two-stack on g1

 -&gt; done: ValidationSteps.ThenThereShouldBeBlessed(Red, "two", G1) (0.0s)


## Run Settings

    DefaultTimeout: 

    WorkDirectory: F:\src\BenedictionGame\testruns\latest

    ImageRuntimeVersion: 4.0.30319

    ImageTargetFrameworkName: .NETFramework,Version=v4.7.1

    ImageRequiresX86: False

    ImageRequiresDefaultAppDomainAssemblyResolver: False

    NumberOfTestWorkers: 12

## Test Run Summary 

 Overall result: Passed

 Test Count: 118, Passed: 115, Failed: 0, Inconclusive: 3, Skipped: 0

 Start time: 2020-02-08 19:21:41Z

   End time: 2020-02-08 19:21:45Z

   Duration: 3.298 seconds

