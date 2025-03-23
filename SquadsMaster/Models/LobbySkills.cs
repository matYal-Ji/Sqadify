using System.Collections.Generic;

namespace SquadsMaster.Models
{
    public class LobbySkills : Dictionary<string, int>
    {
        public LobbySkills() : base() { }
        public LobbySkills(IDictionary<string, int> dictionary) : base(dictionary) { }

        /// <summary>
        /// list of skills present in the lobby
        /// </summary>
        public List<string> Skills => [.. this.Keys];
    }
}
