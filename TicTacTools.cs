namespace tictactoe;

public class TicTacTools
{
    public string[] updateGameBoard(string[] gameBoard, int spot, bool turn)
    {
        while (spot < 1 || spot > gameBoard.Length || gameBoard[spot - 1] != spot.ToString())
        {
            Console.WriteLine($"Invalid spot. Choose a number between 1 and {gameBoard.Length}.");
            spot = int.Parse(Console.ReadLine());
        }

        if (turn)
        {
            gameBoard[spot - 1] = "X";
        }
        else
        {
            gameBoard[spot - 1] = "O";
        }
        return gameBoard;
    }

    public void printBoard(string[] gameBoard)
    {
        Console.WriteLine(gameBoard[0], gameBoard[1], gameBoard[2]);
        Console.WriteLine(gameBoard[3], gameBoard[4], gameBoard[5]);
        Console.WriteLine(gameBoard[6], gameBoard[7], gameBoard[8]);
    }
}