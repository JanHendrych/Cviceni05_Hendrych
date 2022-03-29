using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class TopClubs : Form
    {
        private FootballClub[] Clubs{ get; set; }
        private int NumberOfGoals { get; set; }
        public TopClubs(FootballClub[] clubs, int goals)
        {
            InitializeComponent();
            Clubs = clubs;
            NumberOfGoals = goals;
            listView1.Items.Clear();
            for (int i = 0; i < Clubs.Length; i++)
            {
                listView1.Items.Add(Clubs[i].ToString());          
            }
            lblPocetGolu.Text = NumberOfGoals.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
