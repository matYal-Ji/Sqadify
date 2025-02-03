using Newtonsoft.Json;
using SquadsMaster.Models;
using System.Numerics;

namespace Squadify.Data
{
    public static class PlayerDataUtil
    {
        public static IEnumerable<Player>? PlayerData { get; private set; }

        public static IEnumerable<Player>? GetPlayerData(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            var fileTxt = File.ReadAllText(filePath);
            var serializer = new JsonSerializer();
            PlayerData = serializer.Deserialize<IEnumerable<Player>>(new JsonTextReader(new StringReader(fileTxt)));
            return PlayerData;
        }
    }
}
