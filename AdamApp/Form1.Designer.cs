namespace AdamApp
{
    partial class Form1
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
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPlayerName = new System.Windows.Forms.TextBox();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayGame.Location = new System.Drawing.Point(43, 124);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(121, 51);
            this.BtnPlayGame.TabIndex = 0;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick Game";
            // 
            // TbxPlayerName
            // 
            this.TbxPlayerName.Location = new System.Drawing.Point(172, 45);
            this.TbxPlayerName.Name = "TbxPlayerName";
            this.TbxPlayerName.Size = new System.Drawing.Size(196, 20);
            this.TbxPlayerName.TabIndex = 3;
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(172, 80);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(196, 21);
            this.CbxGame.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player Score";
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(134, 395);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(234, 51);
            this.BtnFindOverallWinner.TabIndex = 7;
            this.BtnFindOverallWinner.Text = "Find Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputerScore.Location = new System.Drawing.Point(374, 114);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(20, 24);
            this.LblComputerScore.TabIndex = 8;
            this.LblComputerScore.Text = "0";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerScore.Location = new System.Drawing.Point(347, 160);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(20, 24);
            this.LblPlayerScore.TabIndex = 9;
            this.LblPlayerScore.Text = "0";
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvGameStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.HideSelection = false;
            this.LsvGameStatistics.Location = new System.Drawing.Point(33, 200);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(657, 189);
            this.LsvGameStatistics.TabIndex = 10;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Player Score";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Computer Score";
            this.columnHeader3.Width = 209;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Winner";
            this.columnHeader4.Width = 104;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(28, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 29);
            this.Title.TabIndex = 11;
            this.Title.Text = "Game App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPlayerName;
        private System.Windows.Forms.ComboBox CbxGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFindOverallWinner;
        private System.Windows.Forms.Label LblComputerScore;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.ListView LsvGameStatistics;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label Title;
    }
}

