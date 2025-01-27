//using System;
//using System.Runtime.InteropServices;
using tictactoe;

// • Welcome the user to the game
Console.WriteLine("Welcome to TicTacToe!");


// • Create a game board array to store the players’ choices
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



while (gameWon != false || plays < 9)
{
    bool valid = false;
    //call print board method


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
        tic.updateGameBoard(gameBoard, spot, turn, valid);

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




