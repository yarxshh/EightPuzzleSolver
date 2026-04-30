using System;
using System.Collections.Generic;
using System.Linq;

namespace EightPuzzleSolver
{
    public class PuzzleState
    {
        public int[,] Board { get; set; }

        public int EmptyRow { get; set; }
        public int EmptyCol { get; set; }

        public PuzzleState Parent { get; set; }

        public int Depth { get; set; }

        public PuzzleState(int[,] board, PuzzleState parent = null, int depth = 0)
        {
            Board = (int[,])board.Clone();
            Parent = parent;
            Depth = depth;
            FindEmptyTile();
        }

        private void FindEmptyTile()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] == 0)
                    {
                        EmptyRow = i;
                        EmptyCol = j;
                        return;
                    }
                }
            }
        }

        public bool IsGoal(int[,] goalBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] != goalBoard[i, j]) return false;
                }
            }
            return true;
        }

        public List<PuzzleState> GetNeighbors()
        {
            List<PuzzleState> neighbors = new List<PuzzleState>();
            int[] dRow = { -1, 1, 0, 0 };
            int[] dCol = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int newRow = EmptyRow + dRow[i];
                int newCol = EmptyCol + dCol[i];

                if (newRow >= 0 && newRow < 3 && newCol >= 0 && newCol < 3)
                {
                    int[,] newBoard = (int[,])Board.Clone();
                    newBoard[EmptyRow, EmptyCol] = newBoard[newRow, newCol];
                    newBoard[newRow, newCol] = 0;

                    neighbors.Add(new PuzzleState(newBoard, this, Depth + 1));
                }
            }
            return neighbors;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PuzzleState other)) return false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] != other.Board[i, j]) return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            foreach (var item in Board)
            {
                hash = hash * 31 + item.GetHashCode();
            }
            return hash;
        }
    }
}
