using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LeagueManagerClient
{
    class Danepodreczne
    {
        WebClient webClient = new WebClient();
        
        public  List<Team> teams()
        {
            string username = "admin";
            string password = "admin";
            string svcCredentials =
            Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            webClient.Headers.Add("Authorization", "Basic " + svcCredentials);
            var json = webClient.DownloadString("http://localhost:8081/api/teams");
            
            List<Team> tm = JsonConvert.DeserializeObject<List<Team>>(json);
            return tm;
        }

        



    }
}
