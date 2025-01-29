namespace tictactoe;

public class TicTacTools
{
    // this function updates the gameBoard for tictactoe
    public void updateGameBoard(char[,] gameBoard, int spot, bool turn)
    {
        // this calculates the row and column to be changed or check if there is already a value
        int row = (spot - 1) / 3;
        int col = (spot - 1) % 3;

        // this loop checks if the input is out of range or if the spot is already taken
        while (spot < 1 || spot > 9 || gameBoard[row, col] == 'X' || gameBoard[row, col] == 'O')
        {
            Console.WriteLine($"Invalid spot. Choose a number between 1 and 9 that is not taken.");
            spot = int.Parse(Console.ReadLine());
            row = (spot - 1) / 3;
            col = (spot - 1) % 3;
        }

        // this assigns the value of X or O based on whose turn it is
        gameBoard[row, col] = turn ? 'X' : 'O';
    }

    // this will print the board
    public void printBoard(char[,] gameBoard)
    {
        Console.WriteLine($" {gameBoard[0, 0]} | {gameBoard[0, 1]} | {gameBoard[0, 2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {gameBoard[1, 0]} | {gameBoard[1, 1]} | {gameBoard[1, 2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {gameBoard[2, 0]} | {gameBoard[2, 1]} | {gameBoard[2, 2]} ");
    }

    // this checks if somebody won the game and returns a boolean
    public bool checkWinner(char[,] gameBoard)
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
            {
                return true; // A row has the same symbol
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
            {
                return true; // A column has the same symbol
            }
        }

        // Check diagonals
        if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
        {
            return true; // Top-left to bottom-right diagonal win
        }

        if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
        {
            return true; // Top-right to bottom-left diagonal win
        }

        return false; // No winner
    }
}