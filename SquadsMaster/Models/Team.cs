using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadsMaster.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; } = [];
        public Dictionary<string, int> SkillCount { get; set; } = [];
    }
}
