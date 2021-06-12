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
        WebClient webClient = new WebClient();

        void fun(string teamName)
        {
            var json = webClient.DownloadString("http://localhost:8081/api/players");
            var json1 = webClient.DownloadString("http://localhost:8081/api/teams");

            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);
            List<Team> team = JsonConvert.DeserializeObject<List<Team>>(json1);
            tabelZawodnicySetRows(dataGridViewGracz);
            foreach (var item in player.Where(a => a.team.name.Equals(teamName)))
            {
                dataGridViewGracz.Rows.Add(item.name, item.nickname, item.surname, item.role);
            }

        }
        void fun1(string teamName)
        {
            var json = webClient.DownloadString("http://localhost:8081/api/players");
            var json1 = webClient.DownloadString("http://localhost:8081/api/teams");

            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);
            List<Team> team = JsonConvert.DeserializeObject<List<Team>>(json1);
            tabelZawodnicySetRows(dataGridViewPrzeciwnik);
            foreach (var item in player.Where(a => a.team.name.Equals(teamName)))
            {
                dataGridViewPrzeciwnik.Rows.Add(item.name, item.nickname, item.surname, item.role);
            }
        }
        void tabelZawodnicySetRows(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.Columns.Add("imie", "Imie");
            grid.Columns.Add("nickname", "Nickname");
            grid.Columns.Add("nazwisko", "Nazwisko");
            grid.Columns.Add("rola", "Rola");
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        Danepodreczne danePod = new Danepodreczne();
        public Form1()
        {
            InitializeComponent();
        }
        //static readonly HttpClient client = new HttpClient();
        private void Form1_Load(object sender, EventArgs e)
        {
            string username = "admin"; string password = "admin";
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            webClient.Headers.Add("Authorization", "Basic " + svcCredentials);

            var json = webClient.DownloadString("http://localhost:8081/api/players");
            var json1 = webClient.DownloadString("http://localhost:8081/api/teams");

            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);
            List<Team> team = JsonConvert.DeserializeObject<List<Team>>(json1);



            tabelZawodnicySetRows(dataGridViewGracz);
            tabelZawodnicySetRows(dataGridViewPrzeciwnik);



            dataGridViewDruzyny.DataSource = team;
            dataGridViewDruzyna1.DataSource = team;
            dataGridViewDruzyny.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewDruzyna1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            foreach (var item in player)
            {
                dataGridViewGracz.Rows.Add(item.name, item.nickname, item.surname, item.role);
            }
            foreach (var item in player)
                foreach (var item2 in team.Where(a => a.teamId == item.team.teamId))
                {
                    dataGridViewPrzeciwnik.Rows.Add(item.name, item.nickname, item.surname, item.role);
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZarzadzanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZarządzanieDrużyną f2 = new ZarządzanieDrużyną(); //this is the change, code for redirect  
            f2.ShowDialog();

        }

        private void dataGridViewDruzyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow wybrany = dataGridViewDruzyny.Rows[index];



            fun1(wybrany.Cells[1].Value.ToString());
        }

        private void dataGridViewDruzyna1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow wybrany = dataGridViewDruzyny.Rows[index];



            fun(wybrany.Cells[1].Value.ToString());
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