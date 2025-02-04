using Newtonsoft.Json;
using SquadsMaster.Enum;
using SquadsMaster.Models;

namespace Squadify.Data
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [JsonProperty("Phone number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("Types of games they can participate in")]
        public string Games { get; set; }
        public IEnumerable<string> Skills { get => this.Games.Split(',').Select(item => item.Trim()); }
    }
}
