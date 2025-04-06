namespace SquadsMaster.Models
{
    public class Team : LobbyBase
    {
        Dictionary<string, int> _score = null!;
        public Team() : base([]) { }
        public Team(IEnumerable<IPlayer> players) : base(players) { }

        public Dictionary<string, int> Score 
        { 
            get 
            {
                return _score ??= GetScore(); 
            } 
        }

        Dictionary<string, int> GetScore()
        {
            return LobbySkills.Skills.ToDictionary(item => item, item => 0);
        }
    }
}
