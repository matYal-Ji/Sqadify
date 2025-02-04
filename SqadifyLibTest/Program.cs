using Newtonsoft.Json;
using SquadifyLibTest;
using SquadsMaster.Models;

var fileTxt = File.ReadAllText("Games_Day_Particpants_Data.json");

var serializer = new JsonSerializer();
var players = serializer.Deserialize<IEnumerable<Player>>(new JsonTextReader(new StringReader(fileTxt)));

var uniqueSkills = new HashSet<string>();
foreach (var player in players!)
    foreach (var skill in player.Skills)
        uniqueSkills.Add(skill);

var lobby = new Lobby(players!);
var teams = lobby.Distribute(4, ["Table Tennis", "Badminton", "Video Game", "Tennis", "Puzzle Making"]);

//display
Console.WriteLine($"Total Players: {players.Count()}");
Console.WriteLine($"Total Teams: {teams.Count}");
Console.Write("\t\t\t");
foreach (var skill in teams[0].SkillCount.Keys)
    Console.Write($"{skill,15}");
foreach (var team in teams)
{
    Console.Write($"\n\t{team.Name}[{team.Players.Count}]:\t");
    foreach (var skillCount in team.SkillCount.Values)
    {
        Console.Write($"{skillCount,15}");
    }
    Console.WriteLine("");
    foreach (var player in team.Players)
    {
        //Console.WriteLine(player.Name);
    }
}