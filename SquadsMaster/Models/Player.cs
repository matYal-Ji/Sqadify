namespace SquadsMaster.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Enum.Gender Gender { get; set; }
        public IEnumerable<string> Skills { get; set; }
    }
}
