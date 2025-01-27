//using System;
//using System.Runtime.InteropServices;
using tictactoe;

//Welcome the user to the game
Console.WriteLine("Welcome to TicTacToe!");


//Create a game board array to store the players’ choices
string[] gameBoard =
{
    "1", "2", "3",
    "4", "5", "6",
    "7", "8", "9"
};

bool gameWon = false;
int plays = 0;
bool turn = true;

TicTacTools tic = new TicTacTools();

//create while loop that iterates while there is no winner or number of turns is 9


tic.printBoard(gameBoard);

while (gameWon != false || plays < 9)
{
   
    string player = "";

    //Ask each player in turn for their choice
    if (turn == true)
    {
        player = "Player 1";
    }
    else
    {
        player = "Player 2";
    }

        Console.WriteLine(player + ": please enter a number between 1-9");
        int spot = int.Parse(Console.ReadLine());

        //update the game board array
        tic.updateGameBoard(gameBoard, spot, turn);

    //call print board method
    tic.printBoard(gameBoard);

    //Check for winner method

    //change which player's turn it is
    if (turn == true)
    { 
        turn = false;
    }
    else
    {
        turn = true;
    }

    //increase number of plays
    plays++;
}


//Console.Write(gameBoard[0], gameBoard[1], gameBoard[2])
//Console.Write(gameBoard[3], gameBoard[4], gameBoard[5])
//Console.Write(gameBoard[6], gameBoard[7], gameBoard[8])



