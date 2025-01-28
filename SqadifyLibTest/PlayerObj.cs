using Newtonsoft.Json;
using SquadsMaster.Enum;

namespace SqadifyLibTest
{
    class PlayerObj
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [JsonProperty("Phone number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("Types of games they can participate in")]
        public string Skills { get; set; }
    }
}
