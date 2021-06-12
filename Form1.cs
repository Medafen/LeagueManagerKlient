using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace LeagueManagerClient
{
    public partial class Form1 : Form
    {
        Danepodreczne danePod = new Danepodreczne(); 
        public Form1()
        {
            InitializeComponent();
        }
        static readonly HttpClient client = new HttpClient();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private  void buttonZarzadzanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trening f2 = new Trening(); //this is the change, code for redirect  
            f2.Show();
            f2.Activate();

        }
    }
}
/*Player gracz = new Player() {
                jng = false,
                laning = 100,
                mapAwareness = 100,
                mechanics = 100,
                name = "Szymek",
                nickname = "Szy",
                roaming = 100,
                role = "MID",
                surname = "Kowalczyk",
                teamfighting = 100,
                team = danePod.teams().First()
            };
            
            WebClient webClient = new WebClient();
           // webClient.Encoding = Encoding.UTF8;
            //string aa = Newtonsoft.Json.JsonConvert.SerializeObject(gracz);
            var jsonn = System.Text.Json.JsonSerializer.Serialize(gracz);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonn);

            

            string username = "admin"; string password = "admin"; string svcCredentials =
                Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            webClient.Headers.Add("Authorization", "Basic " + svcCredentials);
            
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.UploadData("http://localhost:8081/api/addPlayer","POST",byteArray);

            var json = webClient.DownloadString("http://localhost:8081/api/players");
            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);
            foreach(var item in player.Where(a=> a.playerId == 1))
            {
                textBox1.Text = item.nickname;
            }*/