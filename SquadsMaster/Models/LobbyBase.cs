namespace SquadsMaster.Models
{
    public class LobbyBase : ILobby
    {
        /// <summary>
        /// Name of the Lobby/Team
        /// </summary>
        public string Name { get; set; }
        public IEnumerable<IPlayer> Players { get; set; }
        public LobbySkills LobbySkills { get; set; }

        public LobbyBase(IEnumerable<IPlayer> players)
        {
            Name = string.Empty;
            Players = [];
            LobbySkills = [];
            foreach(var player in players)
                AddPlayer(player);
        }

        /// <summary>
        /// adds player to the lobby updating lobby's skillset
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(IPlayer player)
        {
            var players = Players.ToList();
            players.Add(player);
            Players = players;
            AddSkills(player);
        }
        /// <summary>
        /// removes player from the lobby updating lobby's skill set
        /// </summary>
        /// <param name="player"></param>
        public void RemovePlayer(IPlayer player)
        {
            var players = Players.ToList();
            players.Remove(player);
            Players = players;
            RemoveSkills(player);
        }
        /// <summary>
        /// replaces player in the lobby updating lobby's skill set
        /// </summary>
        /// <param name="oldPlayer"></param>
        /// <param name="newPlayer"></param>
        public void ReplacePlayer(IPlayer oldPlayer, IPlayer newPlayer)
        {
            var players = Players.ToList();
            players[players.IndexOf(oldPlayer)] = newPlayer;
            AddSkills(newPlayer);
            RemoveSkills(oldPlayer);
        }

        void AddSkills(IPlayer player)
        {
            foreach (var skill in player.Skills)
            {
                if (LobbySkills.Skills.Contains(skill))
                    LobbySkills[skill]++;
                else
                    LobbySkills.Add(skill, 1);
            }
        }
        void RemoveSkills(IPlayer player)
        {
            foreach (var skill in player.Skills)
            {
                if (LobbySkills.Skills.Contains(skill) && LobbySkills[skill] > 0)
                    LobbySkills[skill]--;
            }
        }
    }
}
