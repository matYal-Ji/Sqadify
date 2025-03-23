namespace SquadsMaster.Models
{
    public class Lobby : LobbyBase
    {
        List<Team> _teams;
        public Lobby(IEnumerable<IPlayer> players) : base(players)
        {
            _teams = [];
        }
        public List<Team> Distribute(int numberOfTeams, List<string> skills = null!)
        {
            //handle 0 or negative number of teams
            if (numberOfTeams <= 0)
                return _teams;

            //handle null players
            Players ??= [];

            //initialize _teams with skills
            _teams = new List<Team>(Enumerable.Range(1, numberOfTeams).Select(i => new Team()
            {
                Name = $"Team {i}",
                LobbySkills = new LobbySkills(skills.ToDictionary(item => item, item => 0))
            }));

            //initial distribution
            InitialDistribution();

            //normalizing _teams
            NormalizeDistribution();

            return _teams;
        }

        /// <summary>
        /// performs initial distribution of the players in teams based on equal number of players
        /// </summary>
        void InitialDistribution()
        {
            //pick a player
            foreach (IPlayer player in Players)
            {
                //pick a team
                bool playerAdded = false;
                foreach (Team team in _teams)
                {
                    if (team.Players.Count() >= PlayersRequired(this))
                        break;
                    //check if player's skills does not overflow team's required skill
                    bool overflows = false;
                    foreach (string skill in this.LobbySkills.Skills)
                    {
                        if (team.LobbySkills.Skills.Contains(skill) && 
                            team.LobbySkills[skill] > PlayersRequired(this, skill))
                        {
                            overflows = true;
                            break;
                        }
                    }
                    if (!overflows)
                    {
                        team.AddPlayer(player);
                        playerAdded = true;
                        break;
                    }
                }
                //add the player in a team with least number of players
                if (!playerAdded)
                {
                    var teamWithLeastPlayers = _teams[0];
                    foreach (Team team in _teams)
                    {
                        teamWithLeastPlayers = team.Players.Count() < teamWithLeastPlayers.Players.Count() ? team : teamWithLeastPlayers;
                    }
                    teamWithLeastPlayers.AddPlayer(player);
                }
            }
        }

        /// <summary>
        /// normalizes the teams equalizing the skill set
        /// </summary>
        void NormalizeDistribution()
        {
            //pick a teamA
            for (int teamAIdx = 0; teamAIdx < _teams.Count; teamAIdx++)//temaA
            {
                var teamA = _teams[teamAIdx];
                //pick a skill
                foreach (var skill in teamA.LobbySkills.Skills)//teamA skills
                {
                    //if skill is less than requirement
                    if (teamA.LobbySkills[skill] < PlayersRequired(this, skill))
                    {
                        //check for the skill in other _teams
                        for (int teamBIdx = 0; teamBIdx < _teams.Count; teamBIdx++)//teamB
                        {
                            var teamB = _teams[teamBIdx];
                            if (teamBIdx != teamAIdx &&
                                teamB.LobbySkills[skill] > PlayersRequired(this, skill)) //have an extra
                            {
                                //get switchable players
                                for (int teamAPlayerIdx = 0; teamAPlayerIdx < teamA.Players.Count(); teamAPlayerIdx++)//teamA player
                                {
                                    var teamAPlayer = teamA.Players.ElementAt(teamAPlayerIdx);
                                    //get a player from teamA who does not posses 'skill'
                                    if (!teamAPlayer.Skills.Contains(skill))
                                        for (int teamBPlayerIdx = 0; teamBPlayerIdx < teamB.Players.Count(); teamBPlayerIdx++)//teamB player
                                        {
                                            var teamBPlayer = teamB.Players.ElementAt(teamBPlayerIdx);
                                            //get a player from teamB who posses 'skill'
                                            if (teamBPlayer.Skills.Contains(skill) &&
                                                CanSwitch(teamA, teamAPlayer, teamB, teamBPlayer))
                                            {
                                                //switch players
                                                teamA.ReplacePlayer(teamAPlayer, teamBPlayer);
                                                teamB.ReplacePlayer(teamBPlayer, teamAPlayer);

                                                break;
                                            }
                                        }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// check if the mentioned players are switchable
        /// </summary>
        /// <param name="teamA">teamA with playerA</param>
        /// <param name="playerA">playerA</param>
        /// <param name="teamB">teamA with playerB</param>
        /// <param name="playerB">playerB</param>
        /// <returns></returns>
        bool CanSwitch(Team teamA, IPlayer playerA, Team teamB, IPlayer playerB)
        {
            return CanRemove(teamA, playerA, playerB) &&
                CanRemove(teamB, playerB, playerA);
        }
        /// <summary>
        /// check if playerA can be removed safely from teamA to be replaced with playerB
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <returns>returns true if yes</returns>
        bool CanRemove(Team teamA, IPlayer playerA, IPlayer playerB)
        {
            foreach (var skill in playerA.Skills)
                if (!playerB.Skills.Contains(skill))
                    if (teamA.LobbySkills.Skills.Contains(skill) &&
                        teamA.LobbySkills[skill] - 1 < PlayersRequired(this, skill))
                        return false;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lobby"></param>
        /// <returns></returns>
        int PlayersRequired(LobbyBase lobby)
        {
            return PlayersRequired(lobby, null!);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="skill"></param>
        /// <param name="numberOfTeams"></param>
        /// <returns></returns>
        int PlayersRequired(LobbyBase lobby, string skill)
        {
            int totalCount = lobby.Players.Count();
            if (skill != null && lobby.LobbySkills.Skills.Contains(skill))
                totalCount = lobby.LobbySkills[skill];
            return totalCount / _teams.Count;
        }
    }
}

/*
 * Design changes to be implemented:
 * 
 * 1. better skill object for player, lobby and team [skill have many functions—so it is better to have a class]
 * 2. base class for lobby and team [alot of APIs are same]
 * 3. dynamic skill count (so we do not need to specify the count / class will be having player's info to return skill count) [alternative to LobbySkills[skill]++--]
 * 4. required number of skill in a team (calculate it dynamically and provide an API to user to specify) [alternative to this.LobbySkills[skill] / numberOfTeams]
 * 5. fragment 'for' loops
 */