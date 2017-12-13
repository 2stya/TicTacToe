# TicTacToe
This is a training project of using TDD and fully understand the advantages of writing self-testing code

## Projects
 - TicTacToe - Contains  game logic
 - TicTacToe.Tests - Contains tests for TicTacToe class
 - TicTacToe.Console - Provides a console graphic interpretation of game
 - TicTacToe.Console.Tests - Contains tests for TicTacToe.Console class 

## About
Tic-tac-toe (also known as noughts and crosses or Xs and Os) is a paper-and-pencil game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.

## Strategy
A player can play a perfect game of tic-tac-toe (to win or, at least, draw) if they choose the first available move from the following list, each turn, as used in Newell and Simon's 1972 tic-tac-toe program.

__Win__: If the player has two in a row, they can place a third to get three in a row.  
__Block__: If the opponent has two in a row, the player must play the third themselves to block the opponent.  
__Fork__: Create an opportunity where the player has two threats to win (two non-blocked lines of 2).

__*Blocking an opponent's fork*__:
__Option 1__: The player should create two in a row to force the opponent into defending, as long as it doesn't result in them creating a fork. For example, if "X" has two opposite corners and "O" has the center, "O" must not play a corner in order to win. (Playing a corner in this scenario creates a fork for "X" to win.)  
__Option 2__: If there is a configuration where the opponent can fork, the player should block that fork.  
__Center__: A player marks the center. (If it is the first move of the game, playing on a corner gives the second player more opportunities to make a mistake and may therefore be the better choice; however, it makes no difference between perfect players.)  
__Opposite corner__: If the opponent is in the corner, the player plays the opposite corner.  
__Empty corner__: The player plays in a corner square.  
__Empty side__: The player plays in a middle square on any of the 4 sides.  