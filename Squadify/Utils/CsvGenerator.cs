using SquadsMaster.Models;
using System.Text;

namespace Squadify.Utils
{
    public static class CsvGenerator
    {
        public static string SaveTeamsToCsv(List<Team> teams)
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Join(",", teams.Select(t => t.Name)));

            // Get the maximum number of players in any team to ensure all rows are covered
            int maxPlayers = teams.Max(t => t.Players.Count);

            for (int i = 0; i < maxPlayers; i++)
            {
                var row = new List<string>();

                foreach (var team in teams)
                {
                    if (i < team.Players.Count)
                    {
                        row.Add(team.Players[i].Name);
                    }
                    else
                    {
                        row.Add(""); // Empty cell if the team has fewer players than the max
                    }
                }

                builder.AppendLine(string.Join(",", row));
            }
            return builder.ToString();
        }
    }
}
