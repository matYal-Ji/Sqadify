namespace SquadsMaster.Models
{
    public interface ILobby
    {
        string Name { get; set; }
        IEnumerable<IPlayer> Players { get; set; }
        LobbySkills LobbySkills { get; set; }
    }
}
