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
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
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
            splitContainerMain.Size = new Size(1022, 537);
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
            dataGridViewEmployees.Size = new Size(310, 537);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(splitContainer1);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 0);
            panelDetail.Margin = new Padding(4);
            panelDetail.Name = "panelDetail";
            panelDetail.Padding = new Padding(12);
            panelDetail.Size = new Size(707, 537);
            panelDetail.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(683, 513);
            splitContainer1.SplitterDistance = 229;
            splitContainer1.TabIndex = 0;
            // 
            // TeamControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(splitContainerMain);
            Margin = new Padding(4);
            Name = "TeamControl";
            Size = new Size(1022, 537);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
    }
}
