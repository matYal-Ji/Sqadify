using System.ComponentModel;
using Newtonsoft.Json;
using Squadify.Data;
using SquadsMaster.Models;

namespace Squadify.Forms
{
    public partial class TeamSetupForm : Form
    {
        string _playerDataFilePath = string.Empty;

        public TeamSetupForm()
        {
            InitializeComponent();

            textBoxDataFile.ButtonClick += TextBoxDataFile_ButtonClick;
        }

        #region event handlers

        private void TextBoxDataFile_ButtonClick(object? sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "JSON file (.json)|", DefaultExt = "json", AddExtension = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).Equals(".json"))
                {
                    _playerDataFilePath = ofd.FileName;
                    textBoxDataFile.Text = Path.GetFileName(ofd.FileName);
                }
                else
                {
                    MessageBox.Show(GlobalResources.FormatNotSupportedError);
                }
            }
        }

        private void buttonAutoFill_Click(object sender, EventArgs e)
        {
            if (sender is Button btnClicked)
            {
                textBoxTeams.Text = btnClicked.Tag?.ToString();
            }
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGameInput.Text)) return;

            var games = textBoxGameInput.Text.Split(',')
                            .Select(game => game.Trim())
                            .Where(game => !string.IsNullOrEmpty(game))
                            .ToList();

            if (listBoxGames.DataSource is null)
            {
                listBoxGames.DataSource = new BindingList<string>(games);
            }
            else
            {
                var source = listBoxGames.DataSource as BindingList<string>;
                games.ForEach(game => source?.Add(game));
            }

            textBoxGameInput.Clear();
        }

        private void textBoxTeams_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTeams.Text)) return;
            if (!int.TryParse(textBoxTeams.Text, out var teamCount)) return;

            #region sample data
            var players = PlayerDataUtil.GetPlayerData(_playerDataFilePath);
            var lobby = new Lobby(players);
            var teams = lobby.Distribute(teamCount);
            #endregion

            using var frm = new SquadForm(teams) { StartPosition = FormStartPosition.CenterParent };
            frm.ShowDialog(this);
        }

        #endregion
    }
}
