using Squadify.Data;
using SquadsMaster.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace Squadify.CustomControls
{
    public partial class TeamControl : UserControl
    {
        Team _team;
        BindingSource _bindingSource;

        public TeamControl()
        {
            InitializeComponent();
            _team = new Team();
        }

        public TeamControl(Team team)
        {
            InitializeComponent();
            _team = team;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_team is null) return;

            _bindingSource = new BindingSource(_team.Players, string.Empty);

            SetupDataGrid();
            SetupEmployeeInfo();
            SetupChart();
        }

        private void SetupEmployeeInfo()
        {
            var playerViewControl = new PlayerViewControl(_bindingSource) { Dock = DockStyle.Fill };
            splitContainer1.Panel1.Controls.Add(playerViewControl);
        }

        private void SetupDataGrid()
        {
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Player", DataPropertyName = "Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridViewEmployees.DataSource = _bindingSource;
        }

        private void SetupChart()
        {
            var chartTeamSkills = new Chart
            {
                Dock = DockStyle.Fill,
                AntiAliasing = AntiAliasingStyles.All,
                TextAntiAliasingQuality = TextAntiAliasingQuality.High
            };

            // Create and configure a ChartArea
            ChartArea chartArea = new ChartArea("MainChartArea")
            {
                // You can further customize the ChartArea as needed
                AxisX = { MajorGrid = { Enabled = false } },
                AxisY = { MajorGrid = { Enabled = false } }
            };
            chartTeamSkills.ChartAreas.Add(chartArea);

            // Create a Series to hold the data points
            Series series = new Series("Team Skills")
            {
                ChartType = SeriesChartType.Bar,
                XValueType = ChartValueType.String
            };
            chartTeamSkills.Series.Add(series);

            // Optionally, add a title to the chart
            Title chartTitle = new Title("Team Skills Overview", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.Black);
            chartTeamSkills.Titles.Add(chartTitle);

            // Convert the dictionary keys and values to lists (or arrays)
            var skillNames = new List<string>(_team.SkillCount.Keys);
            var skillCounts = new List<int>(_team.SkillCount.Values);
            series.Points.Clear();
            series.Points.DataBindXY(skillNames, skillCounts);

            splitContainer1.Panel2.Controls.Add(chartTeamSkills);
        }
    }
}
