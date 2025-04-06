namespace Squadify.CustomControls
{
    partial class ScheduleCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            _team1FlowLayoutPanel = new FlowLayoutPanel();
            _team2FlowLayoutPanel = new FlowLayoutPanel();
            _miscFlowLayoutPanel = new FlowLayoutPanel();
            _scoreEdit = new Button();
            _noteEdit = new Button();
            _dateEdit = new Button();
            tableLayoutPanel1.SuspendLayout();
            _miscFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(_team1FlowLayoutPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(_team2FlowLayoutPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(_miscFlowLayoutPanel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(916, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _team1FlowLayoutPanel
            // 
            _team1FlowLayoutPanel.Dock = DockStyle.Fill;
            _team1FlowLayoutPanel.Location = new Point(3, 3);
            _team1FlowLayoutPanel.Name = "_team1FlowLayoutPanel";
            _team1FlowLayoutPanel.Size = new Size(910, 24);
            _team1FlowLayoutPanel.TabIndex = 0;
            // 
            // _team2FlowLayoutPanel
            // 
            _team2FlowLayoutPanel.Dock = DockStyle.Fill;
            _team2FlowLayoutPanel.Location = new Point(3, 33);
            _team2FlowLayoutPanel.Name = "_team2FlowLayoutPanel";
            _team2FlowLayoutPanel.Size = new Size(910, 24);
            _team2FlowLayoutPanel.TabIndex = 1;
            // 
            // _miscFlowLayoutPanel
            // 
            _miscFlowLayoutPanel.Controls.Add(_dateEdit);
            _miscFlowLayoutPanel.Controls.Add(_scoreEdit);
            _miscFlowLayoutPanel.Controls.Add(_noteEdit);
            _miscFlowLayoutPanel.Dock = DockStyle.Fill;
            _miscFlowLayoutPanel.Location = new Point(3, 63);
            _miscFlowLayoutPanel.Name = "_miscFlowLayoutPanel";
            _miscFlowLayoutPanel.Size = new Size(910, 24);
            _miscFlowLayoutPanel.TabIndex = 2;
            // 
            // _scoreEdit
            // 
            _scoreEdit.Location = new Point(85, 0);
            _scoreEdit.Margin = new Padding(5, 0, 0, 0);
            _scoreEdit.Name = "_scoreEdit";
            _scoreEdit.Size = new Size(75, 23);
            _scoreEdit.TabIndex = 0;
            _scoreEdit.Text = "Score";
            _scoreEdit.UseVisualStyleBackColor = true;
            // 
            // _noteEdit
            // 
            _noteEdit.Location = new Point(165, 0);
            _noteEdit.Margin = new Padding(5, 0, 0, 0);
            _noteEdit.Name = "_noteEdit";
            _noteEdit.Size = new Size(75, 23);
            _noteEdit.TabIndex = 1;
            _noteEdit.Text = "Note";
            _noteEdit.UseVisualStyleBackColor = true;
            // 
            // _dateEdit
            // 
            _dateEdit.Location = new Point(5, 0);
            _dateEdit.Margin = new Padding(5, 0, 0, 0);
            _dateEdit.Name = "_dateEdit";
            _dateEdit.Size = new Size(75, 23);
            _dateEdit.TabIndex = 2;
            _dateEdit.Text = "Date";
            _dateEdit.UseVisualStyleBackColor = true;
            // 
            // ScheduleCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            Name = "ScheduleCard";
            Size = new Size(916, 90);
            tableLayoutPanel1.ResumeLayout(false);
            _miscFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel _team1FlowLayoutPanel;
        private FlowLayoutPanel _team2FlowLayoutPanel;
        private FlowLayoutPanel _miscFlowLayoutPanel;
        private Button _scoreEdit;
        private Button _noteEdit;
        private Button _dateEdit;
    }
}
