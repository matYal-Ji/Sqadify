namespace SquadsMaster.Models
{
    public class Game
    {
        public List<Team> Teams { get; set; }
        public Game(List<Team> teams, int round = -1)
        {
            Teams = teams;
            Score = teams.ToDictionary(item => item, item => 0);
            Round = round;
        }
        public DateTime DateTime { get; set; }
        public Dictionary<Team, int> Score { get; set; }
        public int Round { get; set; }
    }
}