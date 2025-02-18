using System;

namespace Game
{
    class Program
    {
      //private string player1;
      //private string player2;

      private static string[] boardTop = new string[] {" ", " ", "|", "-", "1",
        "-", "-", "-", "2", "-", "-", "-", "3", "-", "|"};
      private static string[] boardBot = new string[] {" ", " ", "|", "-", "-",
      "-", "-", "-", "-", "-", "-", "-", "-", "-", "|"};
      
      // Change element 3, 7, 11 to X or O
      private static string[] boardLine1 = new string[] {"1", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine2 = new string[] {"2", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine3 = new string[] {"3", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};

      static void Main(string[] args)
      {
          Console.WriteLine("[Welcome to Tic-Tac-Toe]");

          boardLine1[4] = "X";
          PrintBoard();
      }

      static void PrintBoard()
      {
        Console.WriteLine(string.Join("", boardTop));
        Console.WriteLine(string.Join("", boardLine1));
        Console.WriteLine(string.Join("", boardLine2));
        Console.WriteLine(string.Join("", boardLine3));
        Console.WriteLine(string.Join("", boardBot));
      }


    }
}