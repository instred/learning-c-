using System;

namespace TicTacToe
{
    public class Program
    {
        

        public static bool CheckWinner(string[,] board, int x, int y, string ch_checked)
        {
            // [1,2] [1,6] [1,10]
            // [3,2] [3,6] [3,10]
            // [5,2] [5,6] [5,10]


            // horizontal lines
            for (int i=1; i < y; i+=2)
            {
                if (board[i, 2] == ch_checked && board[i, 6] == ch_checked && board[i, 10] == ch_checked)
                {
                    return true;
                }
            }

            // vertical lines

            for (int i=2; i< x; i+=4)
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


        public static void MakeMove(string[,] current_board, int position, string ch_moving)
        {
            
            switch(position)
            {
                case 1:
                    current_board[1,2] = ch_moving;
                    break;
                case 2:
                    current_board[1,6] = ch_moving;
                    break;
                case 3:
                    current_board[1,10] = ch_moving;
                    break;
                case 4:
                    current_board[3,2] = ch_moving;
                    break;
                case 5:
                    current_board[3,6] = ch_moving;
                    break;
                case 6:
                    current_board[3,10] = ch_moving;
                    break;
                case 7:
                    current_board[5,2] = ch_moving;
                    break;
                case 8:
                    current_board[5,6] = ch_moving;
                    break;
                case 9:
                    current_board[5,10] = ch_moving;
                    break;
            }
        }

        public static void AddMoveCaptions(int[] available_moves)
        {
            Console.WriteLine("Available Moves:\n");
            for (int i=0; i < 9; i++)
            {
                if(available_moves[i] == 0)
                {
                    Console.Write($" [{i+1}] ");
                }
                else
                {
                    Console.Write($" [-] ");
                }
                if ((i+1) % 3 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
        }

        public static void GameLoop(Board board_obj)
        {

            string current_player = "X";
            int moves_count = 0;
            int[] available_moves = new int[9];
            int player = 1;
            string[,] current_board = board_obj.board;
            int x = board_obj.BoardX;
            int y = board_obj.BoardY;
            
            Array.Fill(available_moves, 0);
            

            board_obj.DrawBoard();

            while (!CheckWinner(current_board, x, y, current_player) && moves_count < 9)
            {
                
                if (moves_count % 2 == 1)
                {
                    current_player = "O";
                    player = 2;
                }
                else
                {
                    current_player = "X";
                    player = 1;
                }
                Console.WriteLine($"Player {player} to move. Select the position for {current_player}");

                AddMoveCaptions(available_moves); 
                string move = Console.ReadLine() ?? String.Empty;
                int movenum;

                while (!Int32.TryParse(move, out movenum) || movenum < 1 || movenum > 15 || available_moves[movenum-1] == -1)
                {
                    Console.Clear();
                    board_obj.DrawBoard();
                    Console.WriteLine("The place you picked is not available or the input is wrong :(");
                    AddMoveCaptions(available_moves); 
                    move = Console.ReadLine() ?? String.Empty;
                }


                MakeMove(current_board, movenum, current_player);
                available_moves[movenum-1] = -1;
                Console.Clear();
                board_obj.DrawBoard();

                Console.WriteLine(moves_count);
                moves_count++;
                

            }

            if (moves_count == 9)
            {
                Console.WriteLine("Unfortunately there was no winner :(");
                Console.WriteLine("Would you like to play another game? (y/n)");
            }
            else if (CheckWinner(current_board, x, y, current_player))
            {
                Console.WriteLine($"Player {player} won!");
                Console.WriteLine("Would you like to play another game? (y/n)");
            }
            
        }

        public static void Main(string[] args)
        {
            Board board_obj = new();
            do 
            {
                Console.Clear();
                Console.WriteLine("Welcome to a Tic Tac Toe game!\nThis is a game for two, so you need to bring some friend with you.\nPlayer 1 will start and have 'X' symbol. To start, press any button.");
                Console.ReadKey();
                Console.Clear();
                GameLoop(board_obj);
            }
            while (Console.ReadLine()=="y");

            
        }
    }
}
