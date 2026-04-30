using System.Collections.Generic;

namespace EightPuzzleSolver
{
    public class LDFSAlgorithm
    {
        public List<PuzzleState> FindPath(PuzzleState start, int[,] goalBoard, int depthLimit, out int nodesGenerated)
        {
            nodesGenerated = 0;

            Stack<PuzzleState> stack = new Stack<PuzzleState>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                PuzzleState current = stack.Pop();

                if (current.IsGoal(goalBoard))
                {
                    return ReconstructPath(current);
                }

                if (current.Depth < depthLimit)
                {
                    List<PuzzleState> neighbors = current.GetNeighbors();

                    neighbors.Reverse();

                    foreach (PuzzleState neighbor in neighbors)
                    {
                        nodesGenerated++;

                        if (!IsCycle(neighbor))
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }

            return null;
        }

        private bool IsCycle(PuzzleState state)
        {
            PuzzleState ancestor = state.Parent;
            while (ancestor != null)
            {
                if (state.Equals(ancestor)) return true;
                ancestor = ancestor.Parent;
            }
            return false;
        }

        private List<PuzzleState> ReconstructPath(PuzzleState endState)
        {
            List<PuzzleState> path = new List<PuzzleState>();
            PuzzleState current = endState;

            while (current != null)
            {
                path.Add(current);
                current = current.Parent;
            }

            path.Reverse();
            return path;
        }
    }
}