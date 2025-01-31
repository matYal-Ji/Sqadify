namespace SquadsMaster.Models
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Age { get; set; }
        Enum.Gender Gender { get; set; }
        IEnumerable<string> Skills { get; }
    }
}
