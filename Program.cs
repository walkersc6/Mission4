using System;
using System.Runtime.InteropServices;

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
//int plays = 0;
bool turn = true;

//create while loop that iterates while there is no winner or number of turns is 9
while (gameWon != false || plays < 9)
{
    //Ask each player in turn for their choice
    if (turn =  true)
    {
        string player = "Player 1";
    }
    else
    {
        string player = "Player 2";
    }

    //update the game board array

    updateGameBoard(gameBoard, spot, turn);

    //call print board method


    //Check for winner method
    if (turn == true)
    { 
        turn = false;
    }
    else
    {
        turn = true;
    }
}




