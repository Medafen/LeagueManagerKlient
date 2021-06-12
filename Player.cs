using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManagerClient
{
    class Player
    {
        /*[JsonProperty("player_id")]
        public int playerId { get; set; }
        [JsonProperty("is_jng")]
        public Boolean Is_jng { get; set; }
        [JsonProperty("laning")]
        public int Laning { get; set; }
        [JsonProperty("map_awareness")]
        public int Map_awareness { get; set; }
        [JsonProperty("mechanics")]
        public int Mechanics { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("roaming")]
        public int Roaming { get; set; }
        [JsonProperty("role")]
        public int Role { get; set; }
        [JsonProperty("surname")]
        public int Sruname { get; set; }
        [JsonProperty("teamfights")]
        public int Teamfights { get; set; }
        [JsonProperty("team_id")]
        public int Team_id { get; set; }*/
        public int playerId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string nickname { get; set; }
        public string role { get; set; }
        public int mapAwareness { get; set; }
        public int mechanics { get; set; }
        public int laning { get; set; }
        public int teamfighting { get; set; }
        public int roaming { get; set; }
        public bool jng { get; set; }
        public Team team { get; set; }
    }
}
