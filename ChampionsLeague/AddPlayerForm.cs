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
    public partial class AddPlayerForm : Form
    {
        public Player? Player { get; set; }
        public AddPlayerForm()
        {
            InitializeComponent();

            foreach (FootballClub klub in FootballClubInfo.Items)
            {
                cmBxClub.Items.Add(klub);
            }       
            cmBxClub.SelectedIndex = 0;
            this.DialogResult = DialogResult.None;
            
            btnStorno.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int goals = 0;
            
            if (int.TryParse(txtBoxGoals.Text, out goals) && txtBoxName.Text.Length>0 && cmBxClub.SelectedIndex > 0)
            {
                this.DialogResult=DialogResult.OK;
                Player = new Player(txtBoxName.Text, (FootballClub)cmBxClub.SelectedItem, goals);
            } else
            {
                MessageBox.Show("Chybně zadané hodnoty", "Chyba!", MessageBoxButtons.OK);
            } 
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            if (Player != null)
            {
                txtBoxName.Text = Player.Name;
                txtBoxGoals.Text = Player.GoalCount.ToString();
                cmBxClub.SelectedItem = Player.Club;
            }
        }
    }
}
