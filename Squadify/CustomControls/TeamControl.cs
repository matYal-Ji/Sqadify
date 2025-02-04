using Squadify.Data;
using SquadsMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squadify.CustomControls
{
    public partial class TeamControl : UserControl
    {
        Team _team;

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

            dataGridViewEmployees.SelectionChanged += DataGridViewEmployees_SelectionChanged;
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Player", DataPropertyName = "Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridViewEmployees.DataSource = _team.Players;
        }

        private void DataGridViewEmployees_SelectionChanged(object? sender, EventArgs e)
        {
            var source = dataGridViewEmployees.DataSource as List<IPlayer>;
            var player = source[dataGridViewEmployees.CurrentRow.Index];

            lblEmployeeName.Text = player.Name;
            lblAge.Text = player.Age.ToString();
            lblGender.Text = player.Gender.ToString();
            lblSkills.Text = string.Join(", ", player?.Skills);
        }
    }
}
