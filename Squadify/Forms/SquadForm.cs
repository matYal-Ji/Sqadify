using System.Data;
using SquadsMaster.Models;
using Squadify.Utils;
using Squadify.CustomControls;

namespace Squadify.Forms
{
    public partial class SquadForm : Form
    {
        List<Team> _teams;

        public SquadForm()
        {
            InitializeComponent();
        }

        public SquadForm(List<Team> teams)
        {
            InitializeComponent();
            _teams = teams;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DisplayTeams();
        }

        private void DisplayTeams()
        {
            if (_teams is null || _teams.Count <= 0) return;

            foreach (Team team in _teams)
            {
                var tabPage = new TabPage { Text = team.Name };
                tabPage.Controls.Add(new TeamControl(team) { Dock = DockStyle.Fill });
                teamsTabControl.TabPages.Add(tabPage);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog() { Filter = "Comma separated values (.csv)|", DefaultExt = "csv", AddExtension = true };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var csvContent = CsvGenerator.SaveTeamsToCsv(_teams);
                File.WriteAllText(saveFileDialog.FileName, csvContent);
            }
        }
    }
}