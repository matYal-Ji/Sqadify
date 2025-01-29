using System.Data;
using SquadsMaster.Models;
using Squadify.Utils;

namespace Squadify.Forms
{
    public partial class SquadForm : Form
    {
        List<Team> _teams;

        public SquadForm(List<Team> teams)
        {
            InitializeComponent();
            _teams = teams;
            DisplayTeams(_teams);
        }

        public void DisplayTeams(List<Team> teams)
        {
            foreach (var team in teams)
            {
                // Create a new panel for each team
                Panel teamPanel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    BorderStyle = BorderStyle.None
                };

                // Add a label for the team name
                Label teamLabel = new Label
                {
                    Text = team.Name,
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Add a ListBox for team members
                ListBox memberListBox = new ListBox
                {
                    Dock = DockStyle.Fill,
                    SelectionMode = SelectionMode.None
                };
                var players = team.Players.Select(player => player.Name).ToArray();
                memberListBox.Items.AddRange(players);

                // Add controls to the panel
                teamPanel.Controls.Add(memberListBox);
                teamPanel.Controls.Add(teamLabel);

                flowLayoutPanel1.Controls.Add(teamPanel);
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
