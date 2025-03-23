namespace SquadsMaster.Models
{
    public class Team : LobbyBase
    {
        public Team() : base([]) { }
        public Team(IEnumerable<IPlayer> players) : base(players) { }
    }
}
