namespace Squadify.Forms
{
    partial class TeamSetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.TextBox textBoxTeams;
        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.TextBox textBoxGameInput;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonGenerate;

        private void InitializeComponent()
        {
            labelTeams = new Label();
            textBoxTeams = new TextBox();
            labelGames = new Label();
            textBoxGameInput = new TextBox();
            buttonAddGame = new Button();
            buttonGenerate = new Button();
            buttonAutoFill2 = new Button();
            buttonAutoFill3 = new Button();
            buttonAutoFill4 = new Button();
            buttonAutoFill6 = new Button();
            listBoxGames = new ListBox();
            SuspendLayout();
            // 
            // labelTeams
            // 
            labelTeams.AutoSize = true;
            labelTeams.Location = new Point(12, 9);
            labelTeams.Name = "labelTeams";
            labelTeams.Size = new Size(130, 20);
            labelTeams.TabIndex = 0;
            labelTeams.Text = "Number of Teams:";
            // 
            // textBoxTeams
            // 
            textBoxTeams.Location = new Point(155, 9);
            textBoxTeams.Name = "textBoxTeams";
            textBoxTeams.Size = new Size(158, 27);
            textBoxTeams.TabIndex = 1;
            textBoxTeams.KeyPress += textBoxTeams_KeyPress;
            // 
            // labelGames
            // 
            labelGames.AutoSize = true;
            labelGames.Location = new Point(8, 96);
            labelGames.Name = "labelGames";
            labelGames.Size = new Size(144, 20);
            labelGames.TabIndex = 2;
            labelGames.Text = "Games to be Played:";
            // 
            // textBoxGameInput
            // 
            textBoxGameInput.Location = new Point(12, 266);
            textBoxGameInput.Name = "textBoxGameInput";
            textBoxGameInput.PlaceholderText = "Cricket, Table Tennis";
            textBoxGameInput.Size = new Size(186, 27);
            textBoxGameInput.TabIndex = 4;
            // 
            // buttonAddGame
            // 
            buttonAddGame.FlatStyle = FlatStyle.Flat;
            buttonAddGame.Location = new Point(204, 266);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Size = new Size(108, 27);
            buttonAddGame.TabIndex = 5;
            buttonAddGame.Text = "Add Games";
            buttonAddGame.Click += buttonAddGame_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Font = new Font("Segoe UI", 12F);
            buttonGenerate.Location = new Point(12, 316);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(300, 51);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Generate Teams";
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonAutoFill2
            // 
            buttonAutoFill2.FlatStyle = FlatStyle.Flat;
            buttonAutoFill2.Location = new Point(155, 45);
            buttonAutoFill2.Name = "buttonAutoFill2";
            buttonAutoFill2.Size = new Size(32, 31);
            buttonAutoFill2.TabIndex = 7;
            buttonAutoFill2.Tag = "2";
            buttonAutoFill2.Text = "2";
            buttonAutoFill2.UseVisualStyleBackColor = true;
            buttonAutoFill2.Click += buttonAutoFill_Click;
            // 
            // buttonAutoFill3
            // 
            buttonAutoFill3.FlatStyle = FlatStyle.Flat;
            buttonAutoFill3.Location = new Point(197, 45);
            buttonAutoFill3.Name = "buttonAutoFill3";
            buttonAutoFill3.Size = new Size(32, 31);
            buttonAutoFill3.TabIndex = 8;
            buttonAutoFill3.Tag = "3";
            buttonAutoFill3.Text = "3";
            buttonAutoFill3.UseVisualStyleBackColor = true;
            buttonAutoFill3.Click += buttonAutoFill_Click;
            // 
            // buttonAutoFill4
            // 
            buttonAutoFill4.FlatStyle = FlatStyle.Flat;
            buttonAutoFill4.Location = new Point(239, 45);
            buttonAutoFill4.Name = "buttonAutoFill4";
            buttonAutoFill4.Size = new Size(32, 31);
            buttonAutoFill4.TabIndex = 9;
            buttonAutoFill4.Tag = "4";
            buttonAutoFill4.Text = "4";
            buttonAutoFill4.UseVisualStyleBackColor = true;
            buttonAutoFill4.Click += buttonAutoFill_Click;
            // 
            // buttonAutoFill6
            // 
            buttonAutoFill6.FlatStyle = FlatStyle.Flat;
            buttonAutoFill6.Location = new Point(280, 45);
            buttonAutoFill6.Name = "buttonAutoFill6";
            buttonAutoFill6.Size = new Size(32, 31);
            buttonAutoFill6.TabIndex = 10;
            buttonAutoFill6.Tag = "6";
            buttonAutoFill6.Text = "6";
            buttonAutoFill6.UseVisualStyleBackColor = true;
            buttonAutoFill6.Click += buttonAutoFill_Click;
            // 
            // listBoxGames
            // 
            listBoxGames.FormattingEnabled = true;
            listBoxGames.Location = new Point(12, 128);
            listBoxGames.Name = "listBoxGames";
            listBoxGames.SelectionMode = SelectionMode.None;
            listBoxGames.Size = new Size(300, 124);
            listBoxGames.TabIndex = 11;
            // 
            // FormGenerateTeams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 385);
            Controls.Add(listBoxGames);
            Controls.Add(buttonAutoFill6);
            Controls.Add(buttonAutoFill4);
            Controls.Add(buttonAutoFill3);
            Controls.Add(buttonAutoFill2);
            Controls.Add(labelTeams);
            Controls.Add(textBoxTeams);
            Controls.Add(labelGames);
            Controls.Add(textBoxGameInput);
            Controls.Add(buttonAddGame);
            Controls.Add(buttonGenerate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGenerateTeams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate Teams";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonAutoFill2;
        private Button buttonAutoFill3;
        private Button buttonAutoFill4;
        private Button buttonAutoFill6;
        private ListBox listBoxGames;
    }
    #endregion
}
