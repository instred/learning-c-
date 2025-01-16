using System;

namespace TicTacToe
{
    public class Program
    {
        public const int board_x = 13;
        public const int board_y = 7;
        

        public static string[,] InitializeBoard()
        {
            string[,] board = new string[board_y,board_x];
            string boundary = "*";

            for (int i=0; i < board_y; i++)
            {

                for (int j=0; j<board_x; j++)
                {

                    if (i % 2 == 0 || j % 4 == 0)
                    {
                        board[i, j] = boundary;
                    }
                    else 
                    {
                        board[i, j] = " ";
                    }
                }
            }
            return board;
            
        }

        public static void DrawBoard(string[,] board)
        {

            for (int i=0; i< board_y; i++)
            {
                for (int j=0; j < board_x; j++)

                {
                    Console.Write(board[i,j]);
                }

                Console.WriteLine();
            }
        }

        public static bool CheckWinner(string[,] board, string ch_checked)
        {
            // [1,2] [1,6] [1,10]
            // [3,2] [3,6] [3,10]
            // [5,2] [5,6] [5,10]

            // horizontal lines
            for (int i=1; i<board_y; i+=2)
            {
                if (board[i, 2] == ch_checked && board[i, 6] == ch_checked && board[i, 10] == ch_checked)
                {
                    return true;
                }
            }

            // vertical lines

            for (int i=2; i<board_x; i+=4)
            {
                if (board[1, i] == ch_checked && board[3, i] == ch_checked && board[5, i] == ch_checked)
                {
                    return true;
                }
            }

            // cross lines

            if ((board[1, 2] == ch_checked && board[3, 6] == ch_checked && board[5,10] == ch_checked) || (board[1, 10] == ch_checked && board[3, 6] == ch_checked && board[5,2] == ch_checked))
            {
                return true;
            }
            
            return false;

        }


        public static void MakeMove(string[,] board, int position, string ch_moving)
        {
            switch(position)
            {
                case 1:
                    board[1,2] = ch_moving;
                    break;
                case 2:
                    board[1,6] = ch_moving;
                    break;
                case 3:
                    board[1,10] = ch_moving;
                    break;
                case 4:
                    board[3,2] = ch_moving;
                    break;
                case 5:
                    board[3,6] = ch_moving;
                    break;
                case 6:
                    board[3,10] = ch_moving;
                    break;
                case 7:
                    board[5,2] = ch_moving;
                    break;
                case 8:
                    board[5,6] = ch_moving;
                    break;
                case 9:
                    board[5,10] = ch_moving;
                    break;
            }
        }

        public static void AddMoveCaptions()
        {
            Console.WriteLine("[1] - left top\n[2] - mid top\n[3] - right top\n[4] - left middle\n[5] - mid middle\n[6] - right middle\n[7] - left bot\n[8] - mid bot\n[9] - right bot\n");
        }

        public static void GameLoop(string[,] board)
        {

            string current_player = "X";
            int moves_count = 0;

            DrawBoard(board);

            while (!CheckWinner(board, current_player) && moves_count < 16)
            {
                if (moves_count % 2 == 1)
                {
                    current_player = "O";
                }
                else
                {
                    current_player = "X";
                }

                AddMoveCaptions();
                string move = Console.ReadLine() ?? String.Empty;
                int movenum;

                while (!Int32.TryParse(move, out movenum))
                {
                    Console.WriteLine();
                    move = Console.ReadLine() ?? String.Empty;
                }

                MakeMove(board, movenum, current_player);
                DrawBoard(board);

                moves_count++;
                
                // Console.WriteLine(moves_count);

            }
            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Tic Tac Toe game!\nThis is a game for two, so you need to bring some friend with you.\nPlayer 1 will start and have 'X' symbol. To start, pick a position to add 'X':");
            string[,] board = InitializeBoard();
            GameLoop(board);
            
        }
    }
}


// Remove from the list those fields that are present on the board - as from the console writes
// Add so the player cannot override field that is already marked
// Add some caption for congrats for winning player + caption for game with no winner