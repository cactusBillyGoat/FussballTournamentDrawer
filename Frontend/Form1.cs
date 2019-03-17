using System;
using System.Linq;
using System.Windows.Forms;

using Backend;

namespace Frontend
{
    public partial class Form1 : Form
    {
        private Tournament Tournament = new Tournament();

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            SecondPagePanel.Visible = true;
            GC.Collect();
        }

        private void DrawTournamentButton_Click(object sender, EventArgs e)
        {
            if (!Tournament.Teams.Any())
            {
                MessageBox.Show($"Please first draw the teams before drawing the tournament!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Tournament.DrawTournament();

            if (Tournament.HasBeenDrawed)
            {

            }
            else
            {
                MessageBox.Show($"A problem encountered, please review your input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawTeamsButton_Click(object sender, EventArgs e)
        {
            if (!Tournament.Players.Any())
            {
                MessageBox.Show($"Please first insert the players before drawing the teams!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Tournament.DrawTeams();

            if (Tournament.TeamsHaveBeenDrawed)
            {
                MessageBox.Show($"The teams have been draw successfully!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"A problem encountered, please review your input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Restart();
        }

        private void SecondPagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstPagePanel_Paint(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = true;
            SecondPagePanel.Visible = false;
            GC.Collect();
        }
    }
}
