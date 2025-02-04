namespace Squadify.CustomControls
{
    partial class PlayerViewControl
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
            lblEmployeeName = new Label();
            tableLayoutPanelDetails = new TableLayoutPanel();
            lblAgeLabel = new Label();
            lblAge = new Label();
            lblGenderLabel = new Label();
            lblGender = new Label();
            lblSkillsLabel = new Label();
            lblSkills = new Label();
            pictureBoxEmployee = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblEmployeeName, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelDetails, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxEmployee, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(623, 251);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblEmployeeName, 2);
            lblEmployeeName.Dock = DockStyle.Fill;
            lblEmployeeName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmployeeName.Location = new Point(4, 6);
            lblEmployeeName.Margin = new Padding(4, 6, 4, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(302, 44);
            lblEmployeeName.TabIndex = 8;
            lblEmployeeName.Text = "Employee Name";
            // 
            // tableLayoutPanelDetails
            // 
            tableLayoutPanelDetails.AutoSize = true;
            tableLayoutPanelDetails.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelDetails.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanelDetails, 3);
            tableLayoutPanelDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelDetails.Controls.Add(lblAgeLabel, 0, 0);
            tableLayoutPanelDetails.Controls.Add(lblAge, 1, 0);
            tableLayoutPanelDetails.Controls.Add(lblGenderLabel, 0, 1);
            tableLayoutPanelDetails.Controls.Add(lblGender, 1, 1);
            tableLayoutPanelDetails.Controls.Add(lblSkillsLabel, 0, 2);
            tableLayoutPanelDetails.Controls.Add(lblSkills, 1, 2);
            tableLayoutPanelDetails.Dock = DockStyle.Fill;
            tableLayoutPanelDetails.Location = new Point(159, 54);
            tableLayoutPanelDetails.Margin = new Padding(4);
            tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            tableLayoutPanelDetails.RowCount = 3;
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDetails.Size = new Size(460, 193);
            tableLayoutPanelDetails.TabIndex = 7;
            // 
            // lblAgeLabel
            // 
            lblAgeLabel.Anchor = AnchorStyles.Left;
            lblAgeLabel.AutoSize = true;
            lblAgeLabel.Font = new Font("Segoe UI", 10F);
            lblAgeLabel.Location = new Point(5, 13);
            lblAgeLabel.Margin = new Padding(4, 0, 4, 0);
            lblAgeLabel.Name = "lblAgeLabel";
            lblAgeLabel.Size = new Size(44, 23);
            lblAgeLabel.TabIndex = 0;
            lblAgeLabel.Text = "Age:";
            // 
            // lblAge
            // 
            lblAge.Anchor = AnchorStyles.Left;
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10F);
            lblAge.Location = new Point(120, 13);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 23);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            // 
            // lblGenderLabel
            // 
            lblGenderLabel.Anchor = AnchorStyles.Left;
            lblGenderLabel.AutoSize = true;
            lblGenderLabel.Font = new Font("Segoe UI", 10F);
            lblGenderLabel.Location = new Point(5, 61);
            lblGenderLabel.Margin = new Padding(4, 0, 4, 0);
            lblGenderLabel.Name = "lblGenderLabel";
            lblGenderLabel.Size = new Size(70, 23);
            lblGenderLabel.TabIndex = 2;
            lblGenderLabel.Text = "Gender:";
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F);
            lblGender.Location = new Point(120, 61);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(66, 23);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblSkillsLabel
            // 
            lblSkillsLabel.AutoSize = true;
            lblSkillsLabel.Dock = DockStyle.Fill;
            lblSkillsLabel.Font = new Font("Segoe UI", 10F);
            lblSkillsLabel.Location = new Point(5, 107);
            lblSkillsLabel.Margin = new Padding(4, 10, 4, 0);
            lblSkillsLabel.Name = "lblSkillsLabel";
            lblSkillsLabel.Size = new Size(106, 85);
            lblSkillsLabel.TabIndex = 6;
            lblSkillsLabel.Text = "Skills:";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Dock = DockStyle.Fill;
            lblSkills.Font = new Font("Segoe UI", 10F);
            lblSkills.Location = new Point(120, 107);
            lblSkills.Margin = new Padding(4, 10, 4, 0);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(335, 85);
            lblSkills.TabIndex = 7;
            lblSkills.Text = "Skills";
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxEmployee.Dock = DockStyle.Fill;
            pictureBoxEmployee.Location = new Point(4, 54);
            pictureBoxEmployee.Margin = new Padding(4);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(147, 193);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmployee.TabIndex = 9;
            pictureBoxEmployee.TabStop = false;
            // 
            // EmployeeViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PlayerViewControl";
            Size = new Size(623, 251);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanelDetails.ResumeLayout(false);
            tableLayoutPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelDetails;
        private Label lblAgeLabel;
        private Label lblAge;
        private Label lblGenderLabel;
        private Label lblGender;
        private Label lblSkillsLabel;
        private Label lblSkills;
        private Label lblEmployeeName;
        private PictureBox pictureBoxEmployee;
    }
}
