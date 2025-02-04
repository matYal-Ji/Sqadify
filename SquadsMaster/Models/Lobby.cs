namespace SquadsMaster.Models
{
    public class Lobby
    {
        public IEnumerable<IPlayer> Players { get; set; }
        public Dictionary<string, int> SkillCount { get; set; }
        public Lobby(IEnumerable<IPlayer> players)
        {
            Players = players;
            SkillCount = [];
        }
        public List<Team> Distribute(int numberOfTeams, List<string> skills = null!)
        {
            //handle null skills
            if (skills == null)
            {
                var uniqueSkills = new HashSet<string>();
                foreach (var player in Players)
                    foreach (var skill in player.Skills)
                        uniqueSkills.Add(skill);
                skills = [.. uniqueSkills];
            }
            //populate lobby skills
            foreach (var skill in skills)
                this.SkillCount[skill] = 0;
            foreach (var player in Players)
                foreach (var skill in player.Skills)
                {
                    if (this.SkillCount.Keys.Contains(skill))
                        this.SkillCount[skill]++;
                }

            //initialize teams with skills
            var teams = new List<Team>(Enumerable.Range(1, numberOfTeams).Select(i => new Team()
            {
                Name = $"Team {i}",
                SkillCount = this.SkillCount.ToDictionary(item => item.Key, item => 0)
            }));

            //initial distribution
            //pick a player
            foreach (IPlayer player in Players)
            {
                //pick a team
                bool playerAdded = false;
                foreach (Team team in teams)
                {
                    if (team.Players.Count >= this.Players.Count() / numberOfTeams) 
                        break;
                    //check if player's skills does not overflow team's required skill
                    bool overflows = false;
                    foreach (string skill in this.SkillCount.Keys)
                    {
                        if (team.SkillCount[skill] > this.SkillCount[skill] / numberOfTeams)
                        {
                            overflows = true;
                            break;
                        }
                    }
                    if (!overflows)
                    {
                        AddPlayer(team, player);
                        playerAdded = true;
                        break;
                    }
                }
                //add the player in a team with least number of players
                if (!playerAdded)
                {
                    var teamWithLeastPlayers = teams[0];
                    foreach (Team team in teams)
                    {
                        teamWithLeastPlayers = team.Players.Count < teamWithLeastPlayers.Players.Count ? team : teamWithLeastPlayers;
                    }
                    AddPlayer(teamWithLeastPlayers, player);
                }
            }

            //normalizing teams
            //pick a teamA
            for (int teamAIdx = 0; teamAIdx < teams.Count; teamAIdx++)
            {
                var teamA = teams[teamAIdx];
                //pick a skill
                foreach (var skill in teamA.SkillCount.Keys)
                {
                    //if skill is less than requirement
                    if (teamA.SkillCount[skill] < this.SkillCount[skill] / numberOfTeams)
                    {
                        //check for the skill in other teams
                        for (int teamBIdx = 0; teamBIdx < teams.Count; teamBIdx++)
                        {
                            var teamB = teams[teamBIdx];
                            if (teamBIdx != teamAIdx &&
                                teamB.SkillCount[skill] > this.SkillCount[skill] / numberOfTeams) //have an extra
                            {
                                //get switchable players
                                for (int teamAPlayerIdx = 0; teamAPlayerIdx < teamA.Players.Count; teamAPlayerIdx++)
                                {
                                    var teamAPlayer = teamA.Players[teamAPlayerIdx];
                                    if (teamAPlayer.Skills.Contains(skill))
                                        for (int teamBPlayerIdx = 0; teamBPlayerIdx < teamB.Players.Count; teamBPlayerIdx++)
                                        {
                                            var teamBPlayer = teamB.Players[teamBPlayerIdx];
                                            if (teamBPlayer.Skills.Contains(skill))
                                                if (CanSwitch(teamA, teamAPlayer, teamB, teamBPlayer, numberOfTeams))
                                                {
                                                    //switch players
                                                    teamA.Players[teamAPlayerIdx] = teamBPlayer;
                                                    teamB.Players[teamBPlayerIdx] = teamAPlayer;
                                                    Console.WriteLine($"[{teamA.Name}] {teamAPlayer.Name,-20}<—>\t[{teamB.Name}] {teamBPlayer.Name}");
                                                    break;
                                                }
                                        }
                                }
                            }
                        }
                    }
                }
            }

            return teams;
        }

        /// <summary>
        /// check if the mentioned players are switchable
        /// </summary>
        /// <param name="teamA">teamA with playerA</param>
        /// <param name="playerA">playerA</param>
        /// <param name="teamB">teamA with playerB</param>
        /// <param name="playerB">playerB</param>
        /// <returns></returns>
        bool CanSwitch(Team teamA, IPlayer playerA, Team teamB, IPlayer playerB, int numberOfTeams)
        {
            return CanRemove(teamA, playerA, playerB, numberOfTeams) &&
                CanRemove(teamB, playerB, playerA, numberOfTeams);
        }
        /// <summary>
        /// check if playerA can be removed safely from teamA
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <param name="numberOfTeams"></param>
        /// <returns>returns true if yes</returns>
        bool CanRemove(Team teamA, IPlayer playerA, IPlayer playerB, int numberOfTeams)
        {
            foreach (var skill in playerA.Skills)
                if (!playerB.Skills.Contains(skill))
                    if (teamA.SkillCount.ContainsKey(skill) &&
                        teamA.SkillCount[skill] - 1 < this.SkillCount[skill] / numberOfTeams)
                        return false;
            return true;
        }
        void AddPlayer(Team team, IPlayer player)
        {
            team.Players.Add(player);
            foreach (var skill in player.Skills)
                if (team.SkillCount.ContainsKey(skill))
                    team.SkillCount[skill]++;
        }
    }
}
