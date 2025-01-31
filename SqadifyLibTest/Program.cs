using Newtonsoft.Json;
using SqadifyLibTest;
using SquadsMaster.Models;

var fileTxt = File.ReadAllText("Games_Day_Particpants_Data.json");

var serializer = new JsonSerializer();
var jsonPlayers = serializer.Deserialize<IEnumerable<Player>>(new JsonTextReader(new StringReader(fileTxt)));

var lobby = new Lobby(jsonPlayers!);
var teams = lobby.Distribute(5);

//display
foreach (var team in teams)
{
    Console.WriteLine();
    Console.WriteLine($"team.Name: {team.Name}");
    Console.WriteLine($"team.Players.Count: {team.Players.Count}");
    Console.WriteLine();
    foreach (var skill in team.SkillCount)
    {
        Console.WriteLine($"{skill.Key}: {skill.Value}");
    }
    Console.WriteLine();
    foreach(var player in team.Players)
    {
        //Console.WriteLine(player.Name);
    }
}