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
            this.btnPlayerClearMove = new System.Windows.Forms.Button();
            this.btnPlayerCommitMove = new System.Windows.Forms.Button();
            this.lblPlayerMoveError = new System.Windows.Forms.Label();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.lblPlayerTarget = new System.Windows.Forms.Label();
            this.lblPlayerLocation = new System.Windows.Forms.Label();
            this.lblMoveType = new System.Windows.Forms.Label();
            this.rbPlayerTarget = new System.Windows.Forms.RadioButton();
            this.rbPlayerLocation = new System.Windows.Forms.RadioButton();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.nudPlayerSplitNumber = new System.Windows.Forms.NumericUpDown();
            this.rbPlayerSplit = new System.Windows.Forms.RadioButton();
            this.rbPlayerMove = new System.Windows.Forms.RadioButton();
            this.rbPlayerMerge = new System.Windows.Forms.RadioButton();
            this.rbPlayerDrop = new System.Windows.Forms.RadioButton();
            this.rbPlayerBlock = new System.Windows.Forms.RadioButton();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.rbPlayerBlue = new System.Windows.Forms.RadioButton();
            this.rbPlayerRed = new System.Windows.Forms.RadioButton();
            this.tpCpuPlayer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStackSize)).BeginInit();
            this.tpHumanPlayer.SuspendLayout();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerSplitNumber)).BeginInit();
            this.groupBoxPlayer.SuspendLayout();
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
            this.pbBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseClick);
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
            // chkBlueWin
            // 
            this.chkBlueWin.AutoSize = true;
            this.chkBlueWin.Location = new System.Drawing.Point(139, 153);
            this.chkBlueWin.Name = "chkBlueWin";
            this.chkBlueWin.Size = new System.Drawing.Size(74, 17);
            this.chkBlueWin.TabIndex = 12;
            this.chkBlueWin.Text = "Blue Wins";
            this.chkBlueWin.UseVisualStyleBackColor = true;
            this.chkBlueWin.CheckedChanged += new System.EventHandler(this.chkBlueWin_CheckedChanged);
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
            this.chkRedWin.CheckedChanged += new System.EventHandler(this.chkRedWin_CheckedChanged);
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
            this.chkBlueKingTaken.CheckedChanged += new System.EventHandler(this.chkBlueKingTaken_CheckedChanged);
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
            this.chkRedKingTaken.CheckedChanged += new System.EventHandler(this.chkRedKingTaken_CheckedChanged);
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
            this.chkBlueT2.CheckedChanged += new System.EventHandler(this.chkBlueT2_CheckedChanged);
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
            this.chkBlueT1.CheckedChanged += new System.EventHandler(this.chkBlueT1_CheckedChanged);
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
            this.chkRedT2.CheckedChanged += new System.EventHandler(this.chkRedT2_CheckedChanged);
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
            this.chkRedT1.CheckedChanged += new System.EventHandler(this.chkRedT1_CheckedChanged);
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
            this.chkCursed.CheckedChanged += new System.EventHandler(this.chkCursed_CheckedChanged);
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
            this.chkBlessed.CheckedChanged += new System.EventHandler(this.chkBlessed_CheckedChanged);
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
            this.chkKing.CheckedChanged += new System.EventHandler(this.chkKing_CheckedChanged);
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
            this.btnBlockadeHere.Text = "Blockade Here";
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
            this.tpHumanPlayer.Controls.Add(this.btnPlayerClearMove);
            this.tpHumanPlayer.Controls.Add(this.btnPlayerCommitMove);
            this.tpHumanPlayer.Controls.Add(this.lblPlayerMoveError);
            this.tpHumanPlayer.Controls.Add(this.groupBoxLocation);
            this.tpHumanPlayer.Controls.Add(this.groupBoxMove);
            this.tpHumanPlayer.Controls.Add(this.btnNewGame);
            this.tpHumanPlayer.Controls.Add(this.groupBoxPlayer);
            this.tpHumanPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpHumanPlayer.Name = "tpHumanPlayer";
            this.tpHumanPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpHumanPlayer.Size = new System.Drawing.Size(313, 424);
            this.tpHumanPlayer.TabIndex = 1;
            this.tpHumanPlayer.Text = "Human Player";
            this.tpHumanPlayer.UseVisualStyleBackColor = true;
            // 
            // btnPlayerClearMove
            // 
            this.btnPlayerClearMove.Location = new System.Drawing.Point(162, 55);
            this.btnPlayerClearMove.Name = "btnPlayerClearMove";
            this.btnPlayerClearMove.Size = new System.Drawing.Size(97, 23);
            this.btnPlayerClearMove.TabIndex = 13;
            this.btnPlayerClearMove.Text = "Clear Move";
            this.btnPlayerClearMove.UseVisualStyleBackColor = true;
            this.btnPlayerClearMove.Click += new System.EventHandler(this.btnPlayerClearMove_Click);
            // 
            // btnPlayerCommitMove
            // 
            this.btnPlayerCommitMove.Location = new System.Drawing.Point(7, 281);
            this.btnPlayerCommitMove.Name = "btnPlayerCommitMove";
            this.btnPlayerCommitMove.Size = new System.Drawing.Size(97, 23);
            this.btnPlayerCommitMove.TabIndex = 12;
            this.btnPlayerCommitMove.Text = "Commit Move";
            this.btnPlayerCommitMove.UseVisualStyleBackColor = true;
            this.btnPlayerCommitMove.Click += new System.EventHandler(this.btnPlayerCommitMove_Click);
            // 
            // lblPlayerMoveError
            // 
            this.lblPlayerMoveError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMoveError.Location = new System.Drawing.Point(6, 206);
            this.lblPlayerMoveError.Name = "lblPlayerMoveError";
            this.lblPlayerMoveError.Size = new System.Drawing.Size(299, 72);
            this.lblPlayerMoveError.TabIndex = 11;
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.lblPlayerTarget);
            this.groupBoxLocation.Controls.Add(this.lblPlayerLocation);
            this.groupBoxLocation.Controls.Add(this.lblMoveType);
            this.groupBoxLocation.Controls.Add(this.rbPlayerTarget);
            this.groupBoxLocation.Controls.Add(this.rbPlayerLocation);
            this.groupBoxLocation.Location = new System.Drawing.Point(7, 152);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(298, 51);
            this.groupBoxLocation.TabIndex = 3;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Select Location";
            // 
            // lblPlayerTarget
            // 
            this.lblPlayerTarget.Location = new System.Drawing.Point(239, 24);
            this.lblPlayerTarget.Name = "lblPlayerTarget";
            this.lblPlayerTarget.Size = new System.Drawing.Size(53, 18);
            this.lblPlayerTarget.TabIndex = 10;
            // 
            // lblPlayerLocation
            // 
            this.lblPlayerLocation.Location = new System.Drawing.Point(126, 24);
            this.lblPlayerLocation.Name = "lblPlayerLocation";
            this.lblPlayerLocation.Size = new System.Drawing.Size(53, 18);
            this.lblPlayerLocation.TabIndex = 9;
            // 
            // lblMoveType
            // 
            this.lblMoveType.Location = new System.Drawing.Point(8, 24);
            this.lblMoveType.Name = "lblMoveType";
            this.lblMoveType.Size = new System.Drawing.Size(53, 18);
            this.lblMoveType.TabIndex = 8;
            // 
            // rbPlayerTarget
            // 
            this.rbPlayerTarget.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerTarget.AutoSize = true;
            this.rbPlayerTarget.Location = new System.Drawing.Point(185, 19);
            this.rbPlayerTarget.Name = "rbPlayerTarget";
            this.rbPlayerTarget.Size = new System.Drawing.Size(48, 23);
            this.rbPlayerTarget.TabIndex = 7;
            this.rbPlayerTarget.TabStop = true;
            this.rbPlayerTarget.Text = "Target";
            this.rbPlayerTarget.UseVisualStyleBackColor = true;
            // 
            // rbPlayerLocation
            // 
            this.rbPlayerLocation.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerLocation.AutoSize = true;
            this.rbPlayerLocation.Location = new System.Drawing.Point(67, 19);
            this.rbPlayerLocation.Name = "rbPlayerLocation";
            this.rbPlayerLocation.Size = new System.Drawing.Size(58, 23);
            this.rbPlayerLocation.TabIndex = 6;
            this.rbPlayerLocation.TabStop = true;
            this.rbPlayerLocation.Text = "Location";
            this.rbPlayerLocation.UseVisualStyleBackColor = true;
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.nudPlayerSplitNumber);
            this.groupBoxMove.Controls.Add(this.rbPlayerSplit);
            this.groupBoxMove.Controls.Add(this.rbPlayerMove);
            this.groupBoxMove.Controls.Add(this.rbPlayerMerge);
            this.groupBoxMove.Controls.Add(this.rbPlayerDrop);
            this.groupBoxMove.Controls.Add(this.rbPlayerBlock);
            this.groupBoxMove.Location = new System.Drawing.Point(7, 92);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(298, 54);
            this.groupBoxMove.TabIndex = 2;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Select Move";
            // 
            // nudPlayerSplitNumber
            // 
            this.nudPlayerSplitNumber.Location = new System.Drawing.Point(248, 22);
            this.nudPlayerSplitNumber.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudPlayerSplitNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayerSplitNumber.Name = "nudPlayerSplitNumber";
            this.nudPlayerSplitNumber.Size = new System.Drawing.Size(41, 20);
            this.nudPlayerSplitNumber.TabIndex = 6;
            this.nudPlayerSplitNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbPlayerSplit
            // 
            this.rbPlayerSplit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerSplit.AutoSize = true;
            this.rbPlayerSplit.Location = new System.Drawing.Point(205, 19);
            this.rbPlayerSplit.Name = "rbPlayerSplit";
            this.rbPlayerSplit.Size = new System.Drawing.Size(37, 23);
            this.rbPlayerSplit.TabIndex = 5;
            this.rbPlayerSplit.TabStop = true;
            this.rbPlayerSplit.Text = "Split";
            this.rbPlayerSplit.UseVisualStyleBackColor = true;
            this.rbPlayerSplit.CheckedChanged += new System.EventHandler(this.rbPlayerSplit_CheckedChanged);
            // 
            // rbPlayerMove
            // 
            this.rbPlayerMove.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerMove.AutoSize = true;
            this.rbPlayerMove.Location = new System.Drawing.Point(155, 19);
            this.rbPlayerMove.Name = "rbPlayerMove";
            this.rbPlayerMove.Size = new System.Drawing.Size(44, 23);
            this.rbPlayerMove.TabIndex = 4;
            this.rbPlayerMove.TabStop = true;
            this.rbPlayerMove.Text = "Move";
            this.rbPlayerMove.UseVisualStyleBackColor = true;
            this.rbPlayerMove.CheckedChanged += new System.EventHandler(this.rbPlayerMove_CheckedChanged);
            // 
            // rbPlayerMerge
            // 
            this.rbPlayerMerge.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerMerge.AutoSize = true;
            this.rbPlayerMerge.Location = new System.Drawing.Point(102, 19);
            this.rbPlayerMerge.Name = "rbPlayerMerge";
            this.rbPlayerMerge.Size = new System.Drawing.Size(47, 23);
            this.rbPlayerMerge.TabIndex = 3;
            this.rbPlayerMerge.TabStop = true;
            this.rbPlayerMerge.Text = "Merge";
            this.rbPlayerMerge.UseVisualStyleBackColor = true;
            this.rbPlayerMerge.CheckedChanged += new System.EventHandler(this.rbPlayerMerge_CheckedChanged);
            // 
            // rbPlayerDrop
            // 
            this.rbPlayerDrop.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerDrop.AutoSize = true;
            this.rbPlayerDrop.Location = new System.Drawing.Point(56, 19);
            this.rbPlayerDrop.Name = "rbPlayerDrop";
            this.rbPlayerDrop.Size = new System.Drawing.Size(40, 23);
            this.rbPlayerDrop.TabIndex = 2;
            this.rbPlayerDrop.TabStop = true;
            this.rbPlayerDrop.Text = "Drop";
            this.rbPlayerDrop.UseVisualStyleBackColor = true;
            this.rbPlayerDrop.CheckedChanged += new System.EventHandler(this.rbPlayerDrop_CheckedChanged);
            // 
            // rbPlayerBlock
            // 
            this.rbPlayerBlock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerBlock.AutoSize = true;
            this.rbPlayerBlock.Location = new System.Drawing.Point(6, 19);
            this.rbPlayerBlock.Name = "rbPlayerBlock";
            this.rbPlayerBlock.Size = new System.Drawing.Size(44, 23);
            this.rbPlayerBlock.TabIndex = 1;
            this.rbPlayerBlock.TabStop = true;
            this.rbPlayerBlock.Text = "Block";
            this.rbPlayerBlock.UseVisualStyleBackColor = true;
            this.rbPlayerBlock.CheckedChanged += new System.EventHandler(this.rbPlayerBlock_CheckedChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(7, 7);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.rbPlayerBlue);
            this.groupBoxPlayer.Controls.Add(this.rbPlayerRed);
            this.groupBoxPlayer.Location = new System.Drawing.Point(7, 36);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(97, 50);
            this.groupBoxPlayer.TabIndex = 0;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Select Player";
            // 
            // rbPlayerBlue
            // 
            this.rbPlayerBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerBlue.AutoSize = true;
            this.rbPlayerBlue.Location = new System.Drawing.Point(49, 19);
            this.rbPlayerBlue.Name = "rbPlayerBlue";
            this.rbPlayerBlue.Size = new System.Drawing.Size(38, 23);
            this.rbPlayerBlue.TabIndex = 1;
            this.rbPlayerBlue.TabStop = true;
            this.rbPlayerBlue.Text = "Blue";
            this.rbPlayerBlue.UseVisualStyleBackColor = true;
            this.rbPlayerBlue.CheckedChanged += new System.EventHandler(this.rbPlayerBlue_CheckedChanged);
            // 
            // rbPlayerRed
            // 
            this.rbPlayerRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerRed.AutoSize = true;
            this.rbPlayerRed.Location = new System.Drawing.Point(6, 19);
            this.rbPlayerRed.Name = "rbPlayerRed";
            this.rbPlayerRed.Size = new System.Drawing.Size(37, 23);
            this.rbPlayerRed.TabIndex = 0;
            this.rbPlayerRed.TabStop = true;
            this.rbPlayerRed.Text = "Red";
            this.rbPlayerRed.UseVisualStyleBackColor = true;
            this.rbPlayerRed.CheckedChanged += new System.EventHandler(this.rbPlayerRed_CheckedChanged);
            // 
            // tpCpuPlayer
            // 
            this.tpCpuPlayer.Controls.Add(this.label2);
            this.tpCpuPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpCpuPlayer.Name = "tpCpuPlayer";
            this.tpCpuPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCpuPlayer.Size = new System.Drawing.Size(313, 424);
            this.tpCpuPlayer.TabIndex = 2;
            this.tpCpuPlayer.Text = "CPU Player";
            this.tpCpuPlayer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "(sorry, not yet)";
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
            this.tpHumanPlayer.ResumeLayout(false);
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerSplitNumber)).EndInit();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.tpCpuPlayer.ResumeLayout(false);
            this.tpCpuPlayer.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.RadioButton rbPlayerBlue;
        private System.Windows.Forms.RadioButton rbPlayerRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayerCommitMove;
        private System.Windows.Forms.Label lblPlayerMoveError;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.Label lblPlayerTarget;
        private System.Windows.Forms.Label lblPlayerLocation;
        private System.Windows.Forms.Label lblMoveType;
        private System.Windows.Forms.RadioButton rbPlayerTarget;
        private System.Windows.Forms.RadioButton rbPlayerLocation;
        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.RadioButton rbPlayerSplit;
        private System.Windows.Forms.RadioButton rbPlayerMove;
        private System.Windows.Forms.RadioButton rbPlayerMerge;
        private System.Windows.Forms.RadioButton rbPlayerDrop;
        private System.Windows.Forms.RadioButton rbPlayerBlock;
        private System.Windows.Forms.Button btnPlayerClearMove;
        private System.Windows.Forms.NumericUpDown nudPlayerSplitNumber;
    }
}

