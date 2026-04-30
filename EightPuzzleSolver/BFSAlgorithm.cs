using System.Collections.Generic;

namespace EightPuzzleSolver
{
    public class BFSAlgorithm
    {
        public List<PuzzleState> FindPath(PuzzleState start, int[,] goalBoard, out int nodesGenerated)
        {
            nodesGenerated = 0;

            Queue<PuzzleState> queue = new Queue<PuzzleState>();

            HashSet<PuzzleState> visited = new HashSet<PuzzleState>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                PuzzleState current = queue.Dequeue();

                if (current.IsGoal(goalBoard))
                {
                    return ReconstructPath(current);
                }

                List<PuzzleState> neighbors = current.GetNeighbors();
                foreach (PuzzleState neighbor in neighbors)
                {
                    nodesGenerated++;

                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return null;
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