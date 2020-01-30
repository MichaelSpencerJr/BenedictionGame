namespace Benediction.View
{
    partial class GamePlayerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEditor = new System.Windows.Forms.TabPage();
            this.btnEditBoard = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.chkCursePending = new System.Windows.Forms.CheckBox();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkBlueWin = new System.Windows.Forms.CheckBox();
            this.chkRedWin = new System.Windows.Forms.CheckBox();
            this.chkBlueKingTaken = new System.Windows.Forms.CheckBox();
            this.chkRedKingTaken = new System.Windows.Forms.CheckBox();
            this.chkBlueT2 = new System.Windows.Forms.CheckBox();
            this.chkBlueT1 = new System.Windows.Forms.CheckBox();
            this.chkRedT2 = new System.Windows.Forms.CheckBox();
            this.chkRedT1 = new System.Windows.Forms.CheckBox();
            this.btnBoardImageToClipboard = new System.Windows.Forms.Button();
            this.chkCursed = new System.Windows.Forms.CheckBox();
            this.chkBlessed = new System.Windows.Forms.CheckBox();
            this.chkKing = new System.Windows.Forms.CheckBox();
            this.nudStackSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBluePieceHere = new System.Windows.Forms.Button();
            this.btnRedPieceHere = new System.Windows.Forms.Button();
            this.btnBlockadeHere = new System.Windows.Forms.Button();
            this.btnBlueHomeHere = new System.Windows.Forms.Button();
            this.btnRedHomeHere = new System.Windows.Forms.Button();
            this.btnClearEmptyCell = new System.Windows.Forms.Button();
            this.btnUnselectCell = new System.Windows.Forms.Button();
            this.txtBoardData = new System.Windows.Forms.TextBox();
            this.btnImportBoard = new System.Windows.Forms.Button();
            this.btnExportBoard = new System.Windows.Forms.Button();
            this.btnClearBoard = new System.Windows.Forms.Button();
            this.tpHumanPlayer = new System.Windows.Forms.TabPage();
            this.btnCommitMove = new System.Windows.Forms.Button();
            this.btnClearMove = new System.Windows.Forms.Button();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.dgvGameState = new System.Windows.Forms.DataGridView();
            this.dgColumnTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColumnRedTurn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColumnRed2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColumnBlue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColumnBlue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tpCpuPlayer = new System.Windows.Forms.TabPage();
            this.btnCpuHighestMove = new System.Windows.Forms.Button();
            this.btnCpuCommitMove = new System.Windows.Forms.Button();
            this.btnCpuRandomMove = new System.Windows.Forms.Button();
            this.lstAvailableMoves = new System.Windows.Forms.ListBox();
            this.btnCpuAlphaBeta4 = new System.Windows.Forms.Button();
            this.btnCpuAlphaBeta8 = new System.Windows.Forms.Button();
            this.btnCpuAlphaBeta12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackSize)).BeginInit();
            this.tpHumanPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameState)).BeginInit();
            this.tpCpuPlayer.SuspendLayout();
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
            this.pbBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseDown);
            this.pbBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseMove);
            this.pbBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEditor);
            this.tabControl1.Controls.Add(this.tpHumanPlayer);
            this.tabControl1.Controls.Add(this.tpCpuPlayer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEditor
            // 
            this.tpEditor.Controls.Add(this.btnEditBoard);
            this.tpEditor.Controls.Add(this.btnSaveEdits);
            this.tpEditor.Controls.Add(this.chkCursePending);
            this.tpEditor.Controls.Add(this.chkLocked);
            this.tpEditor.Controls.Add(this.chkBlueWin);
            this.tpEditor.Controls.Add(this.chkRedWin);
            this.tpEditor.Controls.Add(this.chkBlueKingTaken);
            this.tpEditor.Controls.Add(this.chkRedKingTaken);
            this.tpEditor.Controls.Add(this.chkBlueT2);
            this.tpEditor.Controls.Add(this.chkBlueT1);
            this.tpEditor.Controls.Add(this.chkRedT2);
            this.tpEditor.Controls.Add(this.chkRedT1);
            this.tpEditor.Controls.Add(this.btnBoardImageToClipboard);
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
            // btnEditBoard
            // 
            this.btnEditBoard.Location = new System.Drawing.Point(196, 315);
            this.btnEditBoard.Name = "btnEditBoard";
            this.btnEditBoard.Size = new System.Drawing.Size(75, 39);
            this.btnEditBoard.TabIndex = 29;
            this.btnEditBoard.Text = "Edit Board";
            this.btnEditBoard.UseVisualStyleBackColor = true;
            this.btnEditBoard.Click += new System.EventHandler(this.btnEditBoard_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Location = new System.Drawing.Point(196, 360);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(75, 39);
            this.btnSaveEdits.TabIndex = 28;
            this.btnSaveEdits.Text = "Save Edits";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // chkCursePending
            // 
            this.chkCursePending.AutoSize = true;
            this.chkCursePending.Location = new System.Drawing.Point(87, 382);
            this.chkCursePending.Name = "chkCursePending";
            this.chkCursePending.Size = new System.Drawing.Size(92, 17);
            this.chkCursePending.TabIndex = 27;
            this.chkCursePending.Text = "CursePending";
            this.chkCursePending.UseVisualStyleBackColor = true;
            this.chkCursePending.CheckedChanged += new System.EventHandler(this.chkCell_CheckedChanged);
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(87, 359);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(62, 17);
            this.chkLocked.TabIndex = 26;
            this.chkLocked.Text = "Locked";
            this.chkLocked.UseVisualStyleBackColor = true;
            this.chkLocked.CheckedChanged += new System.EventHandler(this.chkCell_CheckedChanged);
            // 
            // chkBlueWin
            // 
            this.chkBlueWin.AutoSize = true;
            this.chkBlueWin.Location = new System.Drawing.Point(139, 153);
            this.chkBlueWin.Name = "chkBlueWin";
            this.chkBlueWin.Size = new System.Drawing.Size(74, 17);
            this.chkBlueWin.TabIndex = 12;
            this.chkBlueWin.Text = "Blue Wins";
            this.chkBlueWin.UseVisualStyleBackColor = true;
            this.chkBlueWin.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkRedWin
            // 
            this.chkRedWin.AutoSize = true;
            this.chkRedWin.Location = new System.Drawing.Point(6, 153);
            this.chkRedWin.Name = "chkRedWin";
            this.chkRedWin.Size = new System.Drawing.Size(73, 17);
            this.chkRedWin.TabIndex = 11;
            this.chkRedWin.Text = "Red Wins";
            this.chkRedWin.UseVisualStyleBackColor = true;
            this.chkRedWin.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkBlueKingTaken
            // 
            this.chkBlueKingTaken.AutoSize = true;
            this.chkBlueKingTaken.Location = new System.Drawing.Point(139, 130);
            this.chkBlueKingTaken.Name = "chkBlueKingTaken";
            this.chkBlueKingTaken.Size = new System.Drawing.Size(105, 17);
            this.chkBlueKingTaken.TabIndex = 10;
            this.chkBlueKingTaken.Text = "Blue King Taken";
            this.chkBlueKingTaken.UseVisualStyleBackColor = true;
            this.chkBlueKingTaken.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkRedKingTaken
            // 
            this.chkRedKingTaken.AutoSize = true;
            this.chkRedKingTaken.Location = new System.Drawing.Point(6, 130);
            this.chkRedKingTaken.Name = "chkRedKingTaken";
            this.chkRedKingTaken.Size = new System.Drawing.Size(104, 17);
            this.chkRedKingTaken.TabIndex = 9;
            this.chkRedKingTaken.Text = "Red King Taken";
            this.chkRedKingTaken.UseVisualStyleBackColor = true;
            this.chkRedKingTaken.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkBlueT2
            // 
            this.chkBlueT2.AutoSize = true;
            this.chkBlueT2.Location = new System.Drawing.Point(208, 107);
            this.chkBlueT2.Name = "chkBlueT2";
            this.chkBlueT2.Size = new System.Drawing.Size(63, 17);
            this.chkBlueT2.TabIndex = 8;
            this.chkBlueT2.Text = "Blue T2";
            this.chkBlueT2.UseVisualStyleBackColor = true;
            this.chkBlueT2.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkBlueT1
            // 
            this.chkBlueT1.AutoSize = true;
            this.chkBlueT1.Location = new System.Drawing.Point(139, 107);
            this.chkBlueT1.Name = "chkBlueT1";
            this.chkBlueT1.Size = new System.Drawing.Size(63, 17);
            this.chkBlueT1.TabIndex = 7;
            this.chkBlueT1.Text = "Blue T1";
            this.chkBlueT1.UseVisualStyleBackColor = true;
            this.chkBlueT1.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkRedT2
            // 
            this.chkRedT2.AutoSize = true;
            this.chkRedT2.Location = new System.Drawing.Point(71, 107);
            this.chkRedT2.Name = "chkRedT2";
            this.chkRedT2.Size = new System.Drawing.Size(62, 17);
            this.chkRedT2.TabIndex = 6;
            this.chkRedT2.Text = "Red T2";
            this.chkRedT2.UseVisualStyleBackColor = true;
            this.chkRedT2.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkRedT1
            // 
            this.chkRedT1.AutoSize = true;
            this.chkRedT1.Location = new System.Drawing.Point(6, 107);
            this.chkRedT1.Name = "chkRedT1";
            this.chkRedT1.Size = new System.Drawing.Size(62, 17);
            this.chkRedT1.TabIndex = 5;
            this.chkRedT1.Text = "Red T1";
            this.chkRedT1.UseVisualStyleBackColor = true;
            this.chkRedT1.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // btnBoardImageToClipboard
            // 
            this.btnBoardImageToClipboard.Location = new System.Drawing.Point(223, 6);
            this.btnBoardImageToClipboard.Name = "btnBoardImageToClipboard";
            this.btnBoardImageToClipboard.Size = new System.Drawing.Size(75, 39);
            this.btnBoardImageToClipboard.TabIndex = 3;
            this.btnBoardImageToClipboard.Text = "Board Image to Clipboard";
            this.btnBoardImageToClipboard.UseVisualStyleBackColor = true;
            this.btnBoardImageToClipboard.Click += new System.EventHandler(this.btnBoardImageToClipboard_Click);
            // 
            // chkCursed
            // 
            this.chkCursed.AutoSize = true;
            this.chkCursed.Location = new System.Drawing.Point(9, 382);
            this.chkCursed.Name = "chkCursed";
            this.chkCursed.Size = new System.Drawing.Size(59, 17);
            this.chkCursed.TabIndex = 24;
            this.chkCursed.Text = "Cursed";
            this.chkCursed.UseVisualStyleBackColor = true;
            this.chkCursed.CheckedChanged += new System.EventHandler(this.chkCell_CheckedChanged);
            // 
            // chkBlessed
            // 
            this.chkBlessed.AutoSize = true;
            this.chkBlessed.Location = new System.Drawing.Point(9, 359);
            this.chkBlessed.Name = "chkBlessed";
            this.chkBlessed.Size = new System.Drawing.Size(63, 17);
            this.chkBlessed.TabIndex = 23;
            this.chkBlessed.Text = "Blessed";
            this.chkBlessed.UseVisualStyleBackColor = true;
            this.chkBlessed.CheckedChanged += new System.EventHandler(this.chkCell_CheckedChanged);
            // 
            // chkKing
            // 
            this.chkKing.AutoSize = true;
            this.chkKing.Location = new System.Drawing.Point(9, 336);
            this.chkKing.Name = "chkKing";
            this.chkKing.Size = new System.Drawing.Size(47, 17);
            this.chkKing.TabIndex = 22;
            this.chkKing.Text = "King";
            this.chkKing.UseVisualStyleBackColor = true;
            this.chkKing.CheckedChanged += new System.EventHandler(this.chkCell_CheckedChanged);
            // 
            // nudStackSize
            // 
            this.nudStackSize.Location = new System.Drawing.Point(73, 310);
            this.nudStackSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudStackSize.Name = "nudStackSize";
            this.nudStackSize.Size = new System.Drawing.Size(60, 20);
            this.nudStackSize.TabIndex = 21;
            this.nudStackSize.ValueChanged += new System.EventHandler(this.nudStackSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stack Size:";
            // 
            // btnBluePieceHere
            // 
            this.btnBluePieceHere.Location = new System.Drawing.Point(87, 266);
            this.btnBluePieceHere.Name = "btnBluePieceHere";
            this.btnBluePieceHere.Size = new System.Drawing.Size(75, 39);
            this.btnBluePieceHere.TabIndex = 19;
            this.btnBluePieceHere.Text = "Blue Piece Here";
            this.btnBluePieceHere.UseVisualStyleBackColor = true;
            this.btnBluePieceHere.Click += new System.EventHandler(this.btnBluePieceHere_Click);
            // 
            // btnRedPieceHere
            // 
            this.btnRedPieceHere.Location = new System.Drawing.Point(6, 266);
            this.btnRedPieceHere.Name = "btnRedPieceHere";
            this.btnRedPieceHere.Size = new System.Drawing.Size(75, 39);
            this.btnRedPieceHere.TabIndex = 18;
            this.btnRedPieceHere.Text = "Red Piece Here";
            this.btnRedPieceHere.UseVisualStyleBackColor = true;
            this.btnRedPieceHere.Click += new System.EventHandler(this.btnRedPieceHere_Click);
            // 
            // btnBlockadeHere
            // 
            this.btnBlockadeHere.Location = new System.Drawing.Point(168, 221);
            this.btnBlockadeHere.Name = "btnBlockadeHere";
            this.btnBlockadeHere.Size = new System.Drawing.Size(75, 39);
            this.btnBlockadeHere.TabIndex = 17;
            this.btnBlockadeHere.Text = "Block Here";
            this.btnBlockadeHere.UseVisualStyleBackColor = true;
            this.btnBlockadeHere.Click += new System.EventHandler(this.btnBlockadeHere_Click);
            // 
            // btnBlueHomeHere
            // 
            this.btnBlueHomeHere.Location = new System.Drawing.Point(87, 221);
            this.btnBlueHomeHere.Name = "btnBlueHomeHere";
            this.btnBlueHomeHere.Size = new System.Drawing.Size(75, 39);
            this.btnBlueHomeHere.TabIndex = 16;
            this.btnBlueHomeHere.Text = "Blue Home Here";
            this.btnBlueHomeHere.UseVisualStyleBackColor = true;
            this.btnBlueHomeHere.Click += new System.EventHandler(this.btnBlueHomeHere_Click);
            // 
            // btnRedHomeHere
            // 
            this.btnRedHomeHere.Location = new System.Drawing.Point(6, 221);
            this.btnRedHomeHere.Name = "btnRedHomeHere";
            this.btnRedHomeHere.Size = new System.Drawing.Size(75, 39);
            this.btnRedHomeHere.TabIndex = 15;
            this.btnRedHomeHere.Text = "Red Home Here";
            this.btnRedHomeHere.UseVisualStyleBackColor = true;
            this.btnRedHomeHere.Click += new System.EventHandler(this.btnRedHomeHere_Click);
            // 
            // btnClearEmptyCell
            // 
            this.btnClearEmptyCell.Location = new System.Drawing.Point(87, 176);
            this.btnClearEmptyCell.Name = "btnClearEmptyCell";
            this.btnClearEmptyCell.Size = new System.Drawing.Size(75, 39);
            this.btnClearEmptyCell.TabIndex = 14;
            this.btnClearEmptyCell.Text = "Clear / Empty Cell";
            this.btnClearEmptyCell.UseVisualStyleBackColor = true;
            this.btnClearEmptyCell.Click += new System.EventHandler(this.btnClearEmptyCell_Click);
            // 
            // btnUnselectCell
            // 
            this.btnUnselectCell.Location = new System.Drawing.Point(6, 176);
            this.btnUnselectCell.Name = "btnUnselectCell";
            this.btnUnselectCell.Size = new System.Drawing.Size(75, 39);
            this.btnUnselectCell.TabIndex = 13;
            this.btnUnselectCell.Text = "Unselect Cell";
            this.btnUnselectCell.UseVisualStyleBackColor = true;
            this.btnUnselectCell.Click += new System.EventHandler(this.btnUnselectCell_Click);
            // 
            // txtBoardData
            // 
            this.txtBoardData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoardData.Location = new System.Drawing.Point(6, 51);
            this.txtBoardData.Multiline = true;
            this.txtBoardData.Name = "txtBoardData";
            this.txtBoardData.Size = new System.Drawing.Size(301, 50);
            this.txtBoardData.TabIndex = 4;
            // 
            // btnImportBoard
            // 
            this.btnImportBoard.Location = new System.Drawing.Point(156, 6);
            this.btnImportBoard.Name = "btnImportBoard";
            this.btnImportBoard.Size = new System.Drawing.Size(61, 39);
            this.btnImportBoard.TabIndex = 2;
            this.btnImportBoard.Text = "Import from Text";
            this.btnImportBoard.UseVisualStyleBackColor = true;
            this.btnImportBoard.Click += new System.EventHandler(this.btnImportBoard_Click);
            // 
            // btnExportBoard
            // 
            this.btnExportBoard.Location = new System.Drawing.Point(87, 6);
            this.btnExportBoard.Name = "btnExportBoard";
            this.btnExportBoard.Size = new System.Drawing.Size(63, 39);
            this.btnExportBoard.TabIndex = 1;
            this.btnExportBoard.Text = "Export as Text";
            this.btnExportBoard.UseVisualStyleBackColor = true;
            this.btnExportBoard.Click += new System.EventHandler(this.btnExportBoard_Click);
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
            // tpHumanPlayer
            // 
            this.tpHumanPlayer.Controls.Add(this.btnCommitMove);
            this.tpHumanPlayer.Controls.Add(this.btnClearMove);
            this.tpHumanPlayer.Controls.Add(this.txtMove);
            this.tpHumanPlayer.Controls.Add(this.dgvGameState);
            this.tpHumanPlayer.Controls.Add(this.btnNewGame);
            this.tpHumanPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpHumanPlayer.Name = "tpHumanPlayer";
            this.tpHumanPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpHumanPlayer.Size = new System.Drawing.Size(313, 424);
            this.tpHumanPlayer.TabIndex = 1;
            this.tpHumanPlayer.Text = "Human Player";
            this.tpHumanPlayer.UseVisualStyleBackColor = true;
            // 
            // btnCommitMove
            // 
            this.btnCommitMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommitMove.Location = new System.Drawing.Point(223, 374);
            this.btnCommitMove.Name = "btnCommitMove";
            this.btnCommitMove.Size = new System.Drawing.Size(82, 42);
            this.btnCommitMove.TabIndex = 5;
            this.btnCommitMove.Text = "Commit Move [Enter]";
            this.btnCommitMove.UseVisualStyleBackColor = true;
            this.btnCommitMove.Click += new System.EventHandler(this.btnCommitMove_Click);
            // 
            // btnClearMove
            // 
            this.btnClearMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearMove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearMove.Location = new System.Drawing.Point(6, 374);
            this.btnClearMove.Name = "btnClearMove";
            this.btnClearMove.Size = new System.Drawing.Size(75, 42);
            this.btnClearMove.TabIndex = 4;
            this.btnClearMove.Text = "Clear Move [Esc]";
            this.btnClearMove.UseVisualStyleBackColor = true;
            this.btnClearMove.Click += new System.EventHandler(this.btnClearMove_Click);
            // 
            // txtMove
            // 
            this.txtMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMove.Location = new System.Drawing.Point(6, 302);
            this.txtMove.Multiline = true;
            this.txtMove.Name = "txtMove";
            this.txtMove.ReadOnly = true;
            this.txtMove.Size = new System.Drawing.Size(299, 66);
            this.txtMove.TabIndex = 3;
            // 
            // dgvGameState
            // 
            this.dgvGameState.AllowUserToAddRows = false;
            this.dgvGameState.AllowUserToDeleteRows = false;
            this.dgvGameState.AllowUserToResizeColumns = false;
            this.dgvGameState.AllowUserToResizeRows = false;
            this.dgvGameState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGameState.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGameState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgColumnTurn,
            this.dgColumnRedTurn1,
            this.dgColumnRed2,
            this.dgColumnBlue1,
            this.dgColumnBlue2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGameState.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGameState.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGameState.Location = new System.Drawing.Point(6, 35);
            this.dgvGameState.Name = "dgvGameState";
            this.dgvGameState.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGameState.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGameState.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGameState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGameState.ShowCellErrors = false;
            this.dgvGameState.ShowEditingIcon = false;
            this.dgvGameState.Size = new System.Drawing.Size(299, 261);
            this.dgvGameState.TabIndex = 2;
            this.dgvGameState.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGameState_CellClick);
            // 
            // dgColumnTurn
            // 
            this.dgColumnTurn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgColumnTurn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgColumnTurn.HeaderText = "Turn";
            this.dgColumnTurn.MaxInputLength = 4;
            this.dgColumnTurn.Name = "dgColumnTurn";
            this.dgColumnTurn.ReadOnly = true;
            this.dgColumnTurn.Width = 54;
            // 
            // dgColumnRedTurn1
            // 
            this.dgColumnRedTurn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgColumnRedTurn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgColumnRedTurn1.HeaderText = "R1";
            this.dgColumnRedTurn1.Name = "dgColumnRedTurn1";
            this.dgColumnRedTurn1.ReadOnly = true;
            this.dgColumnRedTurn1.Width = 46;
            // 
            // dgColumnRed2
            // 
            this.dgColumnRed2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgColumnRed2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgColumnRed2.HeaderText = "R2";
            this.dgColumnRed2.Name = "dgColumnRed2";
            this.dgColumnRed2.ReadOnly = true;
            this.dgColumnRed2.Width = 46;
            // 
            // dgColumnBlue1
            // 
            this.dgColumnBlue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgColumnBlue1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgColumnBlue1.HeaderText = "B1";
            this.dgColumnBlue1.Name = "dgColumnBlue1";
            this.dgColumnBlue1.ReadOnly = true;
            this.dgColumnBlue1.Width = 45;
            // 
            // dgColumnBlue2
            // 
            this.dgColumnBlue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgColumnBlue2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgColumnBlue2.HeaderText = "B2";
            this.dgColumnBlue2.Name = "dgColumnBlue2";
            this.dgColumnBlue2.ReadOnly = true;
            this.dgColumnBlue2.Width = 45;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(6, 6);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tpCpuPlayer
            // 
            this.tpCpuPlayer.Controls.Add(this.btnCpuAlphaBeta12);
            this.tpCpuPlayer.Controls.Add(this.btnCpuAlphaBeta8);
            this.tpCpuPlayer.Controls.Add(this.btnCpuAlphaBeta4);
            this.tpCpuPlayer.Controls.Add(this.btnCpuHighestMove);
            this.tpCpuPlayer.Controls.Add(this.btnCpuCommitMove);
            this.tpCpuPlayer.Controls.Add(this.btnCpuRandomMove);
            this.tpCpuPlayer.Controls.Add(this.lstAvailableMoves);
            this.tpCpuPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpCpuPlayer.Name = "tpCpuPlayer";
            this.tpCpuPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCpuPlayer.Size = new System.Drawing.Size(313, 424);
            this.tpCpuPlayer.TabIndex = 2;
            this.tpCpuPlayer.Text = "CPU Player Preview";
            this.tpCpuPlayer.UseVisualStyleBackColor = true;
            // 
            // btnCpuHighestMove
            // 
            this.btnCpuHighestMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCpuHighestMove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCpuHighestMove.Location = new System.Drawing.Point(87, 374);
            this.btnCpuHighestMove.Name = "btnCpuHighestMove";
            this.btnCpuHighestMove.Size = new System.Drawing.Size(75, 42);
            this.btnCpuHighestMove.TabIndex = 8;
            this.btnCpuHighestMove.Text = "Select Highest";
            this.btnCpuHighestMove.UseVisualStyleBackColor = true;
            this.btnCpuHighestMove.Click += new System.EventHandler(this.btnCpuHighestMove_Click);
            // 
            // btnCpuCommitMove
            // 
            this.btnCpuCommitMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCpuCommitMove.Location = new System.Drawing.Point(223, 374);
            this.btnCpuCommitMove.Name = "btnCpuCommitMove";
            this.btnCpuCommitMove.Size = new System.Drawing.Size(82, 42);
            this.btnCpuCommitMove.TabIndex = 7;
            this.btnCpuCommitMove.Text = "Commit Selected";
            this.btnCpuCommitMove.UseVisualStyleBackColor = true;
            this.btnCpuCommitMove.Click += new System.EventHandler(this.btnCommitMove_Click);
            // 
            // btnCpuRandomMove
            // 
            this.btnCpuRandomMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCpuRandomMove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCpuRandomMove.Location = new System.Drawing.Point(6, 374);
            this.btnCpuRandomMove.Name = "btnCpuRandomMove";
            this.btnCpuRandomMove.Size = new System.Drawing.Size(75, 42);
            this.btnCpuRandomMove.TabIndex = 6;
            this.btnCpuRandomMove.Text = "Select Randomly";
            this.btnCpuRandomMove.UseVisualStyleBackColor = true;
            this.btnCpuRandomMove.Click += new System.EventHandler(this.btnCpuRandomMove_Click);
            // 
            // lstAvailableMoves
            // 
            this.lstAvailableMoves.FormattingEnabled = true;
            this.lstAvailableMoves.Location = new System.Drawing.Point(6, 37);
            this.lstAvailableMoves.Name = "lstAvailableMoves";
            this.lstAvailableMoves.Size = new System.Drawing.Size(299, 290);
            this.lstAvailableMoves.TabIndex = 0;
            this.lstAvailableMoves.SelectedIndexChanged += new System.EventHandler(this.lstAvailableMoves_SelectedIndexChanged);
            // 
            // btnCpuAlphaBeta4
            // 
            this.btnCpuAlphaBeta4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCpuAlphaBeta4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCpuAlphaBeta4.Location = new System.Drawing.Point(6, 333);
            this.btnCpuAlphaBeta4.Name = "btnCpuAlphaBeta4";
            this.btnCpuAlphaBeta4.Size = new System.Drawing.Size(75, 26);
            this.btnCpuAlphaBeta4.TabIndex = 9;
            this.btnCpuAlphaBeta4.Text = "α β depth 4";
            this.btnCpuAlphaBeta4.UseVisualStyleBackColor = true;
            this.btnCpuAlphaBeta4.Click += new System.EventHandler(this.btnCpuAlphaBeta3_Click);
            // 
            // btnCpuAlphaBeta8
            // 
            this.btnCpuAlphaBeta8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCpuAlphaBeta8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCpuAlphaBeta8.Location = new System.Drawing.Point(87, 333);
            this.btnCpuAlphaBeta8.Name = "btnCpuAlphaBeta8";
            this.btnCpuAlphaBeta8.Size = new System.Drawing.Size(75, 26);
            this.btnCpuAlphaBeta8.TabIndex = 10;
            this.btnCpuAlphaBeta8.Text = "α β depth 8";
            this.btnCpuAlphaBeta8.UseVisualStyleBackColor = true;
            // 
            // btnCpuAlphaBeta12
            // 
            this.btnCpuAlphaBeta12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCpuAlphaBeta12.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCpuAlphaBeta12.Location = new System.Drawing.Point(168, 333);
            this.btnCpuAlphaBeta12.Name = "btnCpuAlphaBeta12";
            this.btnCpuAlphaBeta12.Size = new System.Drawing.Size(83, 26);
            this.btnCpuAlphaBeta12.TabIndex = 11;
            this.btnCpuAlphaBeta12.Text = "α β depth 12";
            this.btnCpuAlphaBeta12.UseVisualStyleBackColor = true;
            // 
            // GamePlayerView
            // 
            this.AcceptButton = this.btnCommitMove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearMove;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GamePlayerView";
            this.Text = "Benediction Client Prototype";
            this.Load += new System.EventHandler(this.GamePlayerView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpEditor.ResumeLayout(false);
            this.tpEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackSize)).EndInit();
            this.tpHumanPlayer.ResumeLayout(false);
            this.tpHumanPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameState)).EndInit();
            this.tpCpuPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEditor;
        private System.Windows.Forms.TabPage tpHumanPlayer;
        private System.Windows.Forms.TabPage tpCpuPlayer;
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
        private System.Windows.Forms.Button btnBoardImageToClipboard;
        private System.Windows.Forms.CheckBox chkBlueWin;
        private System.Windows.Forms.CheckBox chkRedWin;
        private System.Windows.Forms.CheckBox chkBlueKingTaken;
        private System.Windows.Forms.CheckBox chkRedKingTaken;
        private System.Windows.Forms.CheckBox chkBlueT2;
        private System.Windows.Forms.CheckBox chkBlueT1;
        private System.Windows.Forms.CheckBox chkRedT2;
        private System.Windows.Forms.CheckBox chkRedT1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.CheckBox chkCursePending;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.DataGridView dgvGameState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColumnTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColumnRedTurn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColumnRed2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColumnBlue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColumnBlue2;
        private System.Windows.Forms.Button btnCommitMove;
        private System.Windows.Forms.Button btnClearMove;
        private System.Windows.Forms.TextBox txtMove;
        private System.Windows.Forms.ListBox lstAvailableMoves;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Button btnEditBoard;
        private System.Windows.Forms.Button btnCpuCommitMove;
        private System.Windows.Forms.Button btnCpuRandomMove;
        private System.Windows.Forms.Button btnCpuHighestMove;
        private System.Windows.Forms.Button btnCpuAlphaBeta12;
        private System.Windows.Forms.Button btnCpuAlphaBeta8;
        private System.Windows.Forms.Button btnCpuAlphaBeta4;
    }
}

