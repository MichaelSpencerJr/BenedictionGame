namespace Benediction
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEditor = new System.Windows.Forms.TabPage();
            this.tpRed = new System.Windows.Forms.TabPage();
            this.tpBlue = new System.Windows.Forms.TabPage();
            this.btnClearBoard = new System.Windows.Forms.Button();
            this.btnExportBoard = new System.Windows.Forms.Button();
            this.btnImportBoard = new System.Windows.Forms.Button();
            this.txtBoardData = new System.Windows.Forms.TextBox();
            this.btnUnselectCell = new System.Windows.Forms.Button();
            this.btnClearEmptyCell = new System.Windows.Forms.Button();
            this.btnRedHomeHere = new System.Windows.Forms.Button();
            this.btnBlueHomeHere = new System.Windows.Forms.Button();
            this.btnBlockadeHere = new System.Windows.Forms.Button();
            this.btnRedPieceHere = new System.Windows.Forms.Button();
            this.btnBluePieceHere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStackSize = new System.Windows.Forms.NumericUpDown();
            this.chkKing = new System.Windows.Forms.CheckBox();
            this.chkBlessed = new System.Windows.Forms.CheckBox();
            this.chkCursed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(870, 450);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbBoard
            // 
            this.pbBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBoard.Location = new System.Drawing.Point(0, 0);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(545, 450);
            this.pbBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBoard.TabIndex = 0;
            this.pbBoard.TabStop = false;
            this.pbBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEditor);
            this.tabControl1.Controls.Add(this.tpRed);
            this.tabControl1.Controls.Add(this.tpBlue);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEditor
            // 
            this.tpEditor.Controls.Add(this.chkCursed);
            this.tpEditor.Controls.Add(this.chkBlessed);
            this.tpEditor.Controls.Add(this.chkKing);
            this.tpEditor.Controls.Add(this.nudStackSize);
            this.tpEditor.Controls.Add(this.label1);
            this.tpEditor.Controls.Add(this.btnBluePieceHere);
            this.tpEditor.Controls.Add(this.btnRedPieceHere);
            this.tpEditor.Controls.Add(this.btnBlockadeHere);
            this.tpEditor.Controls.Add(this.btnBlueHomeHere);
            this.tpEditor.Controls.Add(this.btnRedHomeHere);
            this.tpEditor.Controls.Add(this.btnClearEmptyCell);
            this.tpEditor.Controls.Add(this.btnUnselectCell);
            this.tpEditor.Controls.Add(this.txtBoardData);
            this.tpEditor.Controls.Add(this.btnImportBoard);
            this.tpEditor.Controls.Add(this.btnExportBoard);
            this.tpEditor.Controls.Add(this.btnClearBoard);
            this.tpEditor.Location = new System.Drawing.Point(4, 22);
            this.tpEditor.Name = "tpEditor";
            this.tpEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditor.Size = new System.Drawing.Size(313, 424);
            this.tpEditor.TabIndex = 0;
            this.tpEditor.Text = "Board Editor";
            this.tpEditor.UseVisualStyleBackColor = true;
            // 
            // tpRed
            // 
            this.tpRed.Location = new System.Drawing.Point(4, 22);
            this.tpRed.Name = "tpRed";
            this.tpRed.Padding = new System.Windows.Forms.Padding(3);
            this.tpRed.Size = new System.Drawing.Size(286, 424);
            this.tpRed.TabIndex = 1;
            this.tpRed.Text = "Red Move";
            this.tpRed.UseVisualStyleBackColor = true;
            // 
            // tpBlue
            // 
            this.tpBlue.Location = new System.Drawing.Point(4, 22);
            this.tpBlue.Name = "tpBlue";
            this.tpBlue.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlue.Size = new System.Drawing.Size(286, 424);
            this.tpBlue.TabIndex = 2;
            this.tpBlue.Text = "Blue Move";
            this.tpBlue.UseVisualStyleBackColor = true;
            // 
            // btnClearBoard
            // 
            this.btnClearBoard.Location = new System.Drawing.Point(6, 6);
            this.btnClearBoard.Name = "btnClearBoard";
            this.btnClearBoard.Size = new System.Drawing.Size(75, 39);
            this.btnClearBoard.TabIndex = 0;
            this.btnClearBoard.Text = "Clear Board";
            this.btnClearBoard.UseVisualStyleBackColor = true;
            this.btnClearBoard.Click += new System.EventHandler(this.btnClearBoard_Click);
            // 
            // btnExportBoard
            // 
            this.btnExportBoard.Location = new System.Drawing.Point(87, 6);
            this.btnExportBoard.Name = "btnExportBoard";
            this.btnExportBoard.Size = new System.Drawing.Size(75, 39);
            this.btnExportBoard.TabIndex = 1;
            this.btnExportBoard.Text = "Export as Text";
            this.btnExportBoard.UseVisualStyleBackColor = true;
            this.btnExportBoard.Click += new System.EventHandler(this.btnExportBoard_Click);
            // 
            // btnImportBoard
            // 
            this.btnImportBoard.Location = new System.Drawing.Point(168, 6);
            this.btnImportBoard.Name = "btnImportBoard";
            this.btnImportBoard.Size = new System.Drawing.Size(75, 39);
            this.btnImportBoard.TabIndex = 2;
            this.btnImportBoard.Text = "Import from Text";
            this.btnImportBoard.UseVisualStyleBackColor = true;
            this.btnImportBoard.Click += new System.EventHandler(this.btnImportBoard_Click);
            // 
            // txtBoardData
            // 
            this.txtBoardData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoardData.Location = new System.Drawing.Point(6, 51);
            this.txtBoardData.Multiline = true;
            this.txtBoardData.Name = "txtBoardData";
            this.txtBoardData.Size = new System.Drawing.Size(301, 50);
            this.txtBoardData.TabIndex = 3;
            // 
            // btnUnselectCell
            // 
            this.btnUnselectCell.Location = new System.Drawing.Point(6, 127);
            this.btnUnselectCell.Name = "btnUnselectCell";
            this.btnUnselectCell.Size = new System.Drawing.Size(75, 39);
            this.btnUnselectCell.TabIndex = 4;
            this.btnUnselectCell.Text = "Unselect Cell";
            this.btnUnselectCell.UseVisualStyleBackColor = true;
            this.btnUnselectCell.Click += new System.EventHandler(this.btnUnselectCell_Click);
            // 
            // btnClearEmptyCell
            // 
            this.btnClearEmptyCell.Location = new System.Drawing.Point(87, 127);
            this.btnClearEmptyCell.Name = "btnClearEmptyCell";
            this.btnClearEmptyCell.Size = new System.Drawing.Size(75, 39);
            this.btnClearEmptyCell.TabIndex = 5;
            this.btnClearEmptyCell.Text = "Clear / Empty Cell";
            this.btnClearEmptyCell.UseVisualStyleBackColor = true;
            this.btnClearEmptyCell.Click += new System.EventHandler(this.btnClearEmptyCell_Click);
            // 
            // btnRedHomeHere
            // 
            this.btnRedHomeHere.Location = new System.Drawing.Point(6, 172);
            this.btnRedHomeHere.Name = "btnRedHomeHere";
            this.btnRedHomeHere.Size = new System.Drawing.Size(75, 39);
            this.btnRedHomeHere.TabIndex = 6;
            this.btnRedHomeHere.Text = "Red Home Here";
            this.btnRedHomeHere.UseVisualStyleBackColor = true;
            this.btnRedHomeHere.Click += new System.EventHandler(this.btnRedHomeHere_Click);
            // 
            // btnBlueHomeHere
            // 
            this.btnBlueHomeHere.Location = new System.Drawing.Point(87, 172);
            this.btnBlueHomeHere.Name = "btnBlueHomeHere";
            this.btnBlueHomeHere.Size = new System.Drawing.Size(75, 39);
            this.btnBlueHomeHere.TabIndex = 7;
            this.btnBlueHomeHere.Text = "Blue Home Here";
            this.btnBlueHomeHere.UseVisualStyleBackColor = true;
            this.btnBlueHomeHere.Click += new System.EventHandler(this.btnBlueHomeHere_Click);
            // 
            // btnBlockadeHere
            // 
            this.btnBlockadeHere.Location = new System.Drawing.Point(168, 172);
            this.btnBlockadeHere.Name = "btnBlockadeHere";
            this.btnBlockadeHere.Size = new System.Drawing.Size(75, 39);
            this.btnBlockadeHere.TabIndex = 8;
            this.btnBlockadeHere.Text = "Blockade Here";
            this.btnBlockadeHere.UseVisualStyleBackColor = true;
            this.btnBlockadeHere.Click += new System.EventHandler(this.btnBlockadeHere_Click);
            // 
            // btnRedPieceHere
            // 
            this.btnRedPieceHere.Location = new System.Drawing.Point(6, 217);
            this.btnRedPieceHere.Name = "btnRedPieceHere";
            this.btnRedPieceHere.Size = new System.Drawing.Size(75, 39);
            this.btnRedPieceHere.TabIndex = 9;
            this.btnRedPieceHere.Text = "Red Piece Here";
            this.btnRedPieceHere.UseVisualStyleBackColor = true;
            this.btnRedPieceHere.Click += new System.EventHandler(this.btnRedPieceHere_Click);
            // 
            // btnBluePieceHere
            // 
            this.btnBluePieceHere.Location = new System.Drawing.Point(87, 217);
            this.btnBluePieceHere.Name = "btnBluePieceHere";
            this.btnBluePieceHere.Size = new System.Drawing.Size(75, 39);
            this.btnBluePieceHere.TabIndex = 10;
            this.btnBluePieceHere.Text = "Blue Piece Here";
            this.btnBluePieceHere.UseVisualStyleBackColor = true;
            this.btnBluePieceHere.Click += new System.EventHandler(this.btnBluePieceHere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stack Size:";
            // 
            // nudStackSize
            // 
            this.nudStackSize.Location = new System.Drawing.Point(73, 261);
            this.nudStackSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudStackSize.Name = "nudStackSize";
            this.nudStackSize.Size = new System.Drawing.Size(60, 20);
            this.nudStackSize.TabIndex = 12;
            this.nudStackSize.ValueChanged += new System.EventHandler(this.nudStackSize_ValueChanged);
            // 
            // chkKing
            // 
            this.chkKing.AutoSize = true;
            this.chkKing.Location = new System.Drawing.Point(9, 287);
            this.chkKing.Name = "chkKing";
            this.chkKing.Size = new System.Drawing.Size(47, 17);
            this.chkKing.TabIndex = 13;
            this.chkKing.Text = "King";
            this.chkKing.UseVisualStyleBackColor = true;
            this.chkKing.CheckedChanged += new System.EventHandler(this.chkKing_CheckedChanged);
            // 
            // chkBlessed
            // 
            this.chkBlessed.AutoSize = true;
            this.chkBlessed.Location = new System.Drawing.Point(9, 310);
            this.chkBlessed.Name = "chkBlessed";
            this.chkBlessed.Size = new System.Drawing.Size(63, 17);
            this.chkBlessed.TabIndex = 14;
            this.chkBlessed.Text = "Blessed";
            this.chkBlessed.UseVisualStyleBackColor = true;
            this.chkBlessed.CheckedChanged += new System.EventHandler(this.chkBlessed_CheckedChanged);
            // 
            // chkCursed
            // 
            this.chkCursed.AutoSize = true;
            this.chkCursed.Location = new System.Drawing.Point(9, 333);
            this.chkCursed.Name = "chkCursed";
            this.chkCursed.Size = new System.Drawing.Size(59, 17);
            this.chkCursed.TabIndex = 15;
            this.chkCursed.Text = "Cursed";
            this.chkCursed.UseVisualStyleBackColor = true;
            this.chkCursed.CheckedChanged += new System.EventHandler(this.chkCursed_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Benediction Client Prototype";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpEditor.ResumeLayout(false);
            this.tpEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEditor;
        private System.Windows.Forms.TabPage tpRed;
        private System.Windows.Forms.TabPage tpBlue;
        private System.Windows.Forms.Button btnImportBoard;
        private System.Windows.Forms.Button btnExportBoard;
        private System.Windows.Forms.Button btnClearBoard;
        private System.Windows.Forms.TextBox txtBoardData;
        private System.Windows.Forms.Button btnBlueHomeHere;
        private System.Windows.Forms.Button btnRedHomeHere;
        private System.Windows.Forms.Button btnClearEmptyCell;
        private System.Windows.Forms.Button btnUnselectCell;
        private System.Windows.Forms.Button btnBluePieceHere;
        private System.Windows.Forms.Button btnRedPieceHere;
        private System.Windows.Forms.Button btnBlockadeHere;
        private System.Windows.Forms.CheckBox chkCursed;
        private System.Windows.Forms.CheckBox chkBlessed;
        private System.Windows.Forms.CheckBox chkKing;
        private System.Windows.Forms.NumericUpDown nudStackSize;
        private System.Windows.Forms.Label label1;
    }
}

