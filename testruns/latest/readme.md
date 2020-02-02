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


### 5) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockHappyPath





### 6) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.BlockMaximum





### 7) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockAdjacentAnotherBlock





### 8) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockHomeSpace





### 9) Passed : Testing.Specflow.Features.GameRules.BlockRulesFeature.CannotBlockOccupiedSpace





### 10) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeCannotBlessCursedPieces





### 11) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeHappyPath





### 12) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeMaximum





### 13) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.BridgeWithWrongColorCriticalPiece





### 14) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.HomeDropCompletingBridgeWinsGame





### 15) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.SplitIntoBridgeAvoidsAllCursesIfSplitPiecesAdjacent





### 16) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.SplitIntoBridgeAvoidsSourceCurseIfSourcePieceAdjacent





### 17) Passed : Testing.Specflow.Features.GameRules.BridgeRulesFeature.SplitIntoBridgeAvoidsTargetCurseIfTargetPieceAdjacent





### 18) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOntoBlock





### 19) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOntoOccupiedSpace





### 20) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.CannotDropOutsideZone





### 21) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.DropHappyPath





### 22) Passed : Testing.Specflow.Features.GameRules.DropRulesFeature.HomeDropBecomesKing





### 23) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeAboveStackSizeFifteen





### 24) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndCursed





### 25) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndKing





### 26) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeCursedAndNormal





### 27) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.CannotMergeKingAndKing





### 28) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeAboveSizeTwoRequiresBlessing





### 29) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeBlessedAndKing





### 30) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeCursedAndBlessed





### 31) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeHappyPath





### 32) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeMaximum





### 33) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndBlessed





### 34) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndKing





### 35) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndKingAboveStackSizeTwoRequiresBlessing





### 36) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeNormalAndNormal





### 37) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.BlueCannotMoveThroughBlueWall





### 38) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CanCaptureEnemyPiece





### 39) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotCaptureOwnPiece





### 40) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotDepartEdgeOfBoard





### 41) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotMoveOntoBlock





### 42) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.CannotMoveOverBlock





### 43) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.MoveThroughWallIsAssumedIfPossible





### 44) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RedCannotMoveThroughRedWall





### 45) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RepeatMovesNotAllowed





### 46) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.BlessedStackLosesBlessingUponSplit_Merge





### 47) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeBlessedStackOntoKingOverStackSizeTwo





### 48) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeBlessedStackOntoRegularPieceOverStackSizeTwo





### 49) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoCursedPiece





### 50) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoKingOverStackSizeTwo





### 51) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOntoRegularPieceOverStackSizeTwo





### 52) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.CannotSplit_MergeOverBlock





### 53) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureCannotMoveOverBlock





### 54) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureHappyPath





### 55) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeBlessedStackOntoBlessedPieceOverStackSizeTwo





### 56) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeHappyPath





### 57) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeLeavesCorrectlySizedStacks





### 58) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCannotMoveOntoBlock





### 59) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCannotMoveOverBlock





### 60) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveCursesBothPieces





### 61) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveHappyPath





### 62) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.SplitDistanceCannotExceedSize





### 63) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.SplitMustRejectInvalidSizes





### 64) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueCapturingAnyRedKingCausesBlueWin





### 65) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueFormingChainWithKingCausesBlueWin





### 66) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueJoiningKingToExistingChainCausesRedWin





### 67) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueKingPassingRedWallCausesBlueWin





### 68) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueMovingBlessedPieceOntoBlueHomeDoesNotCauseWin





### 69) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueMovingBlessedPieceOntoRedHomeDoesNotCauseWin





### 70) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.BlueWithNoLegalMovesCausesRedWin





### 71) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedCapturingAnyBlueKingCausesRedWin





### 72) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedFormingChainWithKingCausesRedWin





### 73) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedJoiningKingToExistingChainCausesRedWin





### 74) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedKingPassingBlueWallCausesRedWin





### 75) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedMovingBlessedPieceOntoBlueHomeDoesNotCauseWin





### 76) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedMovingBlessedPieceOntoRedHomeDoesNotCauseWin





### 77) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedWithNoLegalMovesCausesBlueWin





### 78) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndMergingCanFormAnyStackSize





### 79) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndSplitMergingCanFormAnyStackSize





### 80) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundAndSplittingLeavesBless_CursePair





### 81) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundOntoHomeBecomesKing





### 82) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.BlessedPieceWrappingAroundRemainsBlessed





### 83) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndMergingRequiresBlessedTarget





### 84) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndSplitMergingRequiresBlessedTarget





### 85) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundAndSplittingRemainsCursed





### 86) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundOntoHomeBecomesKing





### 87) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundRemainsCursed





### 88) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingStackWrappingAroundAndSplitMergingOntoPieceRemainsBlessedAndWinsGame





### 89) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingWrappingAroundAndMergingOntoPieceRemainsBlessedAndWinsGame





### 90) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingWrappingAroundOntoHomeWinsGame





### 91) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.KingWrappingAroundOntoRegularSpaceWinsGame





### 92) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.NormalPieceWrappingAroundBecomesBlessed





### 93) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.NormalPieceWrappingAroundOntoHomeBecomesKing





### 94) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndMergingCanFormAnyStackSize





### 95) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndSplitMergingCanFormAnyStackSize





### 96) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.RegularPieceWrappingAroundAndSplittingLeavesBless_CursePair





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

 Test Count: 96, Passed: 96, Failed: 0, Inconclusive: 0, Skipped: 0

 Start time: 2020-02-02 01:20:59Z

   End time: 2020-02-02 01:21:01Z

   Duration: 1.381 seconds

