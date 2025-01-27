namespace tictactoe;

public class TicTacTools
{
    public string[] updateGameBoard(string[] gameBoard, int spot, bool turn)
    {
        if (spot < 1 || spot > gameBoard.Length)
        {
            Console.WriteLine($"Invalid spot. Choose a number between 1 and {gameBoard.Length}.");
            return gameBoard;
        }
        
        if (gameBoard[spot - 1] != spot.ToString())
        {
            Console.WriteLine("Spot already taken. Choose a different one");
            return gameBoard;
        }
        else
        {
            if (turn)
            {
                gameBoard[spot - 1] = "X";
            }
            else
            {
                gameBoard[spot - 1] = "O";
            }
        }
        return gameBoard;

    }
}