namespace Squadify.CustomControls
{
    partial class TeamControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.Label lblAgeLabel;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSkillsLabel;
        private System.Windows.Forms.Label lblSkills;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Method required for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainerMain = new SplitContainer();
            dataGridViewEmployees = new DataGridView();
            panelDetail = new Panel();
            lblEmployeeName = new Label();
            pictureBoxEmployee = new PictureBox();
            tableLayoutPanelDetails = new TableLayoutPanel();
            lblAgeLabel = new Label();
            lblAge = new Label();
            lblGenderLabel = new Label();
            lblGender = new Label();
            lblSkillsLabel = new Label();
            lblSkills = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            tableLayoutPanelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.FixedPanel = FixedPanel.Panel1;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Margin = new Padding(4);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridViewEmployees);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelDetail);
            splitContainerMain.Size = new Size(986, 500);
            splitContainerMain.SplitterDistance = 310;
            splitContainerMain.SplitterWidth = 5;
            splitContainerMain.TabIndex = 0;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToResizeColumns = false;
            dataGridViewEmployees.AllowUserToResizeRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.BackgroundColor = SystemColors.Window;
            dataGridViewEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewEmployees.ColumnHeadersHeight = 29;
            dataGridViewEmployees.ColumnHeadersVisible = false;
            dataGridViewEmployees.Dock = DockStyle.Fill;
            dataGridViewEmployees.Location = new Point(0, 0);
            dataGridViewEmployees.Margin = new Padding(4);
            dataGridViewEmployees.MultiSelect = false;
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 35;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.ShowCellErrors = false;
            dataGridViewEmployees.ShowCellToolTips = false;
            dataGridViewEmployees.Size = new Size(310, 500);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(lblEmployeeName);
            panelDetail.Controls.Add(pictureBoxEmployee);
            panelDetail.Controls.Add(tableLayoutPanelDetails);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 0);
            panelDetail.Margin = new Padding(4);
            panelDetail.Name = "panelDetail";
            panelDetail.Padding = new Padding(12);
            panelDetail.Size = new Size(671, 500);
            panelDetail.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmployeeName.Location = new Point(12, 18);
            lblEmployeeName.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(199, 32);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee Name";
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxEmployee.Location = new Point(12, 68);
            pictureBoxEmployee.Margin = new Padding(4);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(143, 134);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmployee.TabIndex = 2;
            pictureBoxEmployee.TabStop = false;
            // 
            // tableLayoutPanelDetails
            // 
            tableLayoutPanelDetails.AutoSize = true;
            tableLayoutPanelDetails.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelDetails.ColumnCount = 2;
            tableLayoutPanelDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelDetails.Controls.Add(lblAgeLabel, 0, 0);
            tableLayoutPanelDetails.Controls.Add(lblAge, 1, 0);
            tableLayoutPanelDetails.Controls.Add(lblGenderLabel, 0, 1);
            tableLayoutPanelDetails.Controls.Add(lblGender, 1, 1);
            tableLayoutPanelDetails.Controls.Add(lblSkillsLabel, 0, 2);
            tableLayoutPanelDetails.Controls.Add(lblSkills, 1, 2);
            tableLayoutPanelDetails.Location = new Point(163, 68);
            tableLayoutPanelDetails.Margin = new Padding(4);
            tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            tableLayoutPanelDetails.RowCount = 3;
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDetails.Size = new Size(471, 134);
            tableLayoutPanelDetails.TabIndex = 3;
            // 
            // lblAgeLabel
            // 
            lblAgeLabel.Anchor = AnchorStyles.Left;
            lblAgeLabel.AutoSize = true;
            lblAgeLabel.Font = new Font("Segoe UI", 10F);
            lblAgeLabel.Location = new Point(5, 5);
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
            lblAge.Location = new Point(123, 5);
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
            lblGenderLabel.Location = new Point(5, 38);
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
            lblGender.Location = new Point(123, 38);
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
            lblSkillsLabel.Location = new Point(5, 77);
            lblSkillsLabel.Margin = new Padding(4, 10, 4, 0);
            lblSkillsLabel.Name = "lblSkillsLabel";
            lblSkillsLabel.Size = new Size(109, 56);
            lblSkillsLabel.TabIndex = 6;
            lblSkillsLabel.Text = "Skills:";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Dock = DockStyle.Fill;
            lblSkills.Font = new Font("Segoe UI", 10F);
            lblSkills.Location = new Point(123, 77);
            lblSkills.Margin = new Padding(4, 10, 4, 0);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(343, 56);
            lblSkills.TabIndex = 7;
            lblSkills.Text = "Skills";
            // 
            // TeamControl
            // 
            Controls.Add(splitContainerMain);
            Margin = new Padding(4);
            Name = "TeamControl";
            Size = new Size(986, 500);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            tableLayoutPanelDetails.ResumeLayout(false);
            tableLayoutPanelDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
