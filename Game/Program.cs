using System;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    class Program
    {
      // Set Players
      private static string player1 = "";
      private static string player1Symbol = "X";
      private static string player2 = "";
      private static string player2Symbol = "O";

      private static int x;
      private static int y;

      // Set Board Top & Bottom
      private static string[] boardTop = new string[] {" ", " ", "|", "-", "1",
        "-", "-", "-", "2", "-", "-", "-", "3", "-", "|"};
      private static string[] boardBot = new string[] {" ", " ", "|", "-", "-",
      "-", "-", "-", "-", "-", "-", "-", "-", "-", "|"};
      
      // Set Board Lines
      // Change element 4, 8, 12 to X or O later
      private static string[] boardLine1 = new string[] {"1", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine2 = new string[] {"2", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};
      private static string[] boardLine3 = new string[] {"3", " ", "|", " ",
        " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|"};

      static void Main(string[] args)
      {
          Console.WriteLine("[Welcome to Tic-Tac-Toe]");
          Console.WriteLine();

          SetPlayers();
          Console.WriteLine(player1 + " is X");
          Console.WriteLine(player2 + " is O");
          Console.WriteLine();




          PrintBoard();
      }

      static void SetPlayers()
      {
        Console.Write("Enter Player 1 (X): ");
        player1 = Console.ReadLine();
        
        Console.Write("Enter Player 2 (O): ");
        player2 = Console.ReadLine();
        Console.WriteLine();
      }

      static void RecordMove()
      {
        Console.Write("Enter Move Row: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Move Column: ");
        y = int.Parse(Console.ReadLine());
        
        if (x == 1)
        {

        } else if (x == 2)
        {

        } else if (x == 3)
        {

        } else
        {
          Console.WriteLine("Invalid Move");
          Console.WriteLine();
          RecordMove();
        }


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