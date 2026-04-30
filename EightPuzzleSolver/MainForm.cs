using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightPuzzleSolver
{
    public partial class MainForm : Form
    {
        private readonly int[,] goalBoard = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
        private List<PuzzleState> currentSolutionPath;

        public MainForm()
        {
            InitializeComponent();

            cmbAlgorithm.Items.Add("BFS");
            cmbAlgorithm.Items.Add("LDFS");
            cmbAlgorithm.Items.Add("IDS");
            cmbAlgorithm.SelectedIndex = 0;
            numDepthLimit.Value = 20;
        }

        private int[,] ReadBoardFromUI()
        {
            int[,] board = new int[3, 3];
            TextBox[,] grid = {
                { txt00, txt01, txt02 },
                { txt10, txt11, txt12 },
                { txt20, txt21, txt22 }
            };

            HashSet<int> usedNumbers = new HashSet<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string text = grid[i, j].Text.Trim();
                    if (string.IsNullOrEmpty(text)) text = "0";

                    if (int.TryParse(text, out int val) && val >= 0 && val <= 8)
                    {
                        if (!usedNumbers.Add(val))
                            throw new Exception("Error! Numbers on the board must not repeat.");

                        board[i, j] = val;
                    }
                    else
                    {
                        throw new Exception("Please enter valid numbers from 0 to 8.");
                    }
                }
            }
            return board;
        }

        private void UpdateGridDisplay(PuzzleState state)
        {
            TextBox[,] grid = {
                { txt00, txt01, txt02 },
                { txt10, txt11, txt12 },
                { txt20, txt21, txt22 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j].Text = state.Board[i, j] == 0 ? "" : state.Board[i, j].ToString();
                }
            }
        }

        public void btnGenerate_Click(object sender, EventArgs e)
        {
            PuzzleGenerator generator = new PuzzleGenerator();
            PuzzleState randomState = generator.GenerateRandom();
            UpdateGridDisplay(randomState);
            lblSteps.Text = "Steps: -";
            lblTime.Text = "Time: -";
            lblNodes.Text = "Nodes: -";
            currentSolutionPath = null;
        }

        public async void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] startBoard = ReadBoardFromUI();
                PuzzleState startState = new PuzzleState(startBoard);

                PuzzleGenerator generator = new PuzzleGenerator();
                if (!generator.IsSolvable(startState.Board))
                {
                    MessageBox.Show("This configuration is mathematically unsolvable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string algorithm = cmbAlgorithm.SelectedItem?.ToString() ?? "";
                int nodesGenerated = 0;
                Stopwatch stopwatch = new Stopwatch();

                btnSolve.Enabled = false;
                btnGenerate.Enabled = false;

                currentSolutionPath = await Task.Run(() =>
                {
                    stopwatch.Start();
                    if (algorithm.Contains("BFS"))
                        return new BFSAlgorithm().FindPath(startState, goalBoard, out nodesGenerated);
                    else if (algorithm.Contains("LDFS"))
                        return new LDFSAlgorithm().FindPath(startState, goalBoard, (int)numDepthLimit.Value, out nodesGenerated);
                    else if (algorithm.Contains("IDS"))
                        return new IDSAlgorithm().FindPath(startState, goalBoard, out nodesGenerated);

                    return null;
                });

                stopwatch.Stop();

                if (currentSolutionPath != null)
                {
                    lblSteps.Text = $"Steps: {currentSolutionPath.Count - 1}";
                    lblTime.Text = $"Time: {stopwatch.ElapsedMilliseconds} ms";
                    lblNodes.Text = $"Nodes: {nodesGenerated}";

                    foreach (var state in currentSolutionPath)
                    {
                        UpdateGridDisplay(state);
                        await Task.Delay(400);
                    }
                }
                else
                {
                    MessageBox.Show("Solution not found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSolve.Enabled = true;
                btnGenerate.Enabled = true;
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (currentSolutionPath == null)
            {
                MessageBox.Show("No solution to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text files (*.txt)|*.txt", FileName = "8Puzzle_Result.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine("--- 8-Puzzle Solution Results ---");
                        writer.WriteLine(lblSteps.Text);
                        writer.WriteLine(lblTime.Text);
                        writer.WriteLine(lblNodes.Text);
                        writer.WriteLine("\n--- Steps ---");

                        for (int i = 0; i < currentSolutionPath.Count; i++)
                        {
                            writer.WriteLine($"Step {i}:");
                            var b = currentSolutionPath[i].Board;
                            for (int r = 0; r < 3; r++)
                                writer.WriteLine($"{b[r, 0]} {b[r, 1]} {b[r, 2]}");
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}