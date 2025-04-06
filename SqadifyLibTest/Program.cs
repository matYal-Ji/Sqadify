using Newtonsoft.Json;
using SquadifyLibTest;
using SquadsMaster.Models;

//var fileTxt = File.ReadAllText("DataSet/Games_Day_Particpants_Data.json");
var fileTxt = File.ReadAllText("DataSet/Games_Day_Particpants_Data_1000.json");
//var fileTxt = File.ReadAllText("DataSet/Games_Day_Particpants_Data_10_000.json");
//var fileTxt = File.ReadAllText("DataSet/Edge_Case_Games_Participants_Data.json");

var serializer = new JsonSerializer();
var players = serializer.Deserialize<IEnumerable<Player>>(new JsonTextReader(new StringReader(fileTxt)))!;

var lobby = new Lobby(players);
var teams = lobby.Distribute(25, ["Table Tennis", "Badminton", "Video Game", "Tennis", "Puzzle Making"]);

//display results on console
Console.WriteLine($"Total Players: {players.Count()}");
Console.WriteLine("Complete Skillset:");
foreach (var skill in lobby.LobbySkills)
    Console.WriteLine($"\t{skill.Key,-15}: {skill.Value}");
Console.WriteLine($"Total Teams: {teams.Count}");
Console.Write("\t\t\t");
foreach (var skill in teams[0].LobbySkills.Keys)
    Console.Write($"{skill,15}");
foreach (var team in teams)
{
    Console.Write($"\n\t{team.Name}[{team.Players.Count()}]:\t");
    foreach (var skillCount in team.LobbySkills.Values)
    {
        Console.Write($"{skillCount,15}");
    }
    Console.WriteLine("");
    /*foreach (var player in team.Players)
    {
        Console.WriteLine(player.Name);
    }*/
}

var scheduleType = SquadsMaster.Enum.ScheduleType.Elimination;

var games = Scheduler.GenerateSchedule(teams, scheduleType);


Console.WriteLine($"\n\n{scheduleType} Scheduling ------------------");
if (scheduleType == SquadsMaster.Enum.ScheduleType.Elimination)
    PrintRound(games);
else
{
    var rounds = games.GroupBy(game => game.Round)
                    .Select(group => group.ToList())
                    .ToList();
    foreach (var round in rounds)
        PrintRound(round);
}

void PrintRound(List<Game> games)
{
    if (games.First().Round != -1)
        Console.WriteLine($"Round {games.First().Round + 1}:");
    foreach (var game in games)
    {
        //Console.Write($"\tGame {round.Games.IndexOf(game)}: ");
        if (game.Teams.Count == 0) break;
        Console.Write($"\t{game.Teams[0].Name}");
        for (int teamIdx = 1; teamIdx < game.Teams.Count; teamIdx++)
            Console.Write($"  VS  {game.Teams[teamIdx].Name}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
 * Instead of rounds return Schedule object containing rounds and games
 * score should be at team level (or game level?)
 */