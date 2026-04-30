using System.Collections.Generic;

namespace EightPuzzleSolver
{
    public class IDSAlgorithm
    {
        public List<PuzzleState> FindPath(PuzzleState start, int[,] goalBoard, out int totalNodesGenerated)
        {
            totalNodesGenerated = 0;
            int maxDepth = 50;

            LDFSAlgorithm ldfs = new LDFSAlgorithm();

            for (int depthLimit = 0; depthLimit <= maxDepth; depthLimit++)
            {
                int nodesAtCurrentDepth = 0;

                List<PuzzleState> result = ldfs.FindPath(start, goalBoard, depthLimit, out nodesAtCurrentDepth);

                totalNodesGenerated += nodesAtCurrentDepth;

                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
    }
}