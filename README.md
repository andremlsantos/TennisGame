# Tennis refactoring, C# NUnit
In this cyber-dojo there are three classes which implement the TennisGame interface. Each is a slightly different refactoring challenge. The idea is to concentrate on one at
a time.

Start by refactoring TennisGame1. 

Take small steps, run the tests often. You should not need to change the test cases. If you get a series of compiler or test errors, consider reverting back to the latest green test run. (You can easily do this by clicking on the latest green traffic light at the top of the page, and select "revert".)

When you are happy with the design for TennisGame1, try refactoring the other two versions, one at a time.

Which one was hardest? Which one got the best design in the end?

Summary of tennis scoring:

1. A game is won by the first player to have won at
   least four points in total and at least two points
   more than the opponent.
   
2. The running score of each game is described in a
   manner peculiar to tennis: scores from zero to three
   points are described as "love", "fifteen", "thirty",
   and "forty" respectively.
   
3. If at least three points have been scored by each
   player, and the scores are equal, the score is "deuce".
   
4. If at least three points have been scored by each
   side and a player has one more point than his opponent,
   the score of the game is "advantage" for the player
   in the lead.

[source http://en.wikipedia.org/wiki/Tennis#Scoring]

# Tennis Game
Tennis has a rather quirky scoring system, and to newcomers it can be a little difficult to keep track of. The local tennis club has some code that is currently being used to update the scoreboard when a player scores a point. 

They has recently acquired two smaller tennis clubs, and they two each have a similar piece of code.

You have just been employed by the tennis club, and your job is to refactor all three codebases until you are happy to work with any of them. The future is uncertain, new features may be needed, and you want to be thoroughly on top of your game when that happens.

Summary of Tennis scoring:
1. A game is won by the first player to have won at least four points 
in total and at least two points more than the opponent.
2. The running score of each game is described in a manner peculiar 
to tennis: scores from zero to three points are described as ???love???, 
???fifteen???, ???thirty???, and ???forty??? respectively.
3. If at least three points have been scored by each player, and the 
scores are equal, the score is ???deuce???.
4. If at least three points have been scored by each side and a player
has one more point than his opponent, the score of the game is ???advantage??? for the player in the lead.
