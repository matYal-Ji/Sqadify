using Squadify.CustomControls;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxDataFile = new ButtonTextBox();
            labelLoadData = new Label();
            labelTeams = new Label();
            textBoxTeams = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAutoFill2 = new Button();
            buttonAutoFill3 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonAutoFill4 = new Button();
            buttonAutoFill6 = new Button();
            labelGames = new Label();
            textBoxGameInput = new TextBox();
            listBoxGames = new ListBox();
            buttonGenerate = new Button();
            buttonAddGames = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(textBoxDataFile, 2, 0);
            tableLayoutPanel1.Controls.Add(labelLoadData, 0, 0);
            tableLayoutPanel1.Controls.Add(labelTeams, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxTeams, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 3);
            tableLayoutPanel1.Controls.Add(labelGames, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxGameInput, 0, 5);
            tableLayoutPanel1.Controls.Add(listBoxGames, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonGenerate, 0, 10);
            tableLayoutPanel1.Controls.Add(buttonAddGames, 3, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(596, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxDataFile
            // 
            textBoxDataFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxDataFile, 2);
            textBoxDataFile.Font = new Font("Segoe UI", 9F);
            textBoxDataFile.Location = new Point(291, 8);
            textBoxDataFile.Margin = new Padding(3, 8, 3, 3);
            textBoxDataFile.Name = "textBoxDataFile";
            textBoxDataFile.ReadOnly = true;
            textBoxDataFile.Size = new Size(282, 27);
            textBoxDataFile.TabIndex = 10;
            // 
            // labelLoadData
            // 
            labelLoadData.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelLoadData, 2);
            labelLoadData.Dock = DockStyle.Fill;
            labelLoadData.Location = new Point(14, 0);
            labelLoadData.Margin = new Padding(14, 0, 3, 0);
            labelLoadData.Name = "labelLoadData";
            labelLoadData.Size = new Size(271, 40);
            labelLoadData.TabIndex = 9;
            labelLoadData.Text = "Load Player Data:";
            labelLoadData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTeams
            // 
            labelTeams.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelTeams, 2);
            labelTeams.Dock = DockStyle.Fill;
            labelTeams.Location = new Point(14, 52);
            labelTeams.Margin = new Padding(14, 0, 3, 0);
            labelTeams.Name = "labelTeams";
            labelTeams.Size = new Size(271, 53);
            labelTeams.TabIndex = 0;
            labelTeams.Text = "Number of Teams";
            labelTeams.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTeams
            // 
            textBoxTeams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxTeams, 2);
            textBoxTeams.Location = new Point(291, 67);
            textBoxTeams.Margin = new Padding(3, 15, 3, 3);
            textBoxTeams.Name = "textBoxTeams";
            textBoxTeams.Size = new Size(282, 30);
            textBoxTeams.TabIndex = 1;
            textBoxTeams.KeyPress += textBoxTeams_KeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonAutoFill2, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonAutoFill3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(291, 108);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(138, 47);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonAutoFill2
            // 
            buttonAutoFill2.Dock = DockStyle.Fill;
            buttonAutoFill2.FlatStyle = FlatStyle.Flat;
            buttonAutoFill2.Location = new Point(3, 3);
            buttonAutoFill2.Name = "buttonAutoFill2";
            buttonAutoFill2.Size = new Size(63, 41);
            buttonAutoFill2.TabIndex = 0;
            buttonAutoFill2.Tag = "2";
            buttonAutoFill2.Text = "2";
            buttonAutoFill2.UseVisualStyleBackColor = true;
            buttonAutoFill2.Click += buttonAutoFill_Click;
            // 
            // buttonAutoFill3
            // 
            buttonAutoFill3.Dock = DockStyle.Fill;
            buttonAutoFill3.FlatStyle = FlatStyle.Flat;
            buttonAutoFill3.Location = new Point(72, 3);
            buttonAutoFill3.Name = "buttonAutoFill3";
            buttonAutoFill3.Size = new Size(63, 41);
            buttonAutoFill3.TabIndex = 1;
            buttonAutoFill3.Tag = "3";
            buttonAutoFill3.Text = "3";
            buttonAutoFill3.UseVisualStyleBackColor = true;
            buttonAutoFill3.Click += buttonAutoFill_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonAutoFill4, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonAutoFill6, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(435, 108);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(138, 47);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonAutoFill4
            // 
            buttonAutoFill4.Dock = DockStyle.Fill;
            buttonAutoFill4.FlatStyle = FlatStyle.Flat;
            buttonAutoFill4.Location = new Point(3, 3);
            buttonAutoFill4.Name = "buttonAutoFill4";
            buttonAutoFill4.Size = new Size(63, 41);
            buttonAutoFill4.TabIndex = 0;
            buttonAutoFill4.Tag = "4";
            buttonAutoFill4.Text = "4";
            buttonAutoFill4.UseVisualStyleBackColor = true;
            buttonAutoFill4.Click += buttonAutoFill_Click;
            // 
            // buttonAutoFill6
            // 
            buttonAutoFill6.Dock = DockStyle.Fill;
            buttonAutoFill6.FlatStyle = FlatStyle.Flat;
            buttonAutoFill6.Location = new Point(72, 3);
            buttonAutoFill6.Name = "buttonAutoFill6";
            buttonAutoFill6.Size = new Size(63, 41);
            buttonAutoFill6.TabIndex = 1;
            buttonAutoFill6.Tag = "6";
            buttonAutoFill6.Text = "6";
            buttonAutoFill6.UseVisualStyleBackColor = true;
            buttonAutoFill6.Click += buttonAutoFill_Click;
            // 
            // labelGames
            // 
            labelGames.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelGames, 2);
            labelGames.Dock = DockStyle.Fill;
            labelGames.Location = new Point(14, 158);
            labelGames.Margin = new Padding(14, 0, 3, 0);
            labelGames.Name = "labelGames";
            labelGames.Size = new Size(271, 53);
            labelGames.TabIndex = 4;
            labelGames.Text = "Games to be played";
            labelGames.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxGameInput
            // 
            tableLayoutPanel1.SetColumnSpan(textBoxGameInput, 3);
            textBoxGameInput.Font = new Font("Segoe UI", 11F);
            textBoxGameInput.Location = new Point(17, 214);
            textBoxGameInput.Margin = new Padding(17, 3, 3, 3);
            textBoxGameInput.Multiline = true;
            textBoxGameInput.Name = "textBoxGameInput";
            textBoxGameInput.PlaceholderText = "Badminton, Table Tennis";
            textBoxGameInput.Size = new Size(412, 37);
            textBoxGameInput.TabIndex = 5;
            // 
            // listBoxGames
            // 
            tableLayoutPanel1.SetColumnSpan(listBoxGames, 4);
            listBoxGames.Dock = DockStyle.Fill;
            listBoxGames.Font = new Font("Segoe UI", 11F);
            listBoxGames.FormattingEnabled = true;
            listBoxGames.ItemHeight = 25;
            listBoxGames.Location = new Point(17, 267);
            listBoxGames.Margin = new Padding(17, 3, 3, 3);
            listBoxGames.Name = "listBoxGames";
            tableLayoutPanel1.SetRowSpan(listBoxGames, 4);
            listBoxGames.SelectionMode = SelectionMode.None;
            listBoxGames.Size = new Size(556, 206);
            listBoxGames.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            tableLayoutPanel1.SetColumnSpan(buttonGenerate, 4);
            buttonGenerate.Dock = DockStyle.Fill;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Font = new Font("Segoe UI", 11F);
            buttonGenerate.Location = new Point(17, 476);
            buttonGenerate.Margin = new Padding(17, 0, 3, 17);
            buttonGenerate.Name = "buttonGenerate";
            tableLayoutPanel1.SetRowSpan(buttonGenerate, 2);
            buttonGenerate.Size = new Size(556, 97);
            buttonGenerate.TabIndex = 8;
            buttonGenerate.Text = "Generate Teams";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonAddGames
            // 
            buttonAddGames.FlatStyle = FlatStyle.Flat;
            buttonAddGames.Location = new Point(435, 214);
            buttonAddGames.Name = "buttonAddGames";
            buttonAddGames.Size = new Size(138, 37);
            buttonAddGames.TabIndex = 6;
            buttonAddGames.Text = "Add";
            buttonAddGames.UseVisualStyleBackColor = true;
            buttonAddGames.Click += buttonAddGame_Click;
            // 
            // TeamSetupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TeamSetupForm";
            Text = "TeamSetupForm2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTeams;
        private TextBox textBoxTeams;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAutoFill2;
        private Button buttonAutoFill3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonAutoFill4;
        private Button buttonAutoFill6;
        private Label labelGames;
        private TextBox textBoxGameInput;
        private Button buttonAddGames;
        private ListBox listBoxGames;
        private Button buttonGenerate;
        private Label labelLoadData;
        private ButtonTextBox textBoxDataFile;
    }
}
