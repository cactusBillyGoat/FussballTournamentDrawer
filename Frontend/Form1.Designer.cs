using System.Drawing;
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

        #region Windows Form Designer generated code

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
            this.ExitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.FirstPagePanel = new System.Windows.Forms.Panel();
            this.SecondPagePanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.PlayersTextBox = new System.Windows.Forms.TextBox();
            this.PlayerStyleComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NoNickNameErrorLabel = new System.Windows.Forms.Label();
            this.APlayerWithThisNameAlreadyAddedLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.FirstPagePanel.SuspendLayout();
            this.SecondPagePanel.SuspendLayout();
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
            this.FirstPagePanel.Controls.Add(this.PlayersButton);
            this.FirstPagePanel.Controls.Add(this.DrawTournamentButton);
            this.FirstPagePanel.Location = new System.Drawing.Point(-1, -1);
            this.FirstPagePanel.Name = "FirstPagePanel";
            this.FirstPagePanel.Size = new System.Drawing.Size(1264, 692);
            this.FirstPagePanel.TabIndex = 7;
            this.FirstPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FirstPagePanel_Paint);
            // 
            // SecondPagePanel
            // 
            this.SecondPagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondPagePanel.BackgroundImage")));
            this.SecondPagePanel.Controls.Add(this.ConfirmButton);
            this.SecondPagePanel.Controls.Add(this.DeleteButton);
            this.SecondPagePanel.Controls.Add(this.EditButton);
            this.SecondPagePanel.Controls.Add(this.BackButton);
            this.SecondPagePanel.Controls.Add(this.PlayersListBox);
            this.SecondPagePanel.Controls.Add(this.PlayersTextBox);
            this.SecondPagePanel.Controls.Add(this.PlayerStyleComboBox);
            this.SecondPagePanel.Controls.Add(this.AddButton);
            this.SecondPagePanel.Controls.Add(this.NoNickNameErrorLabel);
            this.SecondPagePanel.Controls.Add(this.APlayerWithThisNameAlreadyAddedLabel);
            this.SecondPagePanel.Location = new System.Drawing.Point(-1, -1);
            this.SecondPagePanel.Name = "SecondPagePanel";
            this.SecondPagePanel.Size = new System.Drawing.Size(1264, 692);
            this.SecondPagePanel.TabIndex = 8;
            this.SecondPagePanel.Visible = false;
            this.SecondPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SecondPagePanel_Paint);
            // 
            // DeleteButton
            // 
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
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.EditButton.Location = new System.Drawing.Point(649, 447);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 42);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BackButton.Location = new System.Drawing.Point(1077, 601);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(166, 64);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.BackColor = System.Drawing.Color.White;
            this.PlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersListBox.ItemHeight = 37;
            this.PlayersListBox.Location = new System.Drawing.Point(12, 36);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(400, 559);
            this.PlayersListBox.TabIndex = 6;
            // 
            // PlayersTextBox
            // 
            this.PlayersTextBox.BackColor = System.Drawing.Color.Azure;
            this.PlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayersTextBox.Location = new System.Drawing.Point(500, 200);
            this.PlayersTextBox.Multiline = true;
            this.PlayersTextBox.Name = "PlayersTextBox";
            this.PlayersTextBox.Size = new System.Drawing.Size(205, 59);
            this.PlayersTextBox.TabIndex = 7;
            this.PlayersTextBox.Text = "Nickname";
            this.PlayersTextBox.GotFocus += new System.EventHandler(this.PlayersTextBox_GotFocus);
            this.PlayersTextBox.LostFocus += new System.EventHandler(this.PlayersTextBox_LostFocus);
            // 
            // PlayerStyleComboBox
            // 
            this.PlayerStyleComboBox.BackColor = System.Drawing.Color.Azure;
            this.PlayerStyleComboBox.DataSource = ((object)(resources.GetObject("PlayerStyleComboBox.DataSource")));
            this.PlayerStyleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PlayerStyleComboBox.Location = new System.Drawing.Point(500, 150);
            this.PlayerStyleComboBox.Name = "PlayerStyleComboBox";
            this.PlayerStyleComboBox.Size = new System.Drawing.Size(205, 45);
            this.PlayerStyleComboBox.TabIndex = 8;
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
            // NoNickNameErrorLabel
            // 
            this.NoNickNameErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoNickNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.NoNickNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NoNickNameErrorLabel.Location = new System.Drawing.Point(503, 262);
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
            this.APlayerWithThisNameAlreadyAddedLabel.Location = new System.Drawing.Point(503, 262);
            this.APlayerWithThisNameAlreadyAddedLabel.Name = "NoNickNameErrorLabel";
            this.APlayerWithThisNameAlreadyAddedLabel.Size = new System.Drawing.Size(628, 64);
            this.APlayerWithThisNameAlreadyAddedLabel.TabIndex = 10;
            this.APlayerWithThisNameAlreadyAddedLabel.Text = "A player with this name already added!";
            this.APlayerWithThisNameAlreadyAddedLabel.Visible = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ConfirmButton.Location = new System.Drawing.Point(649, 516);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 42);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SecondPagePanel);
            this.Controls.Add(this.FirstPagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw foosball tournament";
            this.FirstPagePanel.ResumeLayout(false);
            this.SecondPagePanel.ResumeLayout(false);
            this.SecondPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button DrawTournamentButton;
        private System.Windows.Forms.Button PlayersButton;
        private System.Windows.Forms.Button DrawTeamButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Panel FirstPagePanel;
        private System.Windows.Forms.Panel SecondPagePanel;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PlayersTextBox;
        private System.Windows.Forms.ComboBox PlayerStyleComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NoNickNameErrorLabel;
        private System.Windows.Forms.Label APlayerWithThisNameAlreadyAddedLabel;
        private Button EditButton;
        private Button DeleteButton;
        private Button ConfirmButton;
    }
}

