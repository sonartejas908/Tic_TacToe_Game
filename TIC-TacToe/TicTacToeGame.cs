using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TacToe
{
    class TicTacToeGame
    {


        public static void GameBoard()
        {

            char[] board = new char[10];
            int n = board.Length;
            for (int i = 1; i < n; i++)
            {
                board[i] = ' ';
            }
        }

        public static void UserInput()
        {
            Console.WriteLine(" Player1.Please Choose X or O");

            char Player1 = Convert.ToChar(Console.ReadLine());
            if(Player1 == 'X')
            {
                char player2 = 'O';
                Console.WriteLine("Player1 is {0} and Player2 is {1}",Player1,player2);

            }
            else
            {
                char player2 = 'X';
                Console.WriteLine("Player1 is {0} and Player2 is {1}",Player1,player2);
            }
        }
            
    }
}
