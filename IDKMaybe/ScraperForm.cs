//Jayden Wigley
//Final C# Project
//12-15-21
//Site to Scrape
//https://dennisreep.nl/dbd/roulette/survivor/
//https://dennisreep.nl/dbd/roulette/killer/
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IDKMaybe
{
    public partial class ScraperForm : Form
    {
        Scraper scraper = new Scraper();
        public ScraperForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginSignUp frm2 = new LoginSignUp();
            this.Hide();
            frm2.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            scraper.Rouletter(txtSearchUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\Administrator\\source\\repos\\IDKMaybe\\IDKMaybe\\History.txt", $"\n{scraper.file}");
            string readText = File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\IDKMaybe\\IDKMaybe\\History.txt");
            Debug.Print(readText);
        }
    }
}
