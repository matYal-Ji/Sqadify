using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Squadify.Forms
{
    partial class SquadForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            teamsTabControl = new TabControl();
            buttonSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(teamsTabControl, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSave, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1018, 586);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // teamsTabControl
            // 
            teamsTabControl.Dock = DockStyle.Fill;
            teamsTabControl.Location = new Point(3, 90);
            teamsTabControl.Name = "teamsTabControl";
            teamsTabControl.SelectedIndex = 0;
            teamsTabControl.Size = new Size(1012, 493);
            teamsTabControl.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(11, 12);
            buttonSave.Margin = new Padding(11, 12, 3, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(199, 63);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save Teams";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // SquadForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1018, 586);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SquadForm";
            Text = "SquadForm2";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl teamsTabControl;
        private Button buttonSave;
    }
}