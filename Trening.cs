using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeagueManagerClient
{
    public partial class Trening : Form
    {
        public Trening()
        {
            InitializeComponent();
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
