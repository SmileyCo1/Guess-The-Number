namespace GuessTheNumber
{
    partial class GuessMyNumber
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
            this.TxtGuesses = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.BtnGive = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtGuesses
            // 
            this.TxtGuesses.Location = new System.Drawing.Point(117, 34);
            this.TxtGuesses.Name = "TxtGuesses";
            this.TxtGuesses.ReadOnly = true;
            this.TxtGuesses.Size = new System.Drawing.Size(44, 22);
            this.TxtGuesses.TabIndex = 0;
            this.TxtGuesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(117, 6);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.ReadOnly = true;
            this.TxtScore.Size = new System.Drawing.Size(43, 22);
            this.TxtScore.TabIndex = 1;
            this.TxtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(209, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Guess The Number!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(9, 6);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Best Score";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(269, 53);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(147, 17);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Enter a number 1-100";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuesses.Location = new System.Drawing.Point(25, 34);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(76, 20);
            this.lblGuesses.TabIndex = 5;
            this.lblGuesses.Text = "Guesses";
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(291, 78);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(100, 22);
            this.TxtOutput.TabIndex = 1;
            // 
            // BtnGuess
            // 
            this.BtnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuess.Location = new System.Drawing.Point(173, 220);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(139, 45);
            this.BtnGuess.TabIndex = 7;
            this.BtnGuess.Text = "Guess";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // BtnGive
            // 
            this.BtnGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGive.Location = new System.Drawing.Point(338, 220);
            this.BtnGive.Name = "BtnGive";
            this.BtnGive.Size = new System.Drawing.Size(139, 46);
            this.BtnGive.TabIndex = 8;
            this.BtnGive.Text = "Give Up!";
            this.BtnGive.UseVisualStyleBackColor = true;
            this.BtnGive.Click += new System.EventHandler(this.BtnGive_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(12, 221);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(139, 45);
            this.BtnPlay.TabIndex = 9;
            this.BtnPlay.Text = "Play Again!";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 132);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 10;
            // 
            // GuessMyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnGive);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtGuesses);
            this.Name = "GuessMyNumber";
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.GuessMyNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGuesses;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Button BtnGive;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label lblOutput;
    }
}

