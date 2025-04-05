using SquadsMaster.Enum;
using SquadsMaster.Models;

namespace SquadifyLibTest
{
    public static class Scheduler
    {
        public static List<Game> GenerateSchedule(List<Team> teams, ScheduleType scheduleType)
        {
            if (teams.Count <= 1) throw new Exception("less than two teams! two or more teams must participate");
            return scheduleType switch
            {
                ScheduleType.Elimination => GenerateEliminationSchedule(teams),
                ScheduleType.RoundRobin => GenerateRoundRobinSchedule(teams),
                _ => throw new NotImplementedException(),
            };
        }

        static List<Game> GenerateEliminationSchedule(List<Team> teams)
        {
            var games = new List<Game>();
            for (int teamIdx = 0; teamIdx < teams.Count - 1;)
            {
                var participatingTeams = new List<Team>();

                do
                    participatingTeams.Add(teams[teamIdx++]);
                while (teamIdx % 2 != 0); //'2' can be replaced with number of participatingTeams participating (can be a future enhancement) | e.g. more than two teams participating in a game

                if (participatingTeams.Count == 0)
                    break;

                games.Add(new Game(participatingTeams));
            }

            return games;
        }

        static List<Game> GenerateRoundRobinSchedule(List<Team> teams)
        {
            if (teams.Count % 2 != 0)
            {
                teams.Add(new Team()
                {
                    Name = "Bye"
                }); // If odd number of participatingTeams, add a dummy team
            }
            int numRounds = teams.Count - 1;
            int numMatchesPerRound = teams.Count / 2;
                List<Game> games = [];

            for (int round = 0; round < numRounds; round++)
            {
                for (int i = 0; i < numMatchesPerRound; i++)
                {
                    var team1 = teams[i];
                    var team2 = teams[teams.Count - 1 - i];
                    if (team1.Name != "Bye" && team2.Name != "Bye")
                    {
                        games.Add(new([team1, team2], round));
                    }
                }
                RotateTeams(teams);
            }
            teams.Remove(teams.Last());
            return games;
        }

        static void RotateTeams(List<Team> teams)
        {
            Team temp = teams[^1];
            for (int i = teams.Count - 1; i > 1; i--)
            {
                teams[i] = teams[i - 1];
            }
            teams[1] = temp;
        }
    }
}
