using tictactoe;

//Welcome the user to the game
Console.WriteLine("Welcome to TicTacToe!");

//Create a game board array to store the players’ choices
char[,] gameBoard = {
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

//keeps track to see if the game has been won
bool gameWon = false;
int plays = 0;
bool turn = true;

TicTacTools tic = new TicTacTools();

//Print the initial board
tic.printBoard(gameBoard);

//Loop while there is no winner and less than 9 plays
while (!gameWon && plays < 9)
{
    string player = turn ? "Player 1" : "Player 2";
    Console.WriteLine($"{player}: please enter a number between 1-9");

    int spot = int.Parse(Console.ReadLine());

    //Update the game board
    tic.updateGameBoard(gameBoard, spot, turn);

    //Print updated board
    tic.printBoard(gameBoard);

    //Check for winner
    gameWon = tic.checkWinner(gameBoard);

    if (gameWon)
    {
        Console.WriteLine($"{player} wins!");
    }

    //Switch turn
    turn = !turn;

    //Increase number of plays
    plays++;
}

//Game Over Message
if (!gameWon)
{
    Console.WriteLine("It's a tie!");
}

//make sure user sees who won and that the program doesn't end before the user wants it to
Console.WriteLine("Thank you for playing! Press enter to exit");
Console.ReadLine();