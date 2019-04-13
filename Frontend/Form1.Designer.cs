using System.Windows.Forms;

namespace Frontend
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawTournamentButton = new System.Windows.Forms.Button();
            this.PlayersButton = new System.Windows.Forms.Button();
            this.DrawTeamButton = new System.Windows.Forms.Button();
            this.PlayersDataBaseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.FirstPagePanel = new System.Windows.Forms.Panel();
            this.InsertThePlayersErrorLabel = new System.Windows.Forms.Label();
            this.DrawTheTeamsErrorLabel = new System.Windows.Forms.Label();
            this.SecondPagePanel = new System.Windows.Forms.Panel();
            this.ResultViewPanel = new System.Windows.Forms.Panel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButtonFromPlayersPage = new System.Windows.Forms.Button();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.PlayersTextBox = new System.Windows.Forms.TextBox();
            this.PlayerStyleComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.NoNickNameErrorLabel = new System.Windows.Forms.Label();
            this.APlayerWithThisNameAlreadyAddedLabel = new System.Windows.Forms.Label();
            this.DataBasePagePanel = new System.Windows.Forms.Panel();
            this.BackButtonFromDataBasePage = new System.Windows.Forms.Button();
            this.BackButtonFromResultViewPage = new System.Windows.Forms.Button();
            this.EditViewButton = new System.Windows.Forms.Button();
            this.FirstPagePanel.SuspendLayout();
            this.SecondPagePanel.SuspendLayout();
            this.DataBasePagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawTournamentButton
            // 
            this.DrawTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DrawTournamentButton.Location = new System.Drawing.Point(857, 277);
            this.DrawTournamentButton.Name = "DrawTournamentButton";
            this.DrawTournamentButton.Size = new System.Drawing.Size(158, 68);
            this.DrawTournamentButton.TabIndex = 1;
            this.DrawTournamentButton.Text = "DrawTournament";
            this.DrawTournamentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DrawTournamentButton.UseVisualStyleBackColor = true;
            this.DrawTournamentButton.Click += new System.EventHandler(this.DrawTournamentButton_Click);
            // 
            // PlayersButton
            // 
            this.PlayersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersButton.Location = new System.Drawing.Point(195, 275);
            this.PlayersButton.Name = "PlayersButton";
            this.PlayersButton.Size = new System.Drawing.Size(158, 68);
            this.PlayersButton.TabIndex = 2;
            this.PlayersButton.Text = "Players";
            this.PlayersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PlayersButton.UseVisualStyleBackColor = true;
            this.PlayersButton.Click += new System.EventHandler(this.PlayersButton_Click);
            // 
            // DrawTeamButton
            // 
            this.DrawTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DrawTeamButton.Location = new System.Drawing.Point(531, 277);
            this.DrawTeamButton.Name = "DrawTeamButton";
            this.DrawTeamButton.Size = new System.Drawing.Size(158, 68);
            this.DrawTeamButton.TabIndex = 3;
            this.DrawTeamButton.Text = "DrawTeams";
            this.DrawTeamButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DrawTeamButton.UseVisualStyleBackColor = true;
            this.DrawTeamButton.Click += new System.EventHandler(this.DrawTeamsButton_Click);
            // 
            // PlayersDataBaseButton
            // 
            this.PlayersDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersDataBaseButton.Location = new System.Drawing.Point(195, 375);
            this.PlayersDataBaseButton.Name = "PlayersDataBaseButton";
            this.PlayersDataBaseButton.Size = new System.Drawing.Size(158, 68);
            this.PlayersDataBaseButton.TabIndex = 6;
            this.PlayersDataBaseButton.Text = "Database";
            this.PlayersDataBaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PlayersDataBaseButton.UseVisualStyleBackColor = true;
            this.PlayersDataBaseButton.Click += new System.EventHandler(this.PlayersDataBaseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ExitButton.Location = new System.Drawing.Point(1094, 601);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(158, 68);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.RestartButton.Location = new System.Drawing.Point(12, 601);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(158, 68);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "Restart";
            this.RestartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // FirstPagePanel
            // 
            this.FirstPagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstPagePanel.BackgroundImage")));
            this.FirstPagePanel.Controls.Add(this.RestartButton);
            this.FirstPagePanel.Controls.Add(this.ExitButton);
            this.FirstPagePanel.Controls.Add(this.DrawTeamButton);
            this.FirstPagePanel.Controls.Add(this.PlayersDataBaseButton);
            this.FirstPagePanel.Controls.Add(this.PlayersButton);
            this.FirstPagePanel.Controls.Add(this.DrawTournamentButton);
            this.FirstPagePanel.Controls.Add(this.InsertThePlayersErrorLabel);
            this.FirstPagePanel.Controls.Add(this.DrawTheTeamsErrorLabel);
            this.FirstPagePanel.Location = new System.Drawing.Point(-1, -1);
            this.FirstPagePanel.Name = "FirstPagePanel";
            this.FirstPagePanel.Size = new System.Drawing.Size(1264, 692);
            this.FirstPagePanel.TabIndex = 7;
            this.FirstPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FirstPagePanel_Paint);
            // 
            // InsertThePlayersErrorLabel
            // 
            this.InsertThePlayersErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsertThePlayersErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.InsertThePlayersErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.InsertThePlayersErrorLabel.Location = new System.Drawing.Point(400, 350);
            this.InsertThePlayersErrorLabel.Name = "InsertThePlayersErrorLabel";
            this.InsertThePlayersErrorLabel.Size = new System.Drawing.Size(628, 64);
            this.InsertThePlayersErrorLabel.TabIndex = 7;
            this.InsertThePlayersErrorLabel.Text = "Please first insert the players before drawing the teams!";
            this.InsertThePlayersErrorLabel.Visible = false;
            // 
            // DrawTheTeamsErrorLabel
            // 
            this.DrawTheTeamsErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DrawTheTeamsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DrawTheTeamsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DrawTheTeamsErrorLabel.Location = new System.Drawing.Point(720, 350);
            this.DrawTheTeamsErrorLabel.Name = "DrawTheTeamsErrorLabel";
            this.DrawTheTeamsErrorLabel.Size = new System.Drawing.Size(628, 64);
            this.DrawTheTeamsErrorLabel.TabIndex = 8;
            this.DrawTheTeamsErrorLabel.Text = "Please first draw the teams before drawing the tournament!";
            this.DrawTheTeamsErrorLabel.Visible = false;
            // 
            // SecondPagePanel
            // 
            this.SecondPagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondPagePanel.BackgroundImage")));
            this.SecondPagePanel.Controls.Add(this.EditViewButton);
            this.SecondPagePanel.Controls.Add(this.ConfirmButton);
            this.SecondPagePanel.Controls.Add(this.DeleteButton);
            this.SecondPagePanel.Controls.Add(this.EditButton);
            this.SecondPagePanel.Controls.Add(this.BackButtonFromPlayersPage);
            this.SecondPagePanel.Controls.Add(this.PlayersListBox);
            this.SecondPagePanel.Controls.Add(this.PlayersTextBox);
            this.SecondPagePanel.Controls.Add(this.PlayerStyleComboBox);
            this.SecondPagePanel.Controls.Add(this.AddButton);
            this.SecondPagePanel.Controls.Add(this.ImportButton);
            this.SecondPagePanel.Controls.Add(this.NoNickNameErrorLabel);
            this.SecondPagePanel.Controls.Add(this.APlayerWithThisNameAlreadyAddedLabel);
            this.SecondPagePanel.Location = new System.Drawing.Point(-1, -1);
            this.SecondPagePanel.Name = "SecondPagePanel";
            this.SecondPagePanel.Size = new System.Drawing.Size(1264, 692);
            this.SecondPagePanel.TabIndex = 8;
            this.SecondPagePanel.Visible = false;
            this.SecondPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SecondPagePanel_Paint);
            //
            // ResultViewPanel
            //
            this.ResultViewPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondPagePanel.BackgroundImage")));
            this.ResultViewPanel.Location = new System.Drawing.Point(-1, -1);
            this.ResultViewPanel.Controls.Add(this.BackButtonFromResultViewPage);
            this.ResultViewPanel.Name = "ResultViewPanel";
            this.ResultViewPanel.Size = new System.Drawing.Size(1264, 692);
            this.ResultViewPanel.Visible = false;
            this.ResultViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultViewPanel_Paint);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ConfirmButton.Location = new System.Drawing.Point(649, 516);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 42);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DeleteButton.Location = new System.Drawing.Point(794, 447);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 42);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.EditButton.Location = new System.Drawing.Point(649, 447);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 42);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButtonFromPlayersPage
            // 
            this.BackButtonFromPlayersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BackButtonFromPlayersPage.Location = new System.Drawing.Point(1077, 601);
            this.BackButtonFromPlayersPage.Name = "BackButtonFromPlayersPage";
            this.BackButtonFromPlayersPage.Size = new System.Drawing.Size(166, 64);
            this.BackButtonFromPlayersPage.TabIndex = 5;
            this.BackButtonFromPlayersPage.Text = "Back";
            this.BackButtonFromPlayersPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BackButtonFromPlayersPage.UseVisualStyleBackColor = true;
            this.BackButtonFromPlayersPage.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.BackColor = System.Drawing.Color.Gray;
            this.PlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersListBox.ItemHeight = 37;
            this.PlayersListBox.Location = new System.Drawing.Point(12, 36);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(400, 559);
            this.PlayersListBox.TabIndex = 6;
            this.PlayersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // PlayersTextBox
            // 
            this.PlayersTextBox.AcceptsReturn = true;
            this.PlayersTextBox.BackColor = System.Drawing.Color.Azure;
            this.PlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersTextBox.Location = new System.Drawing.Point(500, 157);
            this.PlayersTextBox.Name = "PlayersTextBox";
            this.PlayersTextBox.Size = new System.Drawing.Size(205, 38);
            this.PlayersTextBox.TabIndex = 7;
            this.PlayersTextBox.Text = "Nickname";
            this.PlayersTextBox.GotFocus += new System.EventHandler(this.PlayersTextBox_GotFocus);
            this.PlayersTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayersTextBox_Enter);
            this.PlayersTextBox.LostFocus += new System.EventHandler(this.PlayersTextBox_LostFocus);
            // 
            // PlayerStyleComboBox
            // 
            this.PlayerStyleComboBox.BackColor = System.Drawing.Color.Azure;
            this.PlayerStyleComboBox.DataSource = ((object)(resources.GetObject("PlayerStyleComboBox.DataSource")));
            this.PlayerStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerStyleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayerStyleComboBox.Location = new System.Drawing.Point(500, 226);
            this.PlayerStyleComboBox.Name = "PlayerStyleComboBox";
            this.PlayerStyleComboBox.Size = new System.Drawing.Size(205, 45);
            this.PlayerStyleComboBox.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.AddButton.Location = new System.Drawing.Point(500, 447);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 42);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add player";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ImportButton.Location = new System.Drawing.Point(857, 157);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(205, 38);
            this.ImportButton.TabIndex = 9;
            this.ImportButton.Text = "Import from DB";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // NoNickNameErrorLabel
            // 
            this.NoNickNameErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoNickNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.NoNickNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NoNickNameErrorLabel.Location = new System.Drawing.Point(497, 205);
            this.NoNickNameErrorLabel.Name = "NoNickNameErrorLabel";
            this.NoNickNameErrorLabel.Size = new System.Drawing.Size(628, 64);
            this.NoNickNameErrorLabel.TabIndex = 10;
            this.NoNickNameErrorLabel.Text = "Please add a nickname before adding a player!";
            this.NoNickNameErrorLabel.Visible = false;
            // 
            // APlayerWithThisNameAlreadyAddedLabel
            // 
            this.APlayerWithThisNameAlreadyAddedLabel.BackColor = System.Drawing.Color.Transparent;
            this.APlayerWithThisNameAlreadyAddedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.APlayerWithThisNameAlreadyAddedLabel.ForeColor = System.Drawing.Color.Red;
            this.APlayerWithThisNameAlreadyAddedLabel.Location = new System.Drawing.Point(572, 494);
            this.APlayerWithThisNameAlreadyAddedLabel.Name = "APlayerWithThisNameAlreadyAddedLabel";
            this.APlayerWithThisNameAlreadyAddedLabel.Size = new System.Drawing.Size(628, 64);
            this.APlayerWithThisNameAlreadyAddedLabel.TabIndex = 10;
            this.APlayerWithThisNameAlreadyAddedLabel.Text = "A player with this name already added!";
            this.APlayerWithThisNameAlreadyAddedLabel.Visible = false;
            // 
            // DataBasePagePanel
            // 
            this.DataBasePagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataBasePagePanel.BackgroundImage")));
            this.DataBasePagePanel.Controls.Add(this.BackButtonFromDataBasePage);
            this.DataBasePagePanel.Location = new System.Drawing.Point(-1, -1);
            this.DataBasePagePanel.Name = "DataBasePagePanel";
            this.DataBasePagePanel.Size = new System.Drawing.Size(1264, 692);
            this.DataBasePagePanel.TabIndex = 9;
            this.DataBasePagePanel.Visible = false;
            this.DataBasePagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DataBasePagePanel_Paint);
            // 
            // BackButtonFromDataBasePage
            // 
            this.BackButtonFromDataBasePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BackButtonFromDataBasePage.Location = new System.Drawing.Point(1077, 601);
            this.BackButtonFromDataBasePage.Name = "BackButtonFromDataBasePage";
            this.BackButtonFromDataBasePage.Size = new System.Drawing.Size(166, 64);
            this.BackButtonFromDataBasePage.TabIndex = 5;
            this.BackButtonFromDataBasePage.Text = "Back";
            this.BackButtonFromDataBasePage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BackButtonFromDataBasePage.UseVisualStyleBackColor = true;
            this.BackButtonFromDataBasePage.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonFromResultViewPage
            // 
            this.BackButtonFromResultViewPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BackButtonFromResultViewPage.Location = new System.Drawing.Point(1077, 601);
            this.BackButtonFromResultViewPage.Name = "BackButtonFromResultViewPage";
            this.BackButtonFromResultViewPage.Size = new System.Drawing.Size(166, 64);
            this.BackButtonFromResultViewPage.TabIndex = 5;
            this.BackButtonFromResultViewPage.Text = "Back";
            this.BackButtonFromResultViewPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BackButtonFromResultViewPage.UseVisualStyleBackColor = true;
            this.BackButtonFromResultViewPage.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditViewButton
            // 
            this.EditViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.EditViewButton.Location = new System.Drawing.Point(857, 233);
            this.EditViewButton.Name = "EditViewButton";
            this.EditViewButton.Size = new System.Drawing.Size(205, 38);
            this.EditViewButton.TabIndex = 15;
            this.EditViewButton.Text = "Edit view";
            this.EditViewButton.Visible = false;
            this.EditViewButton.UseVisualStyleBackColor = true;
            this.EditViewButton.Click += new System.EventHandler(this.EditViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SecondPagePanel);
            this.Controls.Add(this.FirstPagePanel);
            this.Controls.Add(this.DataBasePagePanel);
            this.Controls.Add(this.ResultViewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 881);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw foosball tournament";
            this.FirstPagePanel.ResumeLayout(false);
            this.SecondPagePanel.ResumeLayout(false);
            this.SecondPagePanel.PerformLayout();
            this.DataBasePagePanel.ResumeLayout(false);
            this.ResultViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Declaration

        private System.Windows.Forms.Button DrawTournamentButton;
        private System.Windows.Forms.Button PlayersButton;
        private System.Windows.Forms.Button DrawTeamButton;
        private System.Windows.Forms.Button PlayersDataBaseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Panel FirstPagePanel;
        private System.Windows.Forms.Panel SecondPagePanel;
        private System.Windows.Forms.Panel ResultViewPanel;
        private System.Windows.Forms.Panel DataBasePagePanel;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Button BackButtonFromPlayersPage;
        private System.Windows.Forms.Button BackButtonFromDataBasePage;
        private System.Windows.Forms.Button BackButtonFromResultViewPage;
        private System.Windows.Forms.TextBox PlayersTextBox;
        private System.Windows.Forms.ComboBox PlayerStyleComboBox;
        private System.Windows.Forms.ComboBox PlayersFromDbComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label NoNickNameErrorLabel;
        private System.Windows.Forms.Label InsertThePlayersErrorLabel;
        private System.Windows.Forms.Label DrawTheTeamsErrorLabel;
        private System.Windows.Forms.Label APlayerWithThisNameAlreadyAddedLabel;
        private Button EditButton;
        private Button DeleteButton;
        private Button ConfirmButton;

        #endregion Declaration

        private Button EditViewButton;
    }
}

