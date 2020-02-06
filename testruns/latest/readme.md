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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)

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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0f8cfc55-c7ea-8d9f-0af6-7449cf98dba1-E3-E4.png?raw=true)

    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5182a0c2-1497-e92b-e861-6a4831aba196-E3.png?raw=true)

    Accepted: f8+f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/246ade30-9149-6e15-1754-5c585fbe12f6-F7-F8.png?raw=true)

    Accepted: @f8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2a36d76d-78f8-b4d4-278b-c252c0132438-F8.png?raw=true)

    Accepted: d1+d2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/412215e4-91f3-c0db-694a-f3c099d58ce1-D1-D2.png?raw=true)

    Accepted: @d1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/0fd5b26e-b69d-9c51-bc0f-b9a7ef11330e-D1.png?raw=true)

    Accepted: d7d6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/84bd4ce7-479a-dc84-152a-5bb470124c94-D6-D7.png?raw=true)

    Accepted: @d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/892498d2-57e1-d2e1-ef39-9a26316cae87-D7.png?raw=true)

    Accepted: f1+f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e7bf8bac-aaa3-6e9c-7e05-52587c930053-F1-F2.png?raw=true)

    Accepted: @f1
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d4383f3d-960a-3413-23be-45d6694e109d-F1.png?raw=true)

    Accepted: f7f5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/bddc193d-3577-f592-a629-1f83b22a064c-F5-F7.png?raw=true)

    Accepted: @f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/aced0ec3-c164-6d6e-7354-f84e43060853-F7.png?raw=true)

    Accepted: f2f4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/462d066e-518c-f89c-d13f-f33e88f35262-F2-F4.png?raw=true)

    Accepted: f4-1-f5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c2deb277-8566-eaa1-a4a8-a346415328d9-F4-F5.png?raw=true)

    Accepted: d7+d6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/69c732c2-612e-1ce4-9473-0c90e71bc801-D6-D7.png?raw=true)

    Accepted: d6b4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c6a71c27-1553-a846-bc81-8d9d92103183-B4-D6.png?raw=true)

    Accepted: d2f3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/78b3e894-b5d2-99ce-2981-0a7bb28d0f08-D2-F3.png?raw=true)

    Accepted: @f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e85ac896-837e-daf4-083a-9c1ab03d5074-F2.png?raw=true)

    Accepted: b4b2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9e7ceb29-67d3-42a8-a381-3d4862c708ed-B2-B4.png?raw=true)

    Accepted: Bc2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/698df008-1472-7591-fd72-de4de7b099b0-C2.png?raw=true)

    Accepted: f3h3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7100041e-bc5d-3007-f3ba-56ea4f1226c7-F3-H3.png?raw=true)

    Accepted: f1+f2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ba82f962-da6e-8719-7031-45bc05c4710b-F1-F2.png?raw=true)

    Accepted: b2i5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/20e8f512-0ebe-3bbf-fabc-cff2d32943ef-B2-I5.png?raw=true)

    Accepted: e9+f8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/add6a93f-195a-0629-b65f-c3e3645c0956-E9-F8.png?raw=true)

    Accepted: h3h5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/832c0e80-803e-b6ad-fdb1-e26b1d0d7881-H3-H5.png?raw=true)

    Accepted: h5-1-i5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/c113ab50-fda5-5a8a-72ad-a000f7b851ae-H5-I5.png?raw=true)

    Accepted: @e9
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/977ba4fe-26c4-2cd8-87f1-9f122b0f604b-E9.png?raw=true)

    Accepted: @d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/70a1c945-25ab-f152-3284-e3548ff809de-D7.png?raw=true)

    Accepted: f4g4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4ed658a3-82f5-05cc-130f-4d5b299ec475-F4-G4.png?raw=true)

    Accepted: f2f4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/9a59a1cf-68e1-38bd-b59b-930ed2d4e622-F2-F4.png?raw=true)

    Accepted: f8h6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/417e5ae0-f267-6403-df0a-83e1b767b344-F8-H6.png?raw=true)

    Accepted: h6-1-i5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/13576040-16af-1bc1-00a6-970cceb0e638-H6-I5.png?raw=true)

    Accepted: e3+e4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ca93e6b4-e3dd-2bd6-5653-7c8201d9aa71-E3-E4.png?raw=true)

    Accepted: h5i5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3236547e-9a18-c636-96b9-01f0e11d2247-H5-I5.png?raw=true)

    Accepted: h6i5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1c5feb37-70fa-fefa-91be-3b7ffbcfb2d0-H6-I5.png?raw=true)

    Accepted: @f8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b2030054-cefb-f25d-6ebf-e30e4cb54a55-F8.png?raw=true)

    Accepted: f4d5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7f538c98-0659-e305-dc48-67af7a44eb0e-D5-F4.png?raw=true)

    Accepted: e4e5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/7a31c5a1-7013-00f7-586c-51fa1261e3be-E4-E5.png?raw=true)

    Accepted: e8+e9
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/5486a738-3525-064a-e505-dcf19f7d1bce-E8-E9.png?raw=true)

    Accepted: Bc7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b2e8be61-98e6-d12e-256c-263987c6292a-C7.png?raw=true)

    Accepted: e1+e2
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ec3d4e52-f68c-5330-4572-e506aa1c025d-E1-E2.png?raw=true)

    Accepted: e2e4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/667a0689-0074-5026-3f4b-18e2b2c8ce22-E2-E4.png?raw=true)

    Accepted: f7+e7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ff4bb56e-3e38-6c84-f248-184b56308161-E7-F7.png?raw=true)

    Accepted: e7e5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ecb771ba-e27c-698b-940b-29d18f3dcf6a-E5-E7.png?raw=true)

    Accepted: e4e5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/cce4a8ab-151d-b2bd-1fe7-42ca6713778f-E4-E5.png?raw=true)

    Accepted: d5e6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/949af7e8-dbbe-a07a-79e9-69db64804c02-D5-E6.png?raw=true)

    Accepted: Be7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/05ce5c65-06c6-c9c7-ed69-e05b5a54514c-E7.png?raw=true)

    Accepted: @f7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/08eb9363-2960-f18d-5269-e4046a2cf59f-F7.png?raw=true)

    Accepted: e5c5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/df666ba2-e203-2ac2-be49-4434e496a98f-C5-E5.png?raw=true)

    Accepted: Ba5
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/4c00cc2d-d800-9fed-78f9-e9d23938ed1a-A5.png?raw=true)

    Accepted: d8+d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/a35d3439-ec84-af0f-b7b2-a4187037965b-D7-D8.png?raw=true)

    Accepted: @d8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ac999153-ca4b-8acb-2b0b-c24140bb2466-D8.png?raw=true)

    Accepted: e6c6
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d23babbf-5b8d-b756-2c94-fa3af912fe37-C6-E6.png?raw=true)

    Accepted: c6-1-d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/32d32974-62f4-755d-7a03-38ea67beccc6-C6-D7.png?raw=true)

    Accepted: d8d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/97338497-3862-93ee-e843-38e4260b4082-D7-D8.png?raw=true)

    Accepted: @d8
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/325e409a-1c86-89f9-525b-9b863dc08392-D8.png?raw=true)

    Accepted: c5b4
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/55eed42c-b69b-8cfe-df94-34ac94b045c0-B4-C5.png?raw=true)

    Accepted: c6d7
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/fa0292c9-9df4-c4b7-986e-45d432ea12e9-C6-D7.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/e5c4514c-8802-69fd-4f37-202fa92f03ef-A1.png?raw=true)


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

 -&gt; done: ValidationSteps.ThenTheBoardHasBlocksMatching("A24B16C35D27E1469...") (0.0s)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/583156d7-4d7e-ea5b-fd2f-8b76e96ea48a-E3.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/09674cbf-9813-00b5-2a75-57eb8b4d96cd-F6-H4.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 2, F6, H4) (0.0s)
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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/93c3cb3a-25de-716b-775a-323c64b91731-C1-D1.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/79afa5f7-217d-4829-2409-47c55f1e4404-D2.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/cf5044be-c432-3746-1739-2868884df9e7-G4-H4.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/d6a96ffe-9413-bf7b-9660-93853325811a-E2.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/64c2001a-950d-eff3-424b-0960ac0160b8-G5-H4.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 1, G5, H4) (0.0s)
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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/45498da7-e1bd-7f71-cd92-9887ed24c76f-F6-H4.png?raw=true)


 -&gt; done: ActionSteps.WhenISplit(Red, 2, F6, H4) (0.0s)
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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2bb95324-1990-6880-7344-3f8bc6e10ece-E3-F2.png?raw=true)


 -&gt; done: ActionSteps.WhenIMerge(Red, E3, F2) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player drops a new piece at e3
    Accepted: @e3
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/290c59e7-37b9-974f-069c-26f19bc400fb-E3.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/1380d8a2-14ab-4671-c85a-bd608dee0f0c-E2.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f79d54ef-f62b-8a94-2d61-34eec0fee5b4.png?raw=true)

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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/f79d54ef-f62b-8a94-2d61-34eec0fee5b4.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/b50cb248-3720-e98d-f5a2-c04c3545857a.png?raw=true)


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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/ef230c10-9e1a-3cbf-1a42-6ef542e184ac.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Red, "E3k+") (0.0s)
#### And I add these blue pieces: D45+E56k7F5++++6+b+++7+++++
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/3503036d-2e06-2a04-9548-2751253e93f2.png?raw=true)


 -&gt; done: SetupSteps.GivenIAddPieces(Blue, "D45+E56k7F5++++6+...") (0.0s)


### 41) Passed : Testing.Specflow.Features.GameRules.MergeRulesFeature.MergeHappyPath



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)


### 42) Passed : Testing.Specflow.Features.GameRules.MovementRulesFeature.RepeatMovesNotAllowed



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### When the red player moves the piece at e4 to e5
    Rejected: e4e5: Piece at E4 Has Already Moved This Turn

 -&gt; done: ActionSteps.WhenIMove(Red, E4, E5) (0.0s)
#### Then the action fails
    Failed with: Piece at E4 Has Already Moved This Turn

 -&gt; done: ValidationSteps.ThenTheActionFails() (0.0s)


### 43) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_CaptureHappyPath



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12k6c7cF1
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12k6c7cF1") (0.0s)


### 44) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MergeHappyPath



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF1+2
    Successfully validated 6 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF1+2") (0.0s)


### 45) Passed : Testing.Specflow.Features.GameRules.SplitRulesFeature.Split_MoveHappyPath



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: D12E12kF12c3c
    Successfully validated 7 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "D12E12kF12c3c") (0.0s)


### 46) Passed : Testing.Specflow.Features.GameRules.WinLoseRulesFeature.RedKingPassingBlueWallCausesRedWin



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

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the game is over and red has won

 -&gt; done: ValidationSteps.GameOver(Red) (0.0s)


### 47) Passed : Testing.Specflow.Features.GameRules.WrapAroundRulesFeature.CursedPieceWrappingAroundRemainsCursed



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
![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/2a6a5c48-f089-fed6-fb83-39d8e8783a20-A1-I5.png?raw=true)


 -&gt; done: ActionSteps.WhenIMove(Red, I5, A1) (0.0s)
#### Then the action succeeds

 -&gt; done: ValidationSteps.ThenTheActionSucceeds() (0.0s)
#### And the board has red pieces matching: A1cD12E12k3F12
    Successfully validated 8 Red pieces.

 -&gt; done: ValidationSteps.ThenTheBoardHasPiecesMatching(Red, "A1cD12E12k3F12") (0.0s)


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

 Test Count: 114, Passed: 47, Failed: 0, Inconclusive: 67, Skipped: 0

 Start time: 2020-02-06 04:11:18Z

   End time: 2020-02-06 04:11:20Z

   Duration: 1.851 seconds

