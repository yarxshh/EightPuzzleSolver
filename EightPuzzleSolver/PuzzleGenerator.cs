using System;

namespace EightPuzzleSolver
{
    public class PuzzleGenerator
    {
        private Random random = new Random();

        public PuzzleState GenerateRandom()
        {
            int[] linearBoard = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = linearBoard.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = linearBoard[i];
                linearBoard[i] = linearBoard[j];
                linearBoard[j] = temp;
            }

            if (!IsSolvable(linearBoard))
            {
                if (linearBoard[0] != 0 && linearBoard[1] != 0)
                {
                    int temp = linearBoard[0];
                    linearBoard[0] = linearBoard[1];
                    linearBoard[1] = temp;
                }
                else
                {
                    int temp = linearBoard[linearBoard.Length - 1];
                    linearBoard[linearBoard.Length - 1] = linearBoard[linearBoard.Length - 2];
                    linearBoard[linearBoard.Length - 2] = temp;
                }
            }

            int[,] board2D = new int[3, 3];
            for (int i = 0; i < 9; i++)
            {
                board2D[i / 3, i % 3] = linearBoard[i];
            }

            return new PuzzleState(board2D);
        }

        public bool IsSolvable(int[] board)
        {
            int inversions = 0;
            for (int i = 0; i < board.Length - 1; i++)
            {
                for (int j = i + 1; j < board.Length; j++)
                {
                    if (board[i] != 0 && board[j] != 0 && board[i] > board[j])
                    {
                        inversions++;
                    }
                }
            }
            return inversions % 2 == 0;
        }

        public bool IsSolvable(int[,] board)
        {
            int[] linearBoard = new int[9];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    linearBoard[i * 3 + j] = board[i, j];
                }
            }
            return IsSolvable(linearBoard);
        }
    }
}