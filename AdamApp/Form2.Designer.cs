namespace AdamApp
{
    partial class Form2
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
            this.Title = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.TbxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.BtnHit = new System.Windows.Forms.Button();
            this.BtnStand = new System.Windows.Forms.Button();
            this.LsvPlayerHand = new System.Windows.Forms.ListView();
            this.columnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LsvComputerHand = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.LsvResults = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(28, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 29);
            this.Title.TabIndex = 23;
            this.Title.Text = "Game App";
            this.Title.UseWaitCursor = true;
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2});
            this.LsvGameStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvGameStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.HideSelection = false;
            this.LsvGameStatistics.Location = new System.Drawing.Point(810, 642);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(137, 36);
            this.LsvGameStatistics.TabIndex = 22;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.UseWaitCursor = true;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "GameName";
            this.columnHeader8.Width = 196;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PlayerScore";
            this.columnHeader9.Width = 177;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ComputerScore";
            this.columnHeader1.Width = 211;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Winner";
            this.columnHeader2.Width = 505;
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerScore.Location = new System.Drawing.Point(388, 133);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(20, 24);
            this.LblPlayerScore.TabIndex = 21;
            this.LblPlayerScore.Text = "0";
            this.LblPlayerScore.UseWaitCursor = true;
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputerScore.Location = new System.Drawing.Point(825, 133);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(20, 24);
            this.LblComputerScore.TabIndex = 20;
            this.LblComputerScore.Text = "0";
            this.LblComputerScore.UseWaitCursor = true;
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(733, 522);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(234, 51);
            this.BtnFindOverallWinner.TabIndex = 19;
            this.BtnFindOverallWinner.Text = "Find Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            this.BtnFindOverallWinner.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Player Score";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Computer Score";
            this.label3.UseWaitCursor = true;
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(156, 99);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(196, 21);
            this.CbxGame.TabIndex = 16;
            this.CbxGame.UseWaitCursor = true;
            // 
            // TbxPlayerName
            // 
            this.TbxPlayerName.Location = new System.Drawing.Point(156, 46);
            this.TbxPlayerName.Name = "TbxPlayerName";
            this.TbxPlayerName.Size = new System.Drawing.Size(196, 20);
            this.TbxPlayerName.TabIndex = 15;
            this.TbxPlayerName.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pick Game";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Name";
            this.label1.UseWaitCursor = true;
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayGame.Location = new System.Drawing.Point(33, 121);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(121, 51);
            this.BtnPlayGame.TabIndex = 12;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            this.BtnPlayGame.UseWaitCursor = true;
            // 
            // BtnHit
            // 
            this.BtnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHit.Location = new System.Drawing.Point(32, 251);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(76, 40);
            this.BtnHit.TabIndex = 24;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.UseWaitCursor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click_1);
            // 
            // BtnStand
            // 
            this.BtnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStand.Location = new System.Drawing.Point(32, 322);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(76, 40);
            this.BtnStand.TabIndex = 25;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = true;
            this.BtnStand.UseWaitCursor = true;
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click_1);
            // 
            // LsvPlayerHand
            // 
            this.LsvPlayerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnheader,
            this.columnHeader5});
            this.LsvPlayerHand.GridLines = true;
            this.LsvPlayerHand.HideSelection = false;
            this.LsvPlayerHand.Location = new System.Drawing.Point(181, 251);
            this.LsvPlayerHand.Name = "LsvPlayerHand";
            this.LsvPlayerHand.Size = new System.Drawing.Size(258, 150);
            this.LsvPlayerHand.TabIndex = 26;
            this.LsvPlayerHand.UseCompatibleStateImageBehavior = false;
            this.LsvPlayerHand.UseWaitCursor = true;
            this.LsvPlayerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnheader
            // 
            this.columnheader.Text = "Face";
            this.columnheader.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Suit";
            this.columnHeader5.Width = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Player\'s Hand";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Computer Hand";
            this.label6.UseWaitCursor = true;
            // 
            // LsvComputerHand
            // 
            this.LsvComputerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.LsvComputerHand.GridLines = true;
            this.LsvComputerHand.HideSelection = false;
            this.LsvComputerHand.Location = new System.Drawing.Point(588, 251);
            this.LsvComputerHand.Name = "LsvComputerHand";
            this.LsvComputerHand.Size = new System.Drawing.Size(271, 150);
            this.LsvComputerHand.TabIndex = 30;
            this.LsvComputerHand.UseCompatibleStateImageBehavior = false;
            this.LsvComputerHand.UseWaitCursor = true;
            this.LsvComputerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Face";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Suit";
            this.columnHeader7.Width = 205;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Blackjack";
            this.label7.UseWaitCursor = true;
            // 
            // LsvResults
            // 
            this.LsvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.LsvResults.GridLines = true;
            this.LsvResults.HideSelection = false;
            this.LsvResults.Location = new System.Drawing.Point(12, 426);
            this.LsvResults.Name = "LsvResults";
            this.LsvResults.Size = new System.Drawing.Size(697, 200);
            this.LsvResults.TabIndex = 32;
            this.LsvResults.UseCompatibleStateImageBehavior = false;
            this.LsvResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "a";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "b";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "c";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "d";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 628);
            this.Controls.Add(this.LsvResults);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LsvComputerHand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LsvPlayerHand);
            this.Controls.Add(this.BtnStand);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LsvGameStatistics);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.BtnFindOverallWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListView LsvGameStatistics;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblComputerScore;
        private System.Windows.Forms.Button BtnFindOverallWinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxGame;
        private System.Windows.Forms.TextBox TbxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Button BtnStand;
        private System.Windows.Forms.ListView LsvPlayerHand;
        private System.Windows.Forms.ColumnHeader columnheader;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LsvComputerHand;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView LsvResults;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}