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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSave = new Button();
            groupBox1 = new GroupBox();
            buttonSchedule = new Button();
            elimination = new RadioButton();
            roundRobin = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(teamsTabControl, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1069, 594);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // teamsTabControl
            // 
            teamsTabControl.Dock = DockStyle.Fill;
            teamsTabControl.Location = new Point(3, 73);
            teamsTabControl.Name = "teamsTabControl";
            teamsTabControl.SelectedIndex = 0;
            teamsTabControl.Size = new Size(1063, 518);
            teamsTabControl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1063, 64);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(12, 8);
            buttonSave.Margin = new Padding(12, 8, 0, 8);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(170, 43);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save Teams";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSchedule);
            groupBox1.Controls.Add(elimination);
            groupBox1.Controls.Add(roundRobin);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(194, 0);
            groupBox1.Margin = new Padding(12, 0, 0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 64);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generate Schedule";
            // 
            // buttonSchedule
            // 
            buttonSchedule.BackgroundImage = GlobalResources.right_arrow;
            buttonSchedule.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSchedule.FlatAppearance.BorderSize = 0;
            buttonSchedule.FlatStyle = FlatStyle.Flat;
            buttonSchedule.Location = new Point(118, 20);
            buttonSchedule.Margin = new Padding(12, 8, 0, 8);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(42, 31);
            buttonSchedule.TabIndex = 4;
            buttonSchedule.UseVisualStyleBackColor = true;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // elimination
            // 
            elimination.AutoSize = true;
            elimination.Font = new System.Drawing.Font("Segoe UI", 8F);
            elimination.Location = new Point(3, 38);
            elimination.Margin = new Padding(0);
            elimination.Name = "elimination";
            elimination.Size = new Size(83, 17);
            elimination.TabIndex = 1;
            elimination.Text = "Elimination";
            elimination.UseVisualStyleBackColor = true;
            // 
            // roundRobin
            // 
            roundRobin.AutoSize = true;
            roundRobin.Checked = true;
            roundRobin.Font = new System.Drawing.Font("Segoe UI", 8F);
            roundRobin.Location = new Point(3, 20);
            roundRobin.Margin = new Padding(0);
            roundRobin.Name = "roundRobin";
            roundRobin.Size = new Size(94, 17);
            roundRobin.TabIndex = 0;
            roundRobin.TabStop = true;
            roundRobin.Text = "Round Robin";
            roundRobin.UseVisualStyleBackColor = true;
            // 
            // SquadForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1069, 594);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SquadForm";
            Text = "SquadForm2";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl teamsTabControl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSave;
        private RadioButton elimination;
        private RadioButton roundRobin;
        private GroupBox groupBox1;
        private Button buttonSchedule;
    }
}