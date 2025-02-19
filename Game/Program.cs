// -----------------------------------------------------------------------------
// Program: Tic-Tac-Toe
// Author: Jacob Davidson
// Date: 02-18-2025
// Description: This program implements a simple console-based Tic-Tac-Toe game
//              for two players. The game allows players to take turns entering
//              their moves, checks for win conditions, and handles invalid 
//              moves. After the game ends, players are prompted to play again
//              or exit.
// -----------------------------------------------------------------------------
using System;

namespace Game
{
    class Program
    {
      // Set Players
      private static string s_playerX = "";
      private static string s_playerXSymbol = "X";
      private static string s_playerO = "";
      private static string s_playerOSymbol = "O";

      // Game Loop Variables
      private static bool s_gameWon = false;
      private static string s_winner = "";
      private static bool s_playAgain = true;

      // Variables for Move Coordinates
      private static int s_row;
      private static int s_col;
      private static bool s_playerXTurn = true;
      
      // Set Board Lines
      // Change element 4, 8, 12 to X or O later
      private static string s_boardTop = "    1   2   3"; // Top Labels
      private static string[] s_boardLine1 = new string[] {"1", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] s_boardLine2 = new string[] {"2", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] s_boardLine3 = new string[] {"3", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};

      static void Main(string[] args)
      {
        StartGame();
        GameLoop();
      }

      // Main Game Loop
      static void GameLoop()
      {
        while (!s_gameWon)
        {
          RecordMove();
          s_gameWon = CheckWin();
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
        Console.WriteLine("[" + s_playerX + " is X]");
        Console.WriteLine("[" + s_playerO + " is O]");
        Console.WriteLine();
        PrintBoard();
      }

      // Game Over Dialogue
      static void EndGame()
      {
        if (s_winner != "")
        {
          Console.WriteLine("[GAME OVER]");
          Console.WriteLine("~" + s_winner + " Wins~");
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
          s_gameWon = false;
          s_playAgain = true;
          s_winner = "";
          s_playerXTurn = true;
          s_boardLine1 = new string[] {"1", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          s_boardLine2 = new string[] {"2", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          s_boardLine3 = new string[] {"3", " ", "|", " ", " ", " ", "|", " ",
            " ", " ", "|", " ", " ", " ", "|"};
          Console.WriteLine();
          Console.WriteLine("[New Game]");
          Console.WriteLine();
          PrintBoard();
          GameLoop();
        }
        else
        {
          s_playAgain = false;
        }
      }

      // Checks All Possible Win Conditions and Draws
      static bool CheckWin()
      {
        if (s_boardLine1[4] == s_boardLine1[8]
          && s_boardLine1[8] == s_boardLine1[12] && s_boardLine1[4] != " ")
        {
          CheckWinner(s_boardLine1[4]);
          return true;
        }
        else if (s_boardLine2[4] == s_boardLine2[8]
          && s_boardLine2[8] == s_boardLine2[12] && s_boardLine2[4] != " ")
        {
          CheckWinner(s_boardLine2[4]);
          return true;
        }
        else if (s_boardLine3[4] == s_boardLine3[8]
          && s_boardLine3[8] == s_boardLine3[12] && s_boardLine3[4] != " ")
        {
          CheckWinner(s_boardLine3[4]);
          return true;
        }
        else if (s_boardLine1[4] == s_boardLine2[4]
          && s_boardLine2[4] == s_boardLine3[4] && s_boardLine1[4] != " ")
        {
          CheckWinner(s_boardLine1[4]);
          return true;
        }
        else if (s_boardLine1[8] == s_boardLine2[8]
          && s_boardLine2[8] == s_boardLine3[8] && s_boardLine1[8] != " ")
        {
          CheckWinner(s_boardLine1[8]);
          return true;
        }
        else if (s_boardLine1[12] == s_boardLine2[12]
          && s_boardLine2[12] == s_boardLine3[12] && s_boardLine1[12] != " ")
        {
          CheckWinner(s_boardLine1[12]); 
          return true;
        }
        else if (s_boardLine1[4] == s_boardLine2[8]
          && s_boardLine2[8] == s_boardLine3[12] && s_boardLine1[4] != " ")
        {
          CheckWinner(s_boardLine1[4]);
          return true;
        }
        else if (s_boardLine1[12] == s_boardLine2[8]
          && s_boardLine2[8] == s_boardLine3[4] && s_boardLine1[12] != " ")
        {
          CheckWinner(s_boardLine1[12]);
          return true;
        }
        else if (s_boardLine1[4] != " " && s_boardLine1[8] != " " 
          && s_boardLine1[12] != " " && s_boardLine2[4] != " "
          && s_boardLine2[8] != " " && s_boardLine2[12] != " "
          && s_boardLine3[4] != " " && s_boardLine3[8] != " "
          && s_boardLine3[12] != " ")
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
        if (symbol == s_playerXSymbol)
        {
          s_winner = s_playerX;
        }
        else
        {
          s_winner = s_playerO;
        }
      }

      // Sets the Players for the Game
      static void SetPlayers()
      {
        Console.Write("[Enter Player X]: ");
        s_playerX = Console.ReadLine();
        
        Console.Write("[Enter Player O]: ");
        s_playerO = Console.ReadLine();
        Console.WriteLine();
      }

      // Records the Move of the Player and Updates the Board, Also Checks for
      // Invalid Move Selections and Toggles Player Turns
      static void RecordMove()
      {
        if (s_playerXTurn)
        {
          Console.WriteLine("[" + s_playerX + "'s Turn]");
          Console.Write("[Enter Move Row]: ");
          s_row = int.Parse(Console.ReadLine());
          Console.Write("[Enter Move Column]: ");
          s_col = int.Parse(Console.ReadLine());
          Console.WriteLine();

          if (s_row == 1)
          {
            if (s_boardLine1[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine1[s_col * 4] = s_playerXSymbol;
              s_playerXTurn = !s_playerXTurn;
              PrintBoard();
            }
          }
          else if (s_row == 2)
          {
            if (s_boardLine2[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine2[s_col * 4] = s_playerXSymbol;
              s_playerXTurn = !s_playerXTurn;
              PrintBoard();
            }
          }
          else if (s_row == 3)
          {
            if (s_boardLine3[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine3[s_col * 4] = s_playerXSymbol;
              s_playerXTurn = !s_playerXTurn;
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
          Console.WriteLine("[" + s_playerO + "'s Turn]");
          Console.Write("[Enter Move Row]: ");
          s_row = int.Parse(Console.ReadLine());
          Console.Write("[Enter Move Column]: ");
          s_col = int.Parse(Console.ReadLine());
          Console.WriteLine();

          if (s_row == 1)
          {
            if (s_boardLine1[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine1[s_col * 4] = s_playerOSymbol;
              s_playerXTurn = !s_playerXTurn;
              PrintBoard();
            }
          }
          else if (s_row == 2)
          {
            if (s_boardLine2[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine2[s_col * 4] = s_playerOSymbol;
              s_playerXTurn = !s_playerXTurn;
              PrintBoard();
            }
          }
          else if (s_row == 3)
          {
            if (s_boardLine3[s_col * 4] != " ")
            {
              InvalidMove();
            }
            else
            {
              s_boardLine3[s_col * 4] = s_playerOSymbol;
              s_playerXTurn = !s_playerXTurn;
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
        Console.WriteLine(s_boardTop);
        Console.WriteLine(string.Join("", s_boardLine1));
        Console.WriteLine(string.Join("", s_boardLine2));
        Console.WriteLine(string.Join("", s_boardLine3));
        Console.WriteLine();
      }
    }
}