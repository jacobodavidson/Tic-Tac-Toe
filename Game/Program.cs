using System;

namespace Game
{
    class Program
    {
      // Set Players
      private static string playerX = "";
      private static string playerXSymbol = "X";
      private static string playerO = "";
      private static string playerOSymbol = "O";

      // Game Loop Variables
      private static bool gameWon = false;
      private static string winner = "";
      private static bool playAgain = true;

      // Variables for Move Coordinates
      private static int row;
      private static int col;
      private static bool playerXTurn = true;
      
      // Set Board Lines
      // Change element 4, 8, 12 to X or O later
      private static string boardTop = "    1   2   3"; // Top Labels for Board
      private static string[] boardLine1 = new string[] {"1", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine2 = new string[] {"2", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine3 = new string[] {"3", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};

      static void Main(string[] args)
      {
        StartGame();
        GameLoop();
      }

      // Main Game Loop
      static void GameLoop()
      {
        while (!gameWon)
        {
          RecordMove();
          gameWon = CheckWin();
        }

        EndGame();
      }

      // Start Game and Print Player Symbols
      static void StartGame()
      {
        Console.WriteLine();
        Console.WriteLine("[Welcome to Tic-Tac-Toe]");
        Console.WriteLine();

        SetPlayers();
        Console.WriteLine("[" + playerX + " is X]");
        Console.WriteLine("[" + playerO + " is O]");
        Console.WriteLine();
        PrintBoard();
      }

      // Game Over Dialogue
      static void EndGame()
      {
        if (winner != "")
        {
          Console.WriteLine("[GAME OVER]");
          Console.WriteLine("~" + winner + " Wins~");
        }
        else
        {
          Console.WriteLine("[DRAW]");
          Console.WriteLine("~Nobody Wins :(~");
        }
        Console.WriteLine();
        ResetGame();
      }

      // Prompt User to Play Again, If So Reinitalizes Game and Restarts Game
      // Loop, If Not Exits Game
      static void ResetGame()
      {
        Console.WriteLine("[Play Again?]");
         Console.Write("[Y/N]: ");
        string playAgainInput = Console.ReadLine();

        if (playAgainInput == "Y" || playAgainInput == "y")
        {
          gameWon = false;
          playAgain = true;
          winner = "";
          playerXTurn = true;
          boardLine1 = new string[] {"1", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          boardLine2 = new string[] {"2", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          boardLine3 = new string[] {"3", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          Console.WriteLine();
          Console.WriteLine("[New Game]");
          Console.WriteLine();
          PrintBoard();
          GameLoop();
        }
        else
        {
          playAgain = false;
        }
      }

      // Checks All Possible Win Conditions and Draws
      static bool CheckWin()
      {
        if (boardLine1[4] == boardLine1[8] && boardLine1[8] == boardLine1[12]
          && boardLine1[4] != " ")
        {
          CheckWinner(boardLine1[4]);
          return true;
        }
        else if (boardLine2[4] == boardLine2[8]
          && boardLine2[8] == boardLine2[12] && boardLine2[4] != " ")
        {
          CheckWinner(boardLine2[4]);
          return true;
        }
        else if (boardLine3[4] == boardLine3[8]
          && boardLine3[8] == boardLine3[12] && boardLine3[4] != " ")
        {
          CheckWinner(boardLine3[4]);
          return true;
        }
        else if (boardLine1[4] == boardLine2[4]
          && boardLine2[4] == boardLine3[4] && boardLine1[4] != " ")
        {
          CheckWinner(boardLine1[4]);
          return true;
        }
        else if (boardLine1[8] == boardLine2[8]
          && boardLine2[8] == boardLine3[8] && boardLine1[8] != " ")
        {
          CheckWinner(boardLine1[8]);
          return true;
        }
        else if (boardLine1[12] == boardLine2[12]
          && boardLine2[12] == boardLine3[12] && boardLine1[12] != " ")
        {
          CheckWinner(boardLine1[12]); 
          return true;
        }
        else if (boardLine1[4] == boardLine2[8]
          && boardLine2[8] == boardLine3[12] && boardLine1[4] != " ")
        {
          CheckWinner(boardLine1[4]);
          return true;
        }
        else if (boardLine1[12] == boardLine2[8]
          && boardLine2[8] == boardLine3[4] && boardLine1[12] != " ")
        {
          CheckWinner(boardLine1[12]);
          return true;
        }
        else if (boardLine1[4] != " " && boardLine1[8] != " " 
          && boardLine1[12] != " " && boardLine2[4] != " "
          && boardLine2[8] != " " && boardLine2[12] != " "
          && boardLine3[4] != " " && boardLine3[8] != " "
          && boardLine3[12] != " ")
        {
          return true;
        }
        else
        {
          return false;
        }
      }

      // Determines Which Player Won Based on Symbol
      static void CheckWinner(string symbol)
      {
        if (symbol == playerXSymbol)
        {
          winner = playerX;
        }
        else
        {
          winner = playerO;
        }
      }

      // Sets the Players for the Game
      static void SetPlayers()
      {
        Console.Write("[Enter Player X]: ");
        playerX = Console.ReadLine();
        
        Console.Write("[Enter Player O]: ");
        playerO = Console.ReadLine();
        Console.WriteLine();
      }

      // Records the Move of the Player and Updates the Board, Also Checks for
      // Invalid Move Selections and Toggles Player Turns
      static void RecordMove()
      {
        if (playerXTurn)
        {
          Console.WriteLine("[" + playerX + "'s Turn]");
          Console.Write("[Enter Move Row]: ");
          row = int.Parse(Console.ReadLine());
          Console.Write("[Enter Move Column]: ");
          col = int.Parse(Console.ReadLine());
          Console.WriteLine();

          if (row == 1)
          {
            if (boardLine1[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine1[col * 4] = playerXSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else if (row == 2)
          {
            if (boardLine2[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine2[col * 4] = playerXSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else if (row == 3)
          {
            if (boardLine3[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine3[col * 4] = playerXSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else
          {
            InvalidMove();
          }
        } 
        else
        {
          Console.WriteLine("[" + playerO + "'s Turn]");
          Console.Write("[Enter Move Row]: ");
          row = int.Parse(Console.ReadLine());
          Console.Write("[Enter Move Column]: ");
          col = int.Parse(Console.ReadLine());
          Console.WriteLine();

          if (row == 1)
          {
            if (boardLine1[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine1[col * 4] = playerOSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else if (row == 2)
          {
            if (boardLine2[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine2[col * 4] = playerOSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else if (row == 3)
          {
            if (boardLine3[col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              boardLine3[col * 4] = playerOSymbol;
              playerXTurn = !playerXTurn;
              PrintBoard();
            }
          }
          else
          {
            InvalidMove();
          }
        } 
      }

      // Prints Invalid Move Dialogue and Prompts for New Move
      static void InvalidMove()
      {
        Console.WriteLine("[INVALID MOVE]");
        Console.WriteLine();
        RecordMove();
      } 

      // Prints the Current Board
      static void PrintBoard()
      {
        Console.WriteLine(boardTop);
        Console.WriteLine(string.Join("", boardLine1));
        Console.WriteLine(string.Join("", boardLine2));
        Console.WriteLine(string.Join("", boardLine3));
        Console.WriteLine();
      }
    }
}