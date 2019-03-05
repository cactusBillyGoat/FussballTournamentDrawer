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
            this.SuspendLayout();
            // 
            // DrawTournamentButton
            // 
            this.DrawTournamentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawTournamentButton.BackgroundImage")));
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
            this.PlayersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayersButton.BackgroundImage")));
            this.PlayersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.DrawTeamButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawTeamButton.BackgroundImage")));
            this.DrawTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DrawTeamButton.ForeColor = System.Drawing.Color.SaddleBrown;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DrawTeamButton);
            this.Controls.Add(this.PlayersButton);
            this.Controls.Add(this.DrawTournamentButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw foosball tournament";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button DrawTournamentButton;
        private System.Windows.Forms.Button PlayersButton;
        private System.Windows.Forms.Button DrawTeamButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
    }
}

