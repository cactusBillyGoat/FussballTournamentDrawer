using System;
using System.Windows.Forms;
using Backend;
using CampionatFussball;

namespace Frontend
{
    public partial class Form1 : Form
    {
        private readonly Tournament mTournament = new Tournament();
        private const string cmNickName = "Nickname";
        private string mOldName;

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
            if (!mTournament.AnyTeams)
            {
                MessageBox.Show(@"Please first draw the teams before drawing the tournament!", @"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            mTournament.DrawTournament();

            if (mTournament.HasBeenDrawn)
            {

            }
            else
            {
                MessageBox.Show(@"A problem encountered, please review your input", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawTeamsButton_Click(object sender, EventArgs e)
        {
            if (!mTournament.AnyPlayers)
            {
                MessageBox.Show(@"Please first insert the players before drawing the teams!", @"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            mTournament.DrawTeams();

            if (mTournament.TeamsHaveBeenDrawn)
            {
                MessageBox.Show(@"The teams have been draw successfully!", @"Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"A problem encountered, please review your input", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PlayersTextBox.Text == string.Empty || PlayersTextBox.Text == cmNickName)
            {
                NoNickNameErrorLabel.Visible = true;
                return;
            }

            if (mTournament.Players.Contains(new Player(PlayersTextBox.Text, Enums.PlayerStyle.Attack)))
            {
                APlayerWithThisNameAlreadyAddedLabel.Visible = true;
                return;
            }

            NoNickNameErrorLabel.Visible = false;
            APlayerWithThisNameAlreadyAddedLabel.Visible = false;

            Enum.TryParse(PlayerStyleComboBox.SelectedItem.ToString(), out Enums.PlayerStyle position_enum);
            var player = new Player(PlayersTextBox.Text, position_enum);

            PlayersListBox.BeginUpdate();
            mTournament.AddPlayer(player);
            PlayersListBox.Items.Add(player);
            PlayersListBox.EndUpdate();

            PlayersTextBox.Text = cmNickName;
            PlayerStyleComboBox.SelectedItem = Enums.PlayerStyle.Attack;
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

        private void PlayersTextBox_GotFocus(object sender, EventArgs e)
        {
            if (PlayersTextBox.Text == cmNickName)
            {
                PlayersTextBox.Text = string.Empty;
            }
        }

        private void PlayersTextBox_LostFocus(object sender, EventArgs e)
        {
            if (PlayersTextBox.Text == string.Empty)
            {
                PlayersTextBox.Text = cmNickName;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PlayerStyleComboBox.SelectedItem = ((Player) PlayersListBox.SelectedItem).PreferredPosition;
            PlayersTextBox.Text = ((Player) PlayersListBox.SelectedItem).NickName;
            mOldName = PlayersTextBox.Text;

            ConfirmButton.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var player = new Player(((Player) PlayersListBox.SelectedItem).NickName, Enums.PlayerStyle.Attack);
            mTournament.DeletePlayer(player);

            PlayersListBox.BeginUpdate();
            PlayersListBox.Items.Remove(player);
            PlayersListBox.EndUpdate();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var new_position = PlayerStyleComboBox.SelectedItem.ToString();
            Enum.TryParse(new_position, out Enums.PlayerStyle position_enum);

            var new_name = PlayersTextBox.Text;

            mTournament.EditPlayer(new Player(mOldName, position_enum), new_name, position_enum);

            PlayersListBox.BeginUpdate();

            PlayersListBox.Items.Clear();

            foreach (var player in mTournament.Players)
            {
                PlayersListBox.Items.Add(player);
            }

            PlayersListBox.EndUpdate();

            ConfirmButton.Visible = false;
        }
    }
}
