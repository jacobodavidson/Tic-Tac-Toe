# Tic-Tac-Toe Console Application

This is a simple console-based Tic-Tac-Toe game for two players. The game allows players to take turns entering their moves, checks for win conditions, and handles invalid moves. After the game ends, players are prompted to play again or exit.

## Features

- Two-player mode.
- Input validation for moves.
- Automatic win condition checks.
- Option to play again after the game ends.
- Simple and intuitive console-based interface.

## How to Play

1. Run the application.
2. Enter the names of Player X and Player O when prompted.
3. Players take turns entering their moves by specifying the row and column numbers (1-3).
4. The game checks for win conditions after each move:
   - Three symbols in a row (horizontal, vertical, or diagonal) result in a win.
   - If the board is full and no player has won, the game ends in a draw.
5. After the game ends, players can choose to play again or exit.

## Board Layout

The board is displayed as follows:

```
    1   2   3
1   X | O | X
   -----------
2   O | X | O
   -----------
3   X | O | X
```

- Rows and columns are labeled from 1 to 3.
- Players enter their moves by specifying the row and column numbers.

## How to Run

1. Open the project in your IDE (e.g., Visual Studio or Visual Studio Code).
2. Build the solution to ensure all dependencies are resolved.
3. Run the application from the terminal or IDE.

Alternatively, you can navigate to the directory containing the `Program.cs` file and run the following commands:

```bash
dotnet build
dotnet run
```

## File Structure

The main game logic is implemented in the `Program.cs` file located in the `Game` directory:

```
Tic-Tac-Toe/
├── Game/
│   ├── Game.csproj
│   ├── Program.cs
```

## Requirements

- .NET SDK installed on your system.
- A terminal or console to run the application.

## Author

- Jacob Davidson
