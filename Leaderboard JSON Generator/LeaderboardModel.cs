using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaderboard_JSON_Generator
{
    class LeaderboardModel
    {
        public int index { get; set; }
        public string name { get; set; }
        public string @class { get; set; }
        public string tasks { get; set; }
        public string points { get; set; }

        public LeaderboardModel(int Index, string Name, string Class, string Tasks, string Points)
        {
            index = Index;
            name = Name;
            @class = Class;
            tasks = Tasks;
            points = Points;
        }
    }
}
