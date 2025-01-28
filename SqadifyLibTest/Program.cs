
using Newtonsoft.Json;
using SquadsMaster.Models;

var fileTxt = File.ReadAllText("Games_Day_Particpants_Data.json");

var serializer = new JsonSerializer();
var jsonPlayers = serializer.Deserialize<SqadifyLibTest.PlayerObj[]>(new JsonTextReader(new StringReader(fileTxt)));

var players = (from player in jsonPlayers
               select new Player()
               {
                   Name = player.Name,
                   Age = player.Age,
                   Gender = player.Gender,
                   Skills = player.Skills.Split(',').Select(item => item.Trim()),
               }).ToList();

var lobby = new Lobby(players);
var teams = lobby.Distribute(4);

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
        Console.WriteLine(player.Name);
    }
}