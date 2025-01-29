using Newtonsoft.Json;
using SquadsMaster.Models;

namespace Squadify.Data
{
    public static class PlayerDataUtil
    {
        public static List<Player> GetPlayerData()
        {
            var fileTxt = File.ReadAllText(@"Data\Games_Day_Particpants_Data.json");
            var serializer = new JsonSerializer();
            var jsonPlayers = serializer.Deserialize<PlayerJsonModel[]>(new JsonTextReader(new StringReader(fileTxt)));

            var players = (from player in jsonPlayers
                           select new Player()
                           {
                               Name = player.Name,
                               Age = player.Age,
                               Gender = player.Gender,
                               Skills = player.Skills.Split(',').Select(item => item.Trim()),
                           }).ToList();

            return players;
        }
    }
}
