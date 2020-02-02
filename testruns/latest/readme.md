## Runtime Environment 

   OS Version: Microsoft Windows NT 10.0.17134.0

  CLR Version: 4.0.30319.42000

NUnit Version: 3.10.0.0

## Test Files 

    F:\src\BenedictionGame\src\Testing\Specflow\bin\Debug\Testing.Specflow.dll

## Errors and Failures

### 1) Failed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundRemainsCursed

The following board locations had different contents than expected:
At A1: Expected Size1, SideRed, Cursed, Got Size1, SideRed, Blessed, Cursed


   at Testing.Specflow.Common.CommonSteps.ThenTheBoardHasPiecesMatching(ActionSide side, String definition) in F:\src\BenedictionGame\src\Testing\SpecFlow\Common\CommonSteps.cs:line 106
       at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan&amp; duration) in D:\a\1\s\TechTalk.SpecFlow\Bindings\BindingInvoker.cs:line 69
       at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments) in D:\a\1\s\TechTalk.SpecFlow\Infrastructure\TestExecutionEngine.cs:line 517
       at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(IContextManager contextManager, StepInstance stepInstance) in D:\a\1\s\TechTalk.SpecFlow\Infrastructure\TestExecutionEngine.cs:line 422
       at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep() in D:\a\1\s\TechTalk.SpecFlow\Infrastructure\TestExecutionEngine.cs:line 256
       at Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.ScenarioCleanup()
       at Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundRemainsCursed() in F:\src\BenedictionGame\src\Testing\SpecFlow\Features\GameRules\WrapAroundRules.feature:line 22
    

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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b02d8913-a425-38b9-8854-7b382e9e6660-A1-I5.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1cD12E12k3F12
    Successfully validated 7 Red pieces.

 -&gt; error: The following board locations had different contents than expected:
    At A1: Expected Size1, SideRed, Cursed, Got Size1, SideRed, Blessed, Cursed
    


## Tests Which Passed

### 1) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.MovingNorthWithoutWrappingAround("E5","E6",null)



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/99732cc7-6515-ffb2-b253-95c12d9dd6a6.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E5") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E5 to E6
    Accepted: e5e6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a7e5a64-8d70-7c87-dd5a-8033eac31e00-E5-E6.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, E5, E6) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E6
    Successfully validated 1 Red piece.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E6") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 2) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.MovingNorthWithoutWrappingAround("E4","E5",null)



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f977260b-db80-81ff-874f-cf6bc707b0dc.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E4") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E4 to E5
    Accepted: e4e5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f2a17dbc-ea88-715b-c29d-547ce78ff822-E4-E5.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, E4, E5) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E5
    Successfully validated 1 Red piece.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E5") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 3) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.SingleMoveNorth



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: SetupSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/99732cc7-6515-ffb2-b253-95c12d9dd6a6.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E5") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E5 to E6
    Accepted: e5e6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a7e5a64-8d70-7c87-dd5a-8033eac31e00-E5-E6.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, E5, E6) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E6
    Successfully validated 1 Red piece.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E6") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 4) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e5c4514c-8802-69fd-4f37-202fa92f03ef-A1.png?raw=true)


 -&gt; done: ActionSteps.WhenIBlockade(Red, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has blocks matching: A1
    Successfully validated 1 block.

 -&gt; done: CommonSteps.ThenTheBoardHasBlocksMatching("A1") (0.0s)


### 5) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockMaximum



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
  | Bd2        | Bf2        | Be1         | Be9         |
  | Bd7        | Bf7        | Bb6         | Bc5         |
  | Ba4        | Bg5        | Bh6         | Bi4         |
  | Bg3        | Bh1        | Bi2         | Bc3         |
  | Bb1        | Ba2        | Be6         | Be4         |
    Accepted: Bd2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7984a007-2498-ec86-293c-638dcd7f4904-D2.png?raw=true)

    Accepted: Bf2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0b4d0cd9-431b-4457-e1f2-c7848684822d-F2.png?raw=true)

    Accepted: Be1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/397aa385-a656-c736-2aeb-735614b775b5-E1.png?raw=true)

    Accepted: Be9
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c665e17f-24ba-77bd-cc15-2ca775d17faf-E9.png?raw=true)

    Accepted: Bd7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3966703c-bf98-4c0a-6435-a3b87b0e3cf1-D7.png?raw=true)

    Accepted: Bf7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8cafa76e-7420-3556-9aca-6d2114d9e333-F7.png?raw=true)

    Accepted: Bb6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/55bde147-30e1-59c6-3420-4149aa00bcba-B6.png?raw=true)

    Accepted: Bc5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/be0d15be-5426-3d22-53d4-e43bdf5ceb83-C5.png?raw=true)

    Accepted: Ba4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/029566ff-30c0-c0d2-d1c9-a7f7c00261e4-A4.png?raw=true)

    Accepted: Bg5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/25cc0394-003c-6b5b-e5a9-f429b04f3821-G5.png?raw=true)

    Accepted: Bh6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4ec9d589-d95e-5b7c-5486-c8791d542420-H6.png?raw=true)

    Accepted: Bi4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4ccddfda-5b2b-fca7-7201-df449503d573-I4.png?raw=true)

    Accepted: Bg3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/68ad6e35-73cb-2ce9-bdac-c4c4e041500a-G3.png?raw=true)

    Accepted: Bh1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/58f58c4a-f2d9-5e5c-71bc-1c273473ab1a-H1.png?raw=true)

    Accepted: Bi2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f9b6d123-09b2-adb2-cf37-bbbcb6e18af3-I2.png?raw=true)

    Accepted: Bc3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1c5a59f4-1915-c3fb-1833-5b68d66fca9c-C3.png?raw=true)

    Accepted: Bb1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/68b93422-6668-fe2b-463c-123ef13aec1c-B1.png?raw=true)

    Accepted: Ba2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c875f2da-0c42-39c7-29e2-da23aafb95fb-A2.png?raw=true)

    Accepted: Be6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0f17b7eb-ff6d-6b64-fd2b-8a2e2c8c63b9-E6.png?raw=true)

    Accepted: Be4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5be7070c-b19f-276f-bbdf-d214f222b5d3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenTheFollowingMoves(&lt;table&gt;) (0.0s)
#### Then the board has blocks matching: A24B16C35D27E1469F27G35H16I24
    Successfully validated 20 blocks.

 -&gt; done: CommonSteps.ThenTheBoardHasBlocksMatching("A24B16C35D27E1469...") (0.0s)


### 6) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/93c3cb3a-25de-716b-775a-323c64b91731-C1-D1.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, D1, C1) (0.0s)
#### Then the board has red pieces matching: C1b2bD3bE12k4bF124bG4bH4bI4b5b
    Successfully validated 13 Red pieces.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "C1b2bD3bE12k4bF12...") (0.0s)


### 7) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOutsideZone



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

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 8) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.DropHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2bb95324-1990-6880-7344-3f8bc6e10ece-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player drops a new piece at e3
    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/290c59e7-37b9-974f-069c-26f19bc400fb-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)


### 9) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.CannotBlockOwnKing



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

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 10) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.LoadAPreviouslyCreatedBoard



#### Given I define board WeirdSituation1 as:
  | Any header here - the name doesn't matter |
  | - |
  | Benediction v1: R E2 B-E8                 |
  | R:D1+2+E1k+2k+3k+F1k2G1k+2+               |
  | B:D6k+7k+8E7+8k+9k+F78k+H5+               |
  | X:B5C2D4E6F3H6I1                          |

 -&gt; done: SetupSteps.GivenIDefine("WeirdSituation1", &lt;table&gt;) (0.0s)
#### Given I have board WeirdSituation1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f79d54ef-f62b-8a94-2d61-34eec0fee5b4.png?raw=true)

    Loaded board WeirdSituation1.

 -&gt; done: SetupSteps.GivenIHaveNamedBoard("WeirdSituation1") (0.0s)


### 11) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.LoadASavedBoard



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f79d54ef-f62b-8a94-2d61-34eec0fee5b4.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)


### 12) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.MergeSplitMergeDoesntCreatePieces



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player merges the piece at f2 onto e3
    Accepted: f2+e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1c26ac3a-fec5-1510-aa54-4bdeb39b0c53-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, F2, E3) (0.0s)
#### And the red player splits 1 piece from e3 onto d2
    Accepted: e3-1-d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d161f66c-b01f-4425-e375-f0b0d312019e-D2-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, E3, D2) (0.0s)
#### Then the board has red pieces matching: D12+E12k3F1
    Successfully validated 6 Red pieces.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "D12+E12k3F1") (0.0s)


### 13) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d1",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d1
    Rejected: Bd1: Location D1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D1) (0.0s)
#### Then the action fails
    Failed with: Location D1 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 14) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d2",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d2
    Rejected: Bd2: Location D2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D2) (0.0s)
#### Then the action fails
    Failed with: Location D2 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 15) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e1",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e1
    Rejected: Be1: Location E1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E1) (0.0s)
#### Then the action fails
    Failed with: Location E1 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 16) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e2",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e2
    Rejected: Be2: Location E2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E2) (0.0s)
#### Then the action fails
    Failed with: Location E2 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 17) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e3",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e3
    Rejected: Be3: Location E3 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E3) (0.0s)
#### Then the action fails
    Failed with: Location E3 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 18) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f1",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f1
    Rejected: Bf1: Location F1 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F1) (0.0s)
#### Then the action fails
    Failed with: Location F1 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 19) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f2",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f2
    Rejected: Bf2: Location F2 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F2) (0.0s)
#### Then the action fails
    Failed with: Location F2 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 20) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d7",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d7
    Rejected: Bd7: Location D7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D7) (0.0s)
#### Then the action fails
    Failed with: Location D7 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 21) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("d8",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades d8
    Rejected: Bd8: Location D8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, D8) (0.0s)
#### Then the action fails
    Failed with: Location D8 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 22) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e7",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e7
    Rejected: Be7: Location E7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E7) (0.0s)
#### Then the action fails
    Failed with: Location E7 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 23) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e8",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e8
    Rejected: Be8: Location E8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E8) (0.0s)
#### Then the action fails
    Failed with: Location E8 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 24) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("e9",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades e9
    Rejected: Be9: Location E9 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, E9) (0.0s)
#### Then the action fails
    Failed with: Location E9 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 25) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f7",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f7
    Rejected: Bf7: Location F7 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F7) (0.0s)
#### Then the action fails
    Failed with: Location F7 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 26) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.NoneOfTheseAreValidBlockLocations("f8",null)



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player blockades f8
    Rejected: Bf8: Location F8 Not Empty

 -&gt; done: ActionSteps.WhenIBlockade(Red, F8) (0.0s)
#### Then the action fails
    Failed with: Location F8 Not Empty

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 27) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player moves the piece at e3 to e4
    Accepted: e3e4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0f8cfc55-c7ea-8d9f-0af6-7449cf98dba1-E3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, E3, E4) (0.0s)
#### When the red player drops a new piece at e3
    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5182a0c2-1497-e92b-e861-6a4831aba196-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenIDrop(Red, E3) (0.0s)
#### When the blue player blockades c2
    Accepted: Bc2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2cc65043-c118-a2a3-0e19-3030878b5ae2-C2.png?raw=true)


 -&gt; done: ActionSteps.WhenIBlockade(Blue, C2) (0.0s)
#### When the blue player merges the piece at f7 into e7
    Accepted: f7+e7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/17d48168-58f0-f5e3-3f4a-6659b4a25195-E7-F7.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Blue, F7, E7) (0.0s)
#### When the red player merges the piece at e4 into e3
    Accepted: e4+e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a76118e-75f3-d925-112c-e2702b25af90-E3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E4, E3) (0.0s)
#### When the red player splits 1 piece from e3 onto d2
    Accepted: e3-1-d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/114375ac-2104-3ea4-981b-86cf2002a43c-D2-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, E3, D2) (0.0s)


### 28) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves_ShortNotation



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When red does e3e4
    Accepted: e3e4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0f8cfc55-c7ea-8d9f-0af6-7449cf98dba1-E3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Red, "e3e4") (0.0s)
#### When red does @e3
    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5182a0c2-1497-e92b-e861-6a4831aba196-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Red, "@e3") (0.0s)
#### When blue does Bc2
    Accepted: Bc2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2cc65043-c118-a2a3-0e19-3030878b5ae2-C2.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Blue, "Bc2") (0.0s)
#### When blue does f7+e7
    Accepted: f7+e7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/17d48168-58f0-f5e3-3f4a-6659b4a25195-E7-F7.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Blue, "f7+e7") (0.0s)
#### When red does e4+e3
    Accepted: e4+e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a76118e-75f3-d925-112c-e2702b25af90-E3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Red, "e4+e3") (0.0s)
#### When red does e3-1-d2
    Accepted: e3-1-d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/114375ac-2104-3ea4-981b-86cf2002a43c-D2-E3.png?raw=true)


 -&gt; done: ActionSteps.WhenDoes(Red, "e3-1-d2") (0.0s)


### 29) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.PerformSomeMoves_TableNotation



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/67fdf138-8f61-5da7-ab35-12795493aee5-F1-F2.png?raw=true)

    Accepted: f2-1-g2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1af32ad9-c961-a61b-409a-933fb50fb937-F2-G2.png?raw=true)

    Accepted: e8+e9
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/cb1a604d-fb41-39d8-5ac6-22f08e23ccc3-E8-E9.png?raw=true)

    Accepted: Bi3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2399e1a0-8612-b381-4d2e-3a657ec52421-I3.png?raw=true)

    Accepted: e3+d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a65671c2-3d77-9002-52ec-3fbcc1907851-D2-E3.png?raw=true)

    Accepted: Bb5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e3834eb7-a3d0-d039-d608-cc8502f73fa5-B5.png?raw=true)

    Accepted: f7+f8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/efac1306-33ec-8fd7-e323-bf19514ae0a3-F7-F8.png?raw=true)

    Accepted: f8f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8ae1b03c-c460-8ba3-fcd6-73ab09a27d17-F7-F8.png?raw=true)

    Accepted: d2c1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9d73463e-9f60-12bc-51f7-edabf928c646-C1-D2.png?raw=true)

    Accepted: e1f1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3796d78a-70f5-b431-b8cc-56a853cd349f-E1-F1.png?raw=true)

    Accepted: Ba2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5376f783-a365-9120-1c99-221a0851529e-A2.png?raw=true)

    Accepted: f7-1-g7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c494f7ff-1304-be41-0636-2e8a48e0a46e-F7-G7.png?raw=true)

    Accepted: e2e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a8fc7cb1-317d-702d-3365-a72ea2d6e5ab-E2-E3.png?raw=true)

    Accepted: d1e1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7cb37e96-a87f-4839-ab91-1a3c77b73f40-D1-E1.png?raw=true)

    Accepted: Bf8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f55fa2fa-0b93-0964-07c3-7ed5f2f8dede-F8.png?raw=true)

    Accepted: f7g6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/896594e3-7767-1914-cb7c-0b039266c4e6-F7-G6.png?raw=true)

    Accepted: Bg1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0bba625a-68fb-7941-af04-112ba5a8dd1f-G1.png?raw=true)

    Accepted: Bb1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/55033321-1ca3-4dbd-be86-12344d63f732-B1.png?raw=true)

    Accepted: Bd4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ad88b565-b6ec-89b1-7fe2-270773e5ba06-D4.png?raw=true)

    Accepted: d7+e7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4aa47f8c-133e-9d2d-8d56-95559af3c5b0-D7-E7.png?raw=true)

    Accepted: f1+e1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e58f02ce-7ed7-7dad-bedc-3e6a87a5fe94-E1-F1.png?raw=true)

    Accepted: f2e2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/59a1cf13-6e2f-4f0e-0b71-01b38971f760-E2-F2.png?raw=true)

    Accepted: @d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7cb32bc7-085b-7ab2-2f1a-c8b213be89be-D7.png?raw=true)

    Accepted: d7+d8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f405944e-9098-bff0-ff01-38d0b2417875-D7-D8.png?raw=true)

    Accepted: @f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/6bc4a20a-5e28-5ca2-eb5f-6bb37c1c68b9-F2.png?raw=true)

    Accepted: f2+e2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8512d25a-4f05-7d95-dd27-5c5a8d1e8942-E2-F2.png?raw=true)

    Accepted: @d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/cdb9a80d-2178-1092-0beb-2d9bd2fa7765-D7.png?raw=true)

    Accepted: @e8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5817ba73-10d3-c8b8-49c0-0c328ef1c67a-E8.png?raw=true)

    Accepted: @f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5c6896be-106b-7f80-2e7b-1966a71c1d7f-F2.png?raw=true)

    Accepted: e3+f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9d8dce61-ebc6-dc70-141e-932d94600eea-E3-F2.png?raw=true)

    Accepted: e8+d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/03874236-00bb-48cc-ded9-f93b03099b24-D7-E8.png?raw=true)

    Accepted: @e8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5afe91be-7e72-3436-b5af-2d816ef2e37c-E8.png?raw=true)

    Accepted: @d1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a32c2fe4-e203-8134-5328-8ee60647b1be-D1.png?raw=true)

    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a8251063-7c7c-8969-f189-546123b79116-E3.png?raw=true)

    Accepted: @f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f13707a5-c8e7-a441-68bc-769162413562-F7.png?raw=true)

    Accepted: f7+e8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/aec6595d-7606-683d-d250-2dc39954c01f-E8-F7.png?raw=true)

    Accepted: @f1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/44b1e696-f4ab-9d58-a883-9e01980cb4a5-F1.png?raw=true)

    Accepted: @d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/548d6064-f382-dfe5-f1e9-33c37f16839d-D2.png?raw=true)

    Accepted: @f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/26869e5d-58b6-607a-0935-a7697a8b06f1-F7.png?raw=true)

    Accepted: Bd6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1fc66954-f9c4-f931-2dcc-e80f493b0699-D6.png?raw=true)


 -&gt; done: ActionSteps.WhenTheFollowingMoves(&lt;table&gt;) (0.0s)


### 30) Passed : Testing.Specflow.Features.GameRules.ExamplesFeature.StartFromAnEmptyBoard



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ef230c10-9e1a-3cbf-1a42-6ef542e184ac.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E3k+") (0.0s)
#### And I add these blue pieces: D45+E56k7F5++++6+b+++7+++++
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3503036d-2e06-2a04-9548-2751253e93f2.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Blue, "D45+E56k7F5++++6+...") (0.0s)


### 31) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2bb95324-1990-6880-7344-3f8bc6e10ece-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)


### 32) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RepeatMovesNotAllowed



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0f8cfc55-c7ea-8d9f-0af6-7449cf98dba1-E3-E4.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, E3, E4) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player moves the piece at e4 to e5
    Rejected: e4e5: Piece at E4 Has Already Moved This Turn

 -&gt; done: ActionSteps.WhenIMove(Red, E4, E5) (0.0s)
#### Then the action fails
    Failed with: Piece at E4 Has Already Moved This Turn

 -&gt; done: CommonSteps.ThenTheActionFails() (0.0s)


### 33) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureHappyPath



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
  | Benediction v1: R=E2 B E8 |
  | R:D12E12k6+F1             |
  | B:D78E78k9F5+             |
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/083b4731-de09-b68b-edca-be011f3f1734.png?raw=true)


 -&gt; done: SetupSteps.GivenILoad(&lt;table&gt;) (0.0s)
#### When the red player splits 1 piece from e6 onto e7
    Accepted: e6-1-e7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/aa865385-577d-aac7-3912-28c2e901c45a-E6-E7.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, E6, E7) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k6c7cF1
    Successfully validated 7 Red pieces.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k6c7cF1") (0.0s)


### 34) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2bb95324-1990-6880-7344-3f8bc6e10ece-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### And the red player splits 1 piece from f2 onto f1
    Accepted: f2-1-f1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/323bfd4a-e930-dde8-3188-8ed715a90869-F1-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, F2, F1) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF1+2
    Successfully validated 6 Red pieces.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF1+2") (0.0s)


### 35) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveHappyPath



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2bb95324-1990-6880-7344-3f8bc6e10ece-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### And the red player splits 1 piece from f2 onto f3
    Accepted: f2-1-f3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3f79924d-8b43-978e-30d1-510532590828-F2-F3.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, F2, F3) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF12c3c
    Successfully validated 7 Red pieces.

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF12c3c") (0.0s)


### 36) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedKingPassingBlueWallCausesRedWin



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3f0ceff8-f87b-9005-4ecc-6c276fc8a8e7-A1-I5.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: CommonSteps.GameOver(Red) (0.0s)


## Run Settings

    DefaultTimeout: 

    WorkDirectory: F:\src\BenedictionGame\testruns\latest

    ImageRuntimeVersion: 4.0.30319

    ImageTargetFrameworkName: .NETFramework,Version=v4.7.1

    ImageRequiresX86: False

    ImageRequiresDefaultAppDomainAssemblyResolver: False

    NumberOfTestWorkers: 12

## Test Run Summary 

 Overall result: Failed

 Test Count: 118, Passed: 36, Failed: 1, Inconclusive: 81, Skipped: 0

   Failed Tests - Failures: 1, Errors: 0, Invalid: 0

 Start time: 2020-02-02 18:16:58Z

   End time: 2020-02-02 18:16:59Z

   Duration: 1.848 seconds

