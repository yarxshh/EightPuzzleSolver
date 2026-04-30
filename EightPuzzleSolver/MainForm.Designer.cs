namespace EightPuzzleSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txt00 = new TextBox();
            txt01 = new TextBox();
            txt02 = new TextBox();
            txt12 = new TextBox();
            txt11 = new TextBox();
            txt10 = new TextBox();
            txt22 = new TextBox();
            txt21 = new TextBox();
            txt20 = new TextBox();
            cmbAlgorithm = new ComboBox();
            numDepthLimit = new NumericUpDown();
            btnGenerate = new Button();
            btnSolve = new Button();
            btnSave = new Button();
            lblSteps = new Label();
            lblTime = new Label();
            lblNodes = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numDepthLimit).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt00
            // 
            txt00.Font = new Font("Microsoft Sans Serif", 36F);
            txt00.Location = new Point(29, 8);
            txt00.Name = "txt00";
            txt00.Size = new Size(100, 62);
            txt00.TabIndex = 0;
            txt00.TextAlign = HorizontalAlignment.Center;
            // 
            // txt01
            // 
            txt01.Font = new Font("Microsoft Sans Serif", 36F);
            txt01.Location = new Point(135, 8);
            txt01.Name = "txt01";
            txt01.Size = new Size(100, 62);
            txt01.TabIndex = 1;
            txt01.TextAlign = HorizontalAlignment.Center;
            // 
            // txt02
            // 
            txt02.Font = new Font("Microsoft Sans Serif", 36F);
            txt02.Location = new Point(241, 8);
            txt02.Name = "txt02";
            txt02.Size = new Size(100, 62);
            txt02.TabIndex = 2;
            txt02.TextAlign = HorizontalAlignment.Center;
            // 
            // txt12
            // 
            txt12.Font = new Font("Microsoft Sans Serif", 36F);
            txt12.Location = new Point(241, 76);
            txt12.Name = "txt12";
            txt12.Size = new Size(100, 62);
            txt12.TabIndex = 5;
            txt12.TextAlign = HorizontalAlignment.Center;
            // 
            // txt11
            // 
            txt11.Font = new Font("Microsoft Sans Serif", 36F);
            txt11.Location = new Point(135, 76);
            txt11.Name = "txt11";
            txt11.Size = new Size(100, 62);
            txt11.TabIndex = 4;
            txt11.TextAlign = HorizontalAlignment.Center;
            // 
            // txt10
            // 
            txt10.Font = new Font("Microsoft Sans Serif", 36F);
            txt10.Location = new Point(29, 76);
            txt10.Name = "txt10";
            txt10.Size = new Size(100, 62);
            txt10.TabIndex = 3;
            txt10.TextAlign = HorizontalAlignment.Center;
            // 
            // txt22
            // 
            txt22.Font = new Font("Microsoft Sans Serif", 36F);
            txt22.Location = new Point(241, 144);
            txt22.Name = "txt22";
            txt22.Size = new Size(100, 62);
            txt22.TabIndex = 8;
            txt22.TextAlign = HorizontalAlignment.Center;
            // 
            // txt21
            // 
            txt21.Font = new Font("Microsoft Sans Serif", 36F);
            txt21.Location = new Point(135, 144);
            txt21.Name = "txt21";
            txt21.Size = new Size(100, 62);
            txt21.TabIndex = 7;
            txt21.TextAlign = HorizontalAlignment.Center;
            // 
            // txt20
            // 
            txt20.Font = new Font("Microsoft Sans Serif", 36F);
            txt20.Location = new Point(29, 144);
            txt20.Name = "txt20";
            txt20.Size = new Size(100, 62);
            txt20.TabIndex = 6;
            txt20.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.AccessibleName = "cmbAlgorithm";
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(29, 247);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(164, 23);
            cmbAlgorithm.TabIndex = 9;
            // 
            // numDepthLimit
            // 
            numDepthLimit.AccessibleName = "numDepthLimit";
            numDepthLimit.Location = new Point(241, 247);
            numDepthLimit.Name = "numDepthLimit";
            numDepthLimit.Size = new Size(96, 23);
            numDepthLimit.TabIndex = 10;
            // 
            // btnGenerate
            // 
            btnGenerate.AccessibleName = "btnGenerate";
            btnGenerate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnGenerate.Location = new Point(362, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 50);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSolve
            // 
            btnSolve.AccessibleName = "btnSolve";
            btnSolve.BackColor = SystemColors.GradientActiveCaption;
            btnSolve.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSolve.Location = new Point(362, 76);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(120, 50);
            btnSolve.TabIndex = 12;
            btnSolve.Text = "Find Solution";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleName = "btnSave";
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSave.Location = new Point(362, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save to File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Location = new Point(6, 19);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(46, 15);
            lblSteps.TabIndex = 14;
            lblSteps.Text = "Steps: -";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(6, 82);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(45, 15);
            lblTime.TabIndex = 15;
            lblTime.Text = "Time: -";
            // 
            // lblNodes
            // 
            lblNodes.AutoSize = true;
            lblNodes.Location = new Point(6, 150);
            lblNodes.Name = "lblNodes";
            lblNodes.Size = new Size(52, 15);
            lblNodes.TabIndex = 16;
            lblNodes.Text = "Nodes: -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.Location = new Point(29, 224);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 17;
            label4.Text = "Choose the algorithm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label5.Location = new Point(241, 224);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 18;
            label5.Text = "Limit(LDFS):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSteps);
            groupBox1.Controls.Add(lblTime);
            groupBox1.Controls.Add(lblNodes);
            groupBox1.Location = new Point(488, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(96, 182);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // MainForm
            // 
            AccessibleName = "8-Puzzle Solver";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 302);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(btnSolve);
            Controls.Add(btnGenerate);
            Controls.Add(numDepthLimit);
            Controls.Add(cmbAlgorithm);
            Controls.Add(txt22);
            Controls.Add(txt21);
            Controls.Add(txt20);
            Controls.Add(txt12);
            Controls.Add(txt11);
            Controls.Add(txt10);
            Controls.Add(txt02);
            Controls.Add(txt01);
            Controls.Add(txt00);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8-Puzzle Solver";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDepthLimit).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt00;
        private TextBox txt01;
        private TextBox txt02;
        private TextBox txt12;
        private TextBox txt11;
        private TextBox txt10;
        private TextBox txt22;
        private TextBox txt21;
        private TextBox txt20;
        private ComboBox cmbAlgorithm;
        private NumericUpDown numDepthLimit;
        private Button btnGenerate;
        private Button btnSolve;
        private Button btnSave;
        private Label lblSteps;
        private Label lblTime;
        private Label lblNodes;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
    }
}