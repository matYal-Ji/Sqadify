using SquadsMaster.Models;

namespace Squadify.CustomControls
{
    public partial class ScheduleControl : UserControl
    {
        public ScheduleControl()
        {
            InitializeComponent();
        }
        public ScheduleControl(List<Game> games):this()
        {
            if (games == null) return;
            var parentHeight = 0;
            foreach (var game in games)
            {
                var card = new ScheduleCard(game.Teams[0], game.Teams[1])
                {
                    Dock = DockStyle.Top
                };
                this.Controls.Add(card);
                parentHeight += card.Height;
            }
            this.Height = parentHeight;
        }
    }
}
