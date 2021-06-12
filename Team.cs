using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManagerClient
{
    class Team
    {
        public int teamId { get; set; }
        public string name { get; set; }
        public List<Player> players { get; set; }

    }
}
