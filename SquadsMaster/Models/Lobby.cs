namespace SquadsMaster.Models
{
    public class Lobby
    {
        public IEnumerable<IPlayer> Players { get; set; }
        public Dictionary<string, int> SkillCount { get; set; } = new Dictionary<string, int>();
        public Lobby(IEnumerable<IPlayer> players)
        {
            Players = players;
        }
        public List<Team> Distribute(int numberOfTeams/*, List<string> skills*/)
        {
            //populate lobby skills
            foreach (IPlayer player in Players)
                foreach (string skill in player.Skills)
                {
                    if (!SkillCount.TryGetValue(skill, out int value)) SkillCount[skill] = 1;
                    else SkillCount[skill] = ++value;
                }
            //initiate teams with skills
            var teams = new List<Team>(Enumerable.Range(1, numberOfTeams).Select(i => new Team()
            {
                Name = $"Team {i}",
                SkillCount = this.SkillCount.ToDictionary(item => item.Key, item => 0)
            }));
            //pick a player
            foreach (IPlayer player in Players)
            {
                //pick a team
                bool playerAddedInATeam = false;
                foreach (Team team in teams)
                {
                    //check if player's skills does not overflow team's required skill
                    bool overflows = false;
                    foreach (string skill in this.SkillCount.Keys)
                    {
                        if (team.SkillCount[skill] < this.SkillCount[skill])
                        {
                            overflows = true;
                            break;
                        }
                    }
                    if (!overflows)
                    {
                        AddPlayer(team, player);
                        playerAddedInATeam = true;
                        break;
                    }
                }
                //add the player in a team with lest number of players
                if (!playerAddedInATeam)
                {
                    var teamWithLeastPlayers = teams[0];
                    foreach (Team team in teams)
                    {
                        teamWithLeastPlayers = team.Players.Count < teamWithLeastPlayers.Players.Count ? team : teamWithLeastPlayers;
                    }
                    AddPlayer(teamWithLeastPlayers, player);
                }
            }
            return teams;
        }
        void AddPlayer(Team team, IPlayer player)
        {
            team.Players.Add(player);
            foreach(var skill in player.Skills)
                team.SkillCount[skill]++;
        }
    }
}
