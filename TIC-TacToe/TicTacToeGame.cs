using System;
using System.Collections.Generic;
using System.Text;

namespace TIC_TacToe
{
    class TicTacToeGame
    {


        public static char[] GameBoard()
        {

            char[] board = new char[10];
            int n = board.Length;
            for (int i = 1; i < n; i++)
            {
                board[i] = ' ';
            }
            return board;
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

        public static void DisplayCurrentBoard(char[] board)
        {
            Console.WriteLine("{0} |{1} |{2}",board[1],board[2],board[3]);
            Console.WriteLine("--+--+--");
            Console.WriteLine("{0} |{1} |{2}",board[4], board[5], board[6]);
            Console.WriteLine("--+--+--");
            Console.WriteLine("{0} |{1} |{2}",board[7], board[8], board[9]);
        }
            
    }
}
