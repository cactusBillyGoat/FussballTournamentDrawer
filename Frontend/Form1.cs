using System;
using System.Collections.Generic;
using System.Drawing;
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
        private bool mImportedFromDataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayersButton_Click(object Sender, EventArgs E)
        {
            FirstPagePanel.Visible = false;
            InsertThePlayersErrorLabel.Visible = false;
            DrawTheTeamsErrorLabel.Visible = false;
            SecondPagePanel.Visible = true;
            GC.Collect();
        }

        private void DrawTournamentButton_Click(object Sender, EventArgs E)
        {
            if (!mTournament.AnyTeams)
            {
                DrawTheTeamsErrorLabel.Visible = true;
                InsertThePlayersErrorLabel.Visible = false;

                return;
            }

            mTournament.DrawTournament();

            if (mTournament.HasBeenDrawn)
            {
                FirstPagePanel.Visible = false;
                ResultViewPanel.Visible = true;
            }
            else
            {
                MessageBox.Show(@"A problem encountered, please review your input", @"Error!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DrawTeamsButton_Click(object Sender, EventArgs E)
        {
            if (!mTournament.AnyPlayers)
            {
                InsertThePlayersErrorLabel.Visible = true;
                DrawTheTeamsErrorLabel.Visible = false;

                return;
            }

            DrawTheTeamsErrorLabel.Visible = false;

            mTournament.DrawTeams();

            if (mTournament.TeamsHaveBeenDrawn)
            {
                MessageBox.Show(@"The teams have been draw successfully!", @"Info!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"A problem encountered, please review your input", @"Error!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void PlayersDataBaseButton_Click(object Sender, EventArgs E)
        {
            FirstPagePanel.Visible = false;
            DataBasePagePanel.Visible = true;
            GC.Collect();
        }

        private void ExitButton_Click(object Sender, EventArgs E)
        {
            Application.Exit();
        }

        private void AddButton_Click(object Sender, EventArgs E)
        {
            if (mImportedFromDataBase)
            {
                if (PlayersFromDbComboBox.SelectedItem.ToString() == string.Empty)
                {
                    NoNickNameErrorLabel.Visible = true;
                    return;
                }

                var nick_name = PlayersFromDbComboBox.SelectedItem.ToString().Split('-')[0].Trim();
                Enum.TryParse(PlayersFromDbComboBox.SelectedItem.ToString().Split('>')[1].Trim(), out Enums.PlayerStyle player_style);

                if (mTournament.Players.Contains(new Player(nick_name, player_style)))
                {
                    APlayerWithThisNameAlreadyAddedLabel.Visible = true;
                    return;
                }

                var player_from_db = new Player(nick_name, player_style);
                PlayersListBox.BeginUpdate();
                mTournament.AddPlayer(player_from_db);
                PlayersListBox.Items.Add(player_from_db);
                PlayersListBox.EndUpdate();

                return;
            }

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

        private void RestartButton_Click(object Sender, EventArgs E)
        {
            GC.Collect();
            Application.Restart();
        }

        private void SecondPagePanel_Paint(object Sender, PaintEventArgs E)
        {

        }

        private void ResultViewPanel_Paint(object Sender, PaintEventArgs E)
        {
            var y_distance = 200;
            foreach (var draw in mTournament.Tree)
            {
                var teams = draw.Split(new[]{"vs"},StringSplitOptions.RemoveEmptyEntries);
                var label1 = new Label
                {
                    BackColor = Color.Transparent,
                    Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0, true),
                    ForeColor = Color.White,
                    Location = new Point(200, y_distance),
                    Name = "team",
                    Size = new Size(400, 64),
                    TabIndex = 10,
                    Text = teams[0],
                    Visible = true
                };
                var label2 = new Label
                {
                    BackColor = Color.Transparent,
                    Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0, true),
                    ForeColor = Color.White,
                    Location = new Point(600, y_distance),
                    Name = "team",
                    Size = new Size(400, 64),
                    TabIndex = 10,
                    Text = teams[1],
                    Visible = true
                };

                y_distance += 100;

                ResultViewPanel.Controls.Add(label1);
                ResultViewPanel.Controls.Add(label2);
            }
        }

        private void DataBasePagePanel_Paint(object Sender, PaintEventArgs E)
        {

        }

        private void FirstPagePanel_Paint(object Sender, EventArgs E)
        {

        }

        private void BackButton_Click(object Sender, EventArgs E)
        {
            FirstPagePanel.Visible = true;
            SecondPagePanel.Visible = false;
            DataBasePagePanel.Visible = false;
            ResultViewPanel.Visible = false;
            var controls_to_remove = new List<Control>();
            foreach (Control control in ResultViewPanel.Controls)
            {
                if (control.Text != @"Back")
                {
                    controls_to_remove.Add(control);
                }
            }

            foreach (var control in controls_to_remove)
            {
                ResultViewPanel.Controls.Remove(control);
            }

            GC.Collect();
        }

        private void PlayersTextBox_GotFocus(object Sender, EventArgs E)
        {
            if (PlayersTextBox.Text == cmNickName)
            {
                PlayersTextBox.Text = string.Empty;
            }
        }

        private void PlayersTextBox_LostFocus(object Sender, EventArgs E)
        {
            if (PlayersTextBox.Text == string.Empty)
            {
                PlayersTextBox.Text = cmNickName;
            }
        }

        private void EditButton_Click(object Sender, EventArgs E)
        {
            PlayerStyleComboBox.SelectedItem = ((Player) PlayersListBox.SelectedItem).PreferredPosition;
            PlayersTextBox.Text = ((Player) PlayersListBox.SelectedItem).NickName;
            mOldName = PlayersTextBox.Text;

            if (mImportedFromDataBase)
            {
                PlayerStyleComboBox.Visible = true;
                PlayersTextBox.Visible = true;
                PlayersFromDbComboBox.Visible = false;
            }

            ConfirmButton.Visible = true;
        }

        private void DeleteButton_Click(object Sender, EventArgs E)
        {
            var player = new Player(((Player) PlayersListBox.SelectedItem).NickName, Enums.PlayerStyle.Attack);
            mTournament.DeletePlayer(player);

            PlayersListBox.BeginUpdate();
            PlayersListBox.Items.Remove(player);
            PlayersListBox.EndUpdate();
        }

        private void ConfirmButton_Click(object Sender, EventArgs E)
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

            if (mImportedFromDataBase)
            {
                PlayerStyleComboBox.Visible = false;
                PlayersTextBox.Visible = false;
                PlayersFromDbComboBox.Visible = true;

                PlayerStyleComboBox.SelectedItem = Enums.PlayerStyle.Attack;
                PlayersTextBox.Text = cmNickName;
            }

            ConfirmButton.Visible = false;
        }

        private void PlayersListBox_SelectedIndexChanged(object Sender, EventArgs E)
        {
            if (PlayersListBox.Items.Count == 0)
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;

                return;
            }

            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void PlayersTextBox_Enter(object Sender, KeyEventArgs E)
        {
            if (E.KeyCode == Keys.Enter)
            {
                AddButton_Click(this, new EventArgs());
            }
        }

        private void ImportButton_Click(object Sender, EventArgs E)
        {
            if (mImportedFromDataBase)
            {
                return;
            }

            PlayersTextBox.Visible = false;
            PlayerStyleComboBox.Visible = false;

            CreatePlayersFromDbComboBox();
            APlayerWithThisNameAlreadyAddedLabel.Visible = false;
            NoNickNameErrorLabel.Visible = false;
            EditViewButton.Visible = true;

            mImportedFromDataBase = true;
        }

        private void EditViewButton_Click(object Sender, EventArgs E)
        {
            PlayersTextBox.Visible = true;
            PlayerStyleComboBox.Visible = true;
            mImportedFromDataBase = false;
            APlayerWithThisNameAlreadyAddedLabel.Visible = false;
            NoNickNameErrorLabel.Visible = false;
            PlayersFromDbComboBox.Visible = false;
            EditViewButton.Visible = false;

            if (!ConfirmButton.Visible)
            {
                return;
            }

            ConfirmButton.Visible = false;
            PlayerStyleComboBox.SelectedItem = Enums.PlayerStyle.Attack;
            PlayersTextBox.Text = cmNickName;
        }

        private void CreatePlayersFromDbComboBox()
        {
            PlayersFromDbComboBox = new ComboBox
            {
                BackColor = Color.Azure,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0, true),
                Location = new Point(500, 190),
                Name = "PlayersFromDbComboBox",
                Size = new Size(300, 45),
                Visible = true
            };

            foreach (var player in mTournament.PlayersFromDb)
            {
                PlayersFromDbComboBox.Items.Add(player);
            }

            SecondPagePanel.Controls.Add(PlayersFromDbComboBox);
        }
    }
}
