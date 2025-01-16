

namespace TicTacToe
{

    public class Board
    {


        private readonly int board_x;
        private readonly int board_y;
        public string[,] board;


        public Board()
        {
            board_x = 13;
            board_y = 7;
            board = new string[board_y,board_x];

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
        }

        public int BoardX
        {
            get { return board_x; }
        }

        // Property to get board_y
        public int BoardY
        {
            get { return board_y; }
        }

        
        public void DrawBoard()
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
    }




}