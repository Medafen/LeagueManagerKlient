using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LeagueManagerClient
{
    public partial class ZmianaSkladu : Form
    {
        WebClient webClient = new WebClient();
        public ZmianaSkladu()
        {
            InitializeComponent();
            string username = "admin"; string password = "admin";
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            webClient.Headers.Add("Authorization", "Basic " + svcCredentials);

            var json = webClient.DownloadString("http://localhost:8081/api/players");


            List<Player> player = JsonConvert.DeserializeObject<List<Player>>(json);


            dataGridView1.DataSource = player;
            dataGridView2.DataSource = player;
        }

        private void buttonWstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZarządzanieDrużyną f2 = new ZarządzanieDrużyną(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void buttonStrona_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1(); //this is the change, code for redirect  
            f2.ShowDialog();
        }
    }
}
