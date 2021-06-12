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
    public partial class ZarządzanieDrużyną : Form
    {
        WebClient webClient = new WebClient();
        string zmienna;
        void fun(string rowNick)
        {
            

            var json = webClient.DownloadString("http://localhost:8081/api/players");


            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);
            foreach (var item in player.Where(a => a.nickname.Equals(rowNick)))
            {
                labelA.Text = item.laning.ToString();
                labelB.Text = item.mapAwareness.ToString();
                labelC.Text = item.mechanics.ToString();
                labelD.Text = item.roaming.ToString();
                labelE.Text = item.teamfighting.ToString();
                
            }
        }
        public ZarządzanieDrużyną()
        {
            InitializeComponent();

            string username = "admin"; string password = "admin";
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            webClient.Headers.Add("Authorization", "Basic " + svcCredentials);

            var json = webClient.DownloadString("http://localhost:8081/api/players");


            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);


            dataGridViewCzlonkowie.Rows.Clear();
            dataGridViewCzlonkowie.Columns.Clear();
            dataGridViewCzlonkowie.Columns.Add("imie", "Imie");
            dataGridViewCzlonkowie.Columns.Add("nickname", "Nickname");
            dataGridViewCzlonkowie.Columns.Add("nazwisko", "Nazwisko");



            
            foreach (var item in player)
            {
                dataGridViewCzlonkowie.Rows.Add(item.name, item.nickname, item.surname);
            }

            
        }





        private void buttonZmiana_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmianaSkladu f1 = new ZmianaSkladu(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void buttonTrening_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trening f2 = new Trening(); //this is the change, code for redirect  
            f2.ShowDialog();

        }

        private void buttonStrona_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1(); //this is the change, code for redirect  
            f3.ShowDialog();
        }

        private void dataGridViewCzlonkowie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index= e.RowIndex;
            DataGridViewRow wybrany = dataGridViewCzlonkowie.Rows[index];



            fun(wybrany.Cells[1].Value.ToString());
            textBox1.Text = wybrany.Cells[1].Value.ToString();
        }

        private void ZarządzanieDrużyną_Load(object sender, EventArgs e)
        {

        }
    }
}
