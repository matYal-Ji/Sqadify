namespace Squadify.Forms
{
    partial class EventScheduleForm
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
            tabControl1 = new TabControl();
            _allTabPage = new TabPage();
            _scheduleGroupBox = new GroupBox();
            _standingsGroupBox = new GroupBox();
            _standingsGrid = new DataGridView();
            _standingsTabPage = new TabPage();
            _scheduleTabPage = new TabPage();
            tabControl1.SuspendLayout();
            _allTabPage.SuspendLayout();
            _standingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_standingsGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(_allTabPage);
            tabControl1.Controls.Add(_standingsTabPage);
            tabControl1.Controls.Add(_scheduleTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 510);
            tabControl1.TabIndex = 0;
            // 
            // _allTabPage
            // 
            _allTabPage.AutoScroll = true;
            _allTabPage.Controls.Add(_scheduleGroupBox);
            _allTabPage.Controls.Add(_standingsGroupBox);
            _allTabPage.Location = new Point(4, 24);
            _allTabPage.Name = "_allTabPage";
            _allTabPage.Padding = new Padding(3);
            _allTabPage.Size = new Size(792, 482);
            _allTabPage.TabIndex = 0;
            _allTabPage.Text = "All";
            _allTabPage.UseVisualStyleBackColor = true;
            // 
            // _scheduleGroupBox
            // 
            _scheduleGroupBox.BackColor = Color.Transparent;
            _scheduleGroupBox.Dock = DockStyle.Top;
            _scheduleGroupBox.Location = new Point(3, 117);
            _scheduleGroupBox.Name = "_scheduleGroupBox";
            _scheduleGroupBox.Size = new Size(786, 150);
            _scheduleGroupBox.TabIndex = 1;
            _scheduleGroupBox.TabStop = false;
            _scheduleGroupBox.Text = "Schedule";
            // 
            // _standingsGroupBox
            // 
            _standingsGroupBox.Controls.Add(_standingsGrid);
            _standingsGroupBox.Dock = DockStyle.Top;
            _standingsGroupBox.Location = new Point(3, 3);
            _standingsGroupBox.Name = "_standingsGroupBox";
            _standingsGroupBox.Size = new Size(786, 114);
            _standingsGroupBox.TabIndex = 0;
            _standingsGroupBox.TabStop = false;
            _standingsGroupBox.Text = "Standings";
            // 
            // _standingsGrid
            // 
            _standingsGrid.AllowUserToAddRows = false;
            _standingsGrid.AllowUserToDeleteRows = false;
            _standingsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _standingsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _standingsGrid.Dock = DockStyle.Fill;
            _standingsGrid.Location = new Point(3, 19);
            _standingsGrid.Name = "_standingsGrid";
            _standingsGrid.Size = new Size(780, 92);
            _standingsGrid.TabIndex = 0;
            // 
            // _standingsTabPage
            // 
            _standingsTabPage.Location = new Point(4, 24);
            _standingsTabPage.Name = "_standingsTabPage";
            _standingsTabPage.Padding = new Padding(3);
            _standingsTabPage.Size = new Size(792, 422);
            _standingsTabPage.TabIndex = 1;
            _standingsTabPage.Text = "Standings";
            _standingsTabPage.UseVisualStyleBackColor = true;
            // 
            // _scheduleTabPage
            // 
            _scheduleTabPage.Location = new Point(4, 24);
            _scheduleTabPage.Name = "_scheduleTabPage";
            _scheduleTabPage.Padding = new Padding(3);
            _scheduleTabPage.Size = new Size(792, 422);
            _scheduleTabPage.TabIndex = 2;
            _scheduleTabPage.Text = "Schedule";
            _scheduleTabPage.UseVisualStyleBackColor = true;
            // 
            // EventScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EventScheduleForm";
            Text = "Event Schedule";
            tabControl1.ResumeLayout(false);
            _allTabPage.ResumeLayout(false);
            _standingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_standingsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage _allTabPage;
        private TabPage _standingsTabPage;
        private TabPage _scheduleTabPage;
        private GroupBox _scheduleGroupBox;
        private GroupBox _standingsGroupBox;
        private DataGridView _standingsGrid;
    }
}