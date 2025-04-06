using Squadify.CustomControls;
using SquadsMaster.Models;
using System.Data;

namespace Squadify.Forms
{
    public partial class EventScheduleForm : Form
    {
        public EventScheduleForm()
        {
            InitializeComponent();
        }

        public EventScheduleForm(List<Team> teams, List<Game> games)
        {
            InitializeComponent();

            //standings
            var data = new DataTable();
            data.Columns.Add("Name");
            foreach (var skill in teams[0].LobbySkills.Skills)
                data.Columns.Add(skill);
            foreach(var team in teams)
            {
                var row = data.NewRow();
                row["Name"] = team.Name;
                foreach(var score in team.Score)
                    row[score.Key] = score.Value;
                data.Rows.Add(row);
            }
            _standingsGrid.DataSource = data;
            var gridHeight = _standingsGrid.ColumnHeadersHeight + 25;
            foreach (DataGridViewRow row in _standingsGrid.Rows)
            {
                //row.HeaderCell.ValueType = typeof(string);
                //row.HeaderCell.Value = row.Cells["Name"].Value.ToString();
                gridHeight += row.Height;
            }
            //_standingsGrid.Columns["Name"].Visible = false;
            _standingsGrid.Columns["Name"].HeaderText = "";
            _standingsGroupBox.Height = gridHeight;

            //schedule
            var scheduleControl = new ScheduleControl(games) { Dock = DockStyle.Fill };
            _scheduleGroupBox.Height = scheduleControl.Height + 25;
            _scheduleGroupBox.Controls.Add(scheduleControl);
        }
    }
}
