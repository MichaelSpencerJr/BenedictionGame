## Runtime Environment 

   OS Version: Microsoft Windows NT 10.0.17134.0

  CLR Version: 4.0.30319.42000

NUnit Version: 3.10.0.0

## Test Files 

    F:\src\BenedictionGame\src\Testing\Specflow\bin\Debug\Testing.Specflow.dll

## Tests Which Passed

### 1) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.MovingNorthWithoutWrappingAround("E5","E6",null)



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: CommonSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/99732cc7-6515-ffb2-b253-95c12d9dd6a6.png?raw=true)


 -&gt; done: CommonSteps.GivenIAddPieces(Red, "E5") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E5 to E6
    Accepted: e5e6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a7e5a64-8d70-7c87-dd5a-8033eac31e00-E5-E6.png?raw=true)


 -&gt; done: CommonSteps.WhenIMove(Red, E5, E6) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E6

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E6") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 2) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.MovingNorthWithoutWrappingAround("E4","E5",null)



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: CommonSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f977260b-db80-81ff-874f-cf6bc707b0dc.png?raw=true)


 -&gt; done: CommonSteps.GivenIAddPieces(Red, "E4") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E4 to E5
    Accepted: e4e5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f2a17dbc-ea88-715b-c29d-547ce78ff822-E4-E5.png?raw=true)


 -&gt; done: CommonSteps.WhenIMove(Red, E4, E5) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E5

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E5") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 3) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.MovingTooFar



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: CommonSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a6b5752d-c52b-655c-5821-a80fe616ffb7.png?raw=true)


 -&gt; done: CommonSteps.GivenIAddPieces(Red, "E3") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E3 to E5
    Rejected: e3e5: Stack Size 1 Piece At E3 Cannot Reach E5 (but can reach: E4, E2)

 -&gt; done: CommonSteps.WhenIMove(Red, E3, E5) (0.0s)
#### Then the action fails with: Stack Size 1 Piece At E3 Cannot Reach E5 (but can reach: E4, E2)

 -&gt; done: CommonSteps.ThenTheActionFailsWith("Stack Size 1 Piec...") (0.0s)
#### And the board has red pieces matching: E3

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E3") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction1) (0.0s)


### 4) Passed : Testing.Specflow.Features.GameBoard.MovementFeature.SingleMoveNorth



#### Given I have an empty E2 E8 board
    Loaded empty game board with Red Home at E2 and Blue Home at E8

 -&gt; done: CommonSteps.GivenIHaveAnEmptyBoard(E2, E8) (0.0s)
#### Given I add this red piece: E5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/99732cc7-6515-ffb2-b253-95c12d9dd6a6.png?raw=true)


 -&gt; done: CommonSteps.GivenIAddPieces(Red, "E5") (0.0s)
#### And the current turn is RedAction1
    Board flags set to: RedAction1

 -&gt; done: CommonSteps.GivenTheCurrentTurnIsRed(RedAction1) (0.0s)
#### When the red player moves the piece at E5 to E6
    Accepted: e5e6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/8a7e5a64-8d70-7c87-dd5a-8033eac31e00-E5-E6.png?raw=true)


 -&gt; done: CommonSteps.WhenIMove(Red, E5, E6) (0.0s)
#### Then the action succeeds

 -&gt; done: CommonSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: E6

 -&gt; done: CommonSteps.ThenTheBoardHasPiecesMatching(Red, "E6") (0.0s)
#### And the current turn is RedAction2
    Board flags set to: RedAction2

 -&gt; done: CommonSteps.ThenTheCurrentTurnIsRed(RedAction2) (0.0s)


### 5) Passed : Testing.Specflow.Features.GameRules.BlessingRulesFeature.SplitMergeSplitAcross



#### Given I define board RedWrapAround as:
  | RedWrapAround             |
  | - |
  | Benediction v1: R-E2 B E8 |
  | R:A4+B4++C7D126+E12k3F12  |
  | B:E5k                     |

 -&gt; done: CommonSteps.GivenIDefine("RedWrapAround", &lt;table&gt;) (0.0s)
#### And I define board BlueWrapAround as:
  | BlueWrapAround            |
  | - |
  | Benediction v1: R E2 B-E8 |
  | R:E5k                     |
  | B:C1+D7E78kF7G13+H1c6     |
  | X:A4C6F8G7                |

 -&gt; done: CommonSteps.GivenIDefine("BlueWrapAround", &lt;table&gt;) (0.0s)
#### Given I have board BlueWrapAround
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c6552b32-d973-6d15-a20e-a353c4fb7314.png?raw=true)

    Loaded board BlueWrapAround.

 -&gt; done: CommonSteps.GivenIHaveNamedBoard("BlueWrapAround") (0.0s)
#### When the blue player moves the piece at H1 to H6
    Rejected: h1h6: Destination H6 Is Your Own Piece and Cannot Be Moved Onto By Blue

 -&gt; done: CommonSteps.WhenIMove(Blue, H1, H6) (0.0s)
#### Then the action fails with: Destination H6 Is Your Own Piece and Cannot Be Moved Onto By Blue

 -&gt; done: CommonSteps.ThenTheActionFailsWith("Destination H6 Is...") (0.0s)
#### When the blue player moves the piece at H1 to A4
    Rejected: h1a4: Destination A4 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: CommonSteps.WhenIMove(Blue, H1, A4) (0.0s)
#### Then the action fails with: Destination A4 Contains a Block, Which Cannot Be Moved Onto

 -&gt; done: CommonSteps.ThenTheActionFailsWith("Destination A4 Co...") (0.0s)


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

 Test Count: 5, Passed: 5, Failed: 0, Inconclusive: 0, Skipped: 0

 Start time: 2020-02-01 22:03:16Z

   End time: 2020-02-01 22:03:18Z

   Duration: 1.220 seconds

